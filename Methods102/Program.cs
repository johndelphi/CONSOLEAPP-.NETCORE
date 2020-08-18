using System;

namespace Methods102
{
    class Program
    {
        static void Main(string[] args)
        {
          //  GetFirstName();
            Myfunction();
        }

        static void Myfunction()

        {
            Console.WriteLine("this is our function getting executed");
        }
        static string GetFirstName()
        {
            string Firstname = "";
            Console.WriteLine("enter first name:\n");
            Firstname = Console.ReadLine();
            return Firstname;
        }
    }
}
