﻿namespace gr.uoc.csd.Alpha {

    public static class AlphaPrograms {

        public static readonly string autolookup0 = @"x;";
        public static readonly string Herc = @"


endl = ""\n"";
S(*tart*) = 2;
E(*xit*) = 3;

function newLabyrinthData() {
    return [
        // Rowz
        [ S, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 1 ],
        [ 1, 1, 0, 1, 0, 0, 1, 0, 1, 1, 0, 0 ],
        [ 1, 1, 0, 1, 0, 0, 1, 0, 1, 1, 0, 1 ],
        [ 1, 1, 0, 1, 0, 0, 1, 0, 1, 0, 0, 0 ],
        [ 1, 1, 0, 1, 0, 0, 1, 0, 1, 1, 1, 0 ],
        [ 1, 0, 0, 1, 1, 0, 1, 0, 0, 0, 0, 0 ],
        [ 0, 0, 0, 0, 0, 0, 1, 0, 1, 1, 0, 0 ],
        [ 0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0 ],
        [ 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0 ],
        [ 0, 0, 1, 0, 0, 1, 1, 0, 0, 1, 0, E ]
    ];
} // function getLabyrinth

function newLabyrinth() {
    return [
        { ""data"" : newLabyrinthData() },
        { ""visualize"" : 
            (function (*visualize*)(lab) {
                result = [];
                for (j = 0; j < objecttotalmembers(lab); ++j) {
                    result[j] = [];
                    for (i = 0; i < objecttotalmembers(lab[j]); ++i)
                        if (lab[j][i] == S) result[j][i] = ""S"";
                        else if (lab[j][i] == E) result[j][i] = ""E"";
                        else if (not lab[j][i]) result[j][i] = "" "";
                        else result[j][i] = ""X"";
                }
                return result;
            })
        },
        { ""print"" :
            (function (*print*)(viz) {
                // NOTICE : nice bug here. If one forgets to add
                // the global scope resolution, there is a silly
                // recursion.
                for (j = 0; j < objecttotalmembers(viz); ++j) {
                    for (i = 0; i < objecttotalmembers(viz[j]); ++i)
                        ::print (viz[j][i]);
                    ::print (endl);
                }
            })
        },
        // Dispatcher functor
        { ""()"" :
            (function (*functor*)(this, what) {
                if (what == ""viz"")
                    return this.visualize(this.data);
                else if (what == ""print"")
                    return this.print(this(""viz""));
                else if (what == ""lab"")
                    return this.data;
                else if (what == ""maxJ"")
                    return objecttotalmembers(this(""lab""));
                else if (what == ""maxI"")
                    return objecttotalmembers(this(""lab"")[0]);
                else
                    return nil;
            })
        }
    ];
} // function newLabyrinth

Up = 0; Right = 1; Down = 2; Left = 3;
function newHercules(lab) {
    result = [
        {""direction"" : Right},
        {""x"" : 0},
        {""y"" : 0},
        {""lab"" : lab},
        {""marks"" : [""^"", "">"", ""v"", ""<""]},
        // Move functions return true if movement happened.
        { ""up"" : 
            (function (*move_up*)(me, lab) {
                lab = lab(""lab""); // get labyrinth data
                if (me.y - 1 <  0)
                    return false;
                next_block = lab[me.y - 1][me.x];
                if (next_block and not (next_block == E))
                    // not walkable
                    return false;
                // Move myself
                --me.y;
                return true;
            })
        },
        { ""right"" :
            (function (*move_right*)(me, lab) {
                if (me.x + 1 >= lab(""maxI""))
                    return false;
                lab = lab(""lab""); // get labyrinth data
                next_block = lab[me.y][me.x + 1];
                if (next_block and not (next_block == E))
                    // not walkable
                    return false;
                // Move myself
                ++me.x;
                return true;
            })
        },
        { ""down"" :
            (function (*move_down*)(me, lab) {
                if (me.y + 1 >= lab(""maxJ""))
                    return false;
                lab = lab(""lab""); // get labyrinth data
                next_block = lab[me.y + 1][me.x];
                if (next_block and not (next_block == E))
                    // not walkable
                    return false;
                // Move myself
                ++me.y;
                return true;
            })
        },
        { ""left"" :
            (function (*move_left*)(me, lab) {
                lab = lab(""lab""); // get labyrinth data
                if (me.x - 1 < 0)
                    return false;
                next_block = lab[me.y][me.x -1 ];
                if (next_block and not (next_block == E))
                    // not walkable
                    return false;
                //  Move myself
                --me.x;
                return true;
            })
        },
        // Moves forward as long as there is no wall
        // ahead. When a wall is encountered ahead,
        // he turns right.
        { ""move"" :
            (function (*move*)(me, lab) {
                for (i = 0; i < 4; ++i) {
                    if (not me.moves[me.direction](me, lab))
                        me(""turn"");
                    else
                        // Check if we reached exit
                        if (lab(""lab"")[me.y][me.x] == E) {
                            print (""<herc33gr> im free wheee!!111 :DDD"", endl);
                            return true;
                        } else 
                            // Keep trying hercie :/
                            return false;
                }
                print(""<herc33gr> omj im trapped lol"", endl);
                return true;
            })
        },
        { ""report"" :
            (function (*report*)(me) {
                // Get lab
                lab = me.lab;
                // Get lab's visualisation
                vlab = lab(""viz"");
                // Place ourself on the map
                vlab[me.y][me.x]= me.marks[me.direction];
                // Print it
                print (""----------------------------------------"", endl);
                lab.print(vlab);
            })
        },
        // Dispatcher functor
        { ""()"" :
            (function (*functor*)(me, what) {
                if (what == ""move"")
                    return me.move(me, me.lab);
                else if (what == ""turn"")
                    me.direction = ++me.direction % 4;
                else if (what == ""report"")
                    return me.report(me);
            })
        }
    ];

    result.moves = [
        result.up,
        result.right,
        result.down,
        result.left
    ];
    
    return result;
} // function newHercules

lab = newLabyrinth();
herc = newHercules(lab);

while (not herc(""move""))
    herc(""report"");
";

    }
    
}
