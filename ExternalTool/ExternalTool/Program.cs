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

            // loop to fill in the array
            for(int i = 0; i < 10; i++)
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
                StreamWriter output = new StreamWriter(fileName);

                // input array data into the text file 
                output.WriteLine(map1);

                // close the streamwriter
                output.Close(); 
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace); 
            }
        }
    }
}
