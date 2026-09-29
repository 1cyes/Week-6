using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HELLOWORLD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            Console.WriteLine("Please enter your name: Isaias");
            string userName = Console.ReadLine();
            Console.WriteLine("Hello," + userName);
           
        }
    }
}
