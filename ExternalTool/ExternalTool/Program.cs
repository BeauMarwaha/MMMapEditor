using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//Author(s): Cody Freeman, Jared Miller, Beau Marwaha
//Purpose: External map editor that can be used with the game Mascot Mayhem
namespace ExternalTool
{
    class Program
    {
        static void Main(string[] args)
        {
            // array to hold the characters for map creation
            string[] map1 = new string[10]; // char[9] = 10 characters for the 10 x 10 map 

            //directions
            Console.WriteLine("Mascot Mayhem Map Editor");
            Console.WriteLine("Directions:");
            Console.WriteLine("Fill in each line with 10 tile type names using a comma to seperate each one");
            Console.WriteLine("Upon entering the tenth word in the line press enter to start the next line");
            Console.WriteLine("Each map is a 10 by 10 grid so fill each of the 10 lines with 10 tile types");
            Console.WriteLine("The tile types are: Field, River, Pavement, Forest, Win Tile");
            Console.WriteLine("Example input line: ");
            Console.WriteLine("Field,Field,Field,Field,Field,Field,Forest,Forest,River,Field");
            Console.WriteLine("");//spacing

            // loop to fill in the array
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Type in the map for row " + i); // ex: g, g, g, g, g, g, g, g, g, g
                map1[i] = Console.ReadLine(); // fills in the typed-in code to the array
            }

            // set up streamwriter
            Console.WriteLine("\nType in filename"); //custom map names
            string fileName = Console.ReadLine(); 

            // try block to handle the filewriting exceptions 
            try
            {
                // create StreamWriter
                StreamWriter output = new StreamWriter(fileName + ".txt");

                // output array data into the text file 
                for (int i = 0; i < 10; i++)
                {
                    output.WriteLine(map1[i]);
                }
                
                // close the streamwriter
                output.Close(); 
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace); 
            }

            // test - replace file characters with full words
            // ex: "f" becomes "field"
            // idea is to speed up map creation and allow faster creations of larger or more complex maps 

            // while loop to read through array 
            for(int i = 0; i < map1.Length; i++)
            {
                if(map1[i].Contains("f") == true)
                {
                    map1[i].Select(f => map1[i].Replace("f", "field")).ToArray(); 
                }
                else if(map1[i].Contains("r") == true)
                {
                    map1[i].Select(r => map1[i].Replace("r", "river")).ToArray();
                }
                else if(map1[i].Contains("p") == true)
                {
                    map1[i].Select(p => map1[i].Replace("p", "pavement")).ToArray();
                }
                else if(map1[i].Contains("fo") == true)
                {
                    map1[i].Select(fo => map1[i].Replace("fo", "forest")).ToArray();
                }
                else if(map1[i].Contains("w") == true)
                {
                    map1[i].Select(w => map1[i].Replace("w", "win tile")).ToArray();
                }
                else
                {
                    Console.WriteLine("Error: Unknown tile value. Please change to known tile value");
                    Console.WriteLine("Tile types: Field(f), River(r), Pavement(p), Forest(Fo), Win Tile(w)");
                }
            }
            Console.WriteLine("The file has been saved, it can be located in the bin/debug folder");
        }
    }
}
