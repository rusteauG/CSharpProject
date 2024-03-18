using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Points;
using ConsoleApp6.Humans;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Utilities.ColorWriteLine("Welcome", ConsoleColor.Blue);


            User user = new User("Nevillek", Race.Earthling);
            user.SayMyName(ConsoleColor.Yellow);
            Console.WriteLine(user.id);
            Console.WriteLine(user.HEIGHT);
            User user1 = new User("Jane", Race.Martian);
            user1.SayMyName(ConsoleColor.Magenta);
            Console.WriteLine(user1.id);
            Console.WriteLine(user1.HEIGHT);

            User user2 = new User("Lnanla", Race.Martian);
            Console.WriteLine(user2.id);
            Console.WriteLine(user2.HEIGHT);

        }
    }
}
