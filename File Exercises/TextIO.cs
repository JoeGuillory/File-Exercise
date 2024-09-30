using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Exercises
{
    internal class TextIO
    {
        public void Run()
        {
            // Write the file
            string path = @"test.txt";
            if (!File.Exists(path))
            {
                try
                {

                    StreamWriter writer = new StreamWriter(path, false);
                    writer.WriteLine("Hello");
                    writer.WriteLine("And");
                    writer.WriteLine("Welcome!");
                    writer.Close();

                    // Dispose of the object
                    try
                    {

                        writer.Dispose();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }

            // Read file
            try
            {

                using (StreamReader reader = new StreamReader(path))
                {
                    string str;
                    while ((str = reader.ReadLine()) != null)
                    {
                        Console.WriteLine(str);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }


        }
    }
}
