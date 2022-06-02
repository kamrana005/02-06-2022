using System;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("username");
            string us = Console.ReadLine();

            User user = new User(us);

            
            

            Console.WriteLine("password");
            user.Password = Console.ReadLine();
            

             
           










        }
    }
}
