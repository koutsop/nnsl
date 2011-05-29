
def assert(cond)
	raise 'SHIT' unless cond
end

def clean_token(token)
	assert token
	md = /([<(']?)([\w\d_]+)([>)']?)/.match(token)
	assert md
	assert !(md[1] == '<')  || md[3] == '>'
	assert !(md[1] == '\'') || md[3] == '\''
	assert !(md[1] == '(')  || md[3] == ')'
	assert md[2]
	md[2]
end

def make_rule_id(rule_match_data)
	md = rule_match_data
	
	
	rule, symbols = md[6].split(' ::= ')
	
	rule = clean_token(rule)
	
	symbols = '___' + symbols.split(/\s+/).map! { |token| clean_token(token) }.join('__') if symbols
	
	id = rule + symbols.to_s
end


def make_manage_func_id(rule_match_data)
	md = rule_match_data
	
	rule_id = make_rule_id(md)
	
	id = rule_id
end

SymbolRegexp = /(\s*)([ABCDEFGHIJKLMNOPQRSTUVWXYZ_\d]+)(\s*)(\=)(\s*\d+,?\s*\/\/\s*[(<']?)([\w_\d ]+)(.*)$/
RuleRegexp = /^(\s*)([ABCDEFGHIJKLMNOPQRSTUVWXYZ_\d]+)(\s*)(\=)(\s*\d+,?\s*\/\/\s*)(.*)$/



class Triplet
	def initialize(l,c,r)
		@l = l
		@c = c
		@r = r
	end
	attr_reader(:l, :c, :r)
	
	def l_length= (length)
		@l = "%-#{length}s" % @l
	end
	
	def length
		@l.length
	end
	
	def to_s
		@l + @c + @r
	end
end


class RuleLineNormaliser
	def initialize(print)
		@print = print
		@lines = []
		nil
	end
	
	def append(linette)
		@lines << linette
		nil
	end
	
	def print_all
		max_length = @lines.max { |a,b| a.length <=> b.length }.length
		@lines.each { |line|
			case
			when line.is_a?(String) then @print[line, "\n"]
			when line.is_a?(Triplet) then
				line.l_length = max_length
				@print[line, "\n"]
			else raise 'Unknown shit exception'
			end
		}
	end
end

#################

def symbol_trans(line)
	md = SymbolRegexp.match(line)
	md[1] + md[6] + md[3] + md[4] + md[5] + md[6] + md[7]
end

def rule_trans(line)
	md = RuleRegexp.match(line)
	
	id = make_rule_id(md)
	
	Triplet.new(md[1] + id, md[4], md[5] + md[6])
end

def manage_func(line)
	md = RuleRegexp.match(line)

	id = make_manage_func_id(md)
	
	id + " (out TokenValue result, TokenValue[] rhs);"
end

def manages_population(line)
	md = RuleRegexp.match(line)
	
	rule_id = make_rule_id(md)
	func_id = make_manage_func_id(md)
	
	'manages[(int) ParserConstants.Rules.' + rule_id + '] = manager.' + func_id + ';'
end

if $0 == __FILE__

	argToSymbolMappings = {
		'symbol'		=> :symbol_trans		,
		'rule'			=> :rule_trans			,
		'manage'		=> :manage_func			,
		'manages'		=> :manages_population	,
	}
	
	symbol = argToSymbolMappings[ARGV[0]]
	
	if symbol then
		trans = method(symbol)
		ins = File.open(ARGV[1])
		norm = RuleLineNormaliser.new(method(:print))
		while line = ins.gets()
			norm.append(line = trans.call(line))
		end
		norm.print_all
	else
		printf 'Command: %s [%s]%s',
				$0,
				argToSymbolMappings.keys.join(' | '),
				"\n"
	end
end
