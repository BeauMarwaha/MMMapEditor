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
            string[,] map1 = new string[10, 10]; // char[9] = 10 characters for the 10 x 10 map 

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
                for (int j = 0; j < 10; j++)
                {
                    Console.WriteLine("Type in the map for row " + i + " column " + j); // ex: g, g, g, g, g, g, g, g, g, g
                    map1[i, j] = Console.ReadLine(); // fills in the typed-in code to the array 

                    if (map1[i, j] == "f")
                    {
                        map1[i, j] = "field";
                    }
                    else if (map1[i, j] == "r")
                    {
                        map1[i, j] = "river";
                    }
                    else if (map1[i, j] == "p")
                    {
                        map1[i, j] = "pavement";
                    }
                    else if (map1[i, j] == "fo")
                    {
                        map1[i, j] = "forest";
                    }
                    else if (map1[i, j] == "w")
                    {
                        map1[i, j] = "win tile";
                    }
                }
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
                        output.WriteLine(map1[i, 0] + "," + map1[i, 1] + "," + map1[i, 2] + "," + map1[i, 3] + "," + map1[i, 4] + "," + map1[i, 5] + "," + map1[i, 6] + "," + map1[i, 7] + "," + map1[i, 8] + "," + map1[i, 9]);
                    }

                    // close the streamwriter
                    output.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(ex.StackTrace);
                }

                // test - replace file characters with full words
                // ex: "f" becomes "field"
                // idea is to speed up map creation and allow faster creations of larger or more complex maps 


                Console.WriteLine("The file has been saved, it can be located in the bin/debug folder");
            }
        }
    }


