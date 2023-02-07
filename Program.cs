using System;
using System.Runtime.CompilerServices;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Who You Are Stranger?");
            string name = Console.ReadLine();
            if (name == "Paulina") {
                Console.WriteLine("Cześć Paulina !");
            }
            if (string.IsNullOrWhiteSpace(name)) {
                Console.WriteLine("I will call you No One,then.");
                name = "No One";
            }
            else if (name.ToLower() == "no one") {
                Console.WriteLine("Ha! Good Try");}
            Console.WriteLine("Where are you from " + name + "?");
            string place = Console.ReadLine();
            if (place.ToLower() == "gdynia")
            {
                Console.WriteLine("Chyba Cię znam !!! :)");
            }
            if (string.IsNullOrWhiteSpace(place))
            {
                Console.WriteLine("You seems to be quaiet, are you?");
                place = "Quiet place ";
            }
            else if (place  == "quiet place") {
                Console.WriteLine("I belive you!");
            }
            else if (place == "QUIET PLACE") {
                Console.WriteLine("Please don't shout on me!");
            }
            Console.WriteLine($"Hello, {name} from {place}!");
            Console.WriteLine(  "Press any to continue....");
            Console.ReadKey(true);

            string[] level = {
            "###############",
            "#   #  #  ##  #",
            "# ###   ##   ##",
            "#    ###  ##  #",
            "#  #   #      #",
            "###    ##     #",
            "#    ##     ###",
            "##   #   ###  #",
            "#   ##   #    #",
            "###   #    ## #",
            "#    #    ##  #",
            "###############",
            };

            string[] scroll =
            {
                     "      ____________________",
                     " ()==(                   (@==()",
                     "      '___________________'|",
                     "        |                  |",
                     "        |                  |",
                     "        |                  |",
                     "        |                  |",
                     "      __)__________________|",
                     " ()==(                    (@==() ",
                     "      '-------------------' ",
            };

            Console.Clear();
            Console.WriteLine("You want to play?  Press any key to release map ...");

            int lineIndex = 0;  
            Console.WriteLine(scroll[lineIndex++]);
            Console.WriteLine(scroll[lineIndex++]);
            Console.WriteLine(scroll[lineIndex++]);
            Console.WriteLine(scroll[lineIndex++]);
            foreach (string row in level){
                Console.ReadKey(true);
                Console.WriteLine($"        | {row}  |");

            }
            Console.WriteLine(scroll[lineIndex++]);
            Console.WriteLine(scroll[lineIndex++]);
            Console.WriteLine(scroll[lineIndex++]);
            Console.WriteLine(scroll[lineIndex++]);
            Console.WriteLine(scroll[lineIndex++]);
            Console.WriteLine(scroll[lineIndex++]);


        }
    }
}