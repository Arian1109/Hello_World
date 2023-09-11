using System;

namespace Hello_World
{
    class Class1
    {
        static void Main(string[] args)
        {
             
            
            Console.Write("Geben Sie Ihren Vornamen ein: ");
            string vorname = Console.ReadLine();

            
            Console.Write("Geben Sie Ihren Nachnamen ein: ");
            string nachname = Console.ReadLine();

            
            Console.Write("Geben Sie Ihr Alter ein: ");
            int alter = Convert.ToInt32(Console.ReadLine());

            
            Console.WriteLine("Hallo " + vorname + " " + nachname + "!");
            Console.WriteLine("Ihr Alter beträgt " + alter + " Jahre.");
        }
    }
}


