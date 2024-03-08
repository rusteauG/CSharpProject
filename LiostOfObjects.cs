//ListOfObjects
using Microsoft.Win32;
using System;
using System.Media;

using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public static class Program
    {

        static void Main(string[] args)
        { 
        
            doSomething();
            
            Book book1 = new Book("Hunger Games","Nrvillek",200);
            Console.WriteLine(book1.GetBookDetails);
            // Create a new SoundPlayer object and load a sound file
            SoundPlayer player = new SoundPlayer(@"C:\Users\Admin\Downloads\Music\file.wav");

            // Play the sound
            player.Play();
            player.PlayLooping();
            Console.ReadLine();

        }

        public  static void doSomething()
        {
            /*8
            User me = new User();
            me.FirstName = "Test";
            me.LastName = "Test";
            //Console.WriteLine(me.FullName);

          /*  User you = new User();
            you.FirstName = "TestYou";
            you.LastName = "TestLast";
            //Console.WriteLine(you.FullName);
          */
            // more efficient way to create and manage objects with properties.than above
            List<User> users = new List<User>();
            
            users.Add(new User { FirstName = "Test", LastName = "Test" });
            users.Add(new User { FirstName = "TestYou", LastName = "TestLast" });


            foreach (User user in users)
            {
                //we now access the properties of the user Object
                Console.WriteLine(user.FullName);
            }

        }

    }


}
