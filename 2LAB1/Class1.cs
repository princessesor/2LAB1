//class.cs


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2LAB1
{
  abstract public class Class1
    {
        Dentist Den = new Dentist();
        storyteller storyteller = new storyteller();

        public class Student
        {
            public string line;
            public string firstname = "Firstname: Princes";
            public string lastname = "Lastname: Esor";
            public int yearofstudy = 2;
            public int id = 200568;
            public string gender = "female";
            public int avgscore = 75;

           public void cook()
            {
                Console.WriteLine(firstname + " can cook");
            }
        }
           public static void cook()
            {
                Console.WriteLine("i love cooking");
            }
       
    }
    public class Dentist : Class1
    {
        public string name = "Mr x";
        int age = 45;
        public string car = "mercedes";
    }

    public class storyteller : Class1
    {
        public string name = "Mrs x";
        int age = 37;
        public string car = "rolls royce";
    }

}
