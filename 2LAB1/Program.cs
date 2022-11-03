//program.cs

using System;
using System.Collections.Generic;
using System.IO;

namespace _2LAB1
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader input_file = null;
            input_file = new StreamReader("princessfile.txt");

            StreamWriter output_file = new StreamWriter("princessfile.txt.out");

            string line = "";

            List<Class1.Student> elements = new List<Class1.Student>();

            for (int line_no = 1; (line = input_file.ReadLine()) != null; ++line_no)
            {
                Class1.Student element = new Class1.Student
                {
                    line = line
                };
                elements.Add(element);
            }

            foreach (Class1.Student iter in elements)
            {
                Console.WriteLine(iter.line);
                output_file.WriteLine(iter.line);
            }
            if (input_file != null)
            {
                input_file.Close();
                output_file.Close();
            }

            Class1.cook();

            Console.ReadLine();
        }
    } 
}
