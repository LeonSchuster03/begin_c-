using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beginning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wie heißt du?");
            string username = Console.ReadLine();
            Console.WriteLine("Hello " + username);
            Console.WriteLine("Wie alt bist du?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Du bist also " + age);
            Console.ReadLine();
        }
    }
}
