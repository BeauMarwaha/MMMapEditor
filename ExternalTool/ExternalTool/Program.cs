using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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

            Console.WriteLine("The file has been saved, it can be located in the bin/debug folder");
        }
    }
}
