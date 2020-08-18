using System;
using System.Threading.Channels;

namespace DotNetCoreConsole
{
    class Program
    {
        static void SayHi()
        {
            Console.WriteLine("hi");
        }

        static void Main(string[] args)
        {

            SayHi();

        }
    }
}