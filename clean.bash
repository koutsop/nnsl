
	find . \( -name bin -o -name obj \) -prune -print0 | xargs -0 rm -r -f -v

