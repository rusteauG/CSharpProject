
using System;
using ConsoleApp6;

namespace Points
{
    public class User

    {
        private string _username;
        private int _password;

        //private int _id;
        private static int currentID;
        public readonly int id;

        //public int id {  get { return currentID; } }

        public int HEIGHT {  get; private set; }
//        public readonly int HEIGHT;

        public Race race;

        public string username
        {
            get { return _username; }
            set
            {
                if (value.Length > 4 && value.Length < 8)
                {
                    _username = value;
                }else {
                    Console.WriteLine("Enter a username > 4 and 8 Chars");
                }
            }
        }



        public int password
        {
            get { return _password; }
            set { _password = value; }
        }



        public User()
        {
            currentID++;
            id = currentID;
        }
        public User(string username,Race race)
        {

            currentID++;
            id = currentID;
            _username = username;
            this.race = race;
            
            int defaultHeight = 150; // Default height for Earthling
            if (this.race == Race.Martian)
            {
                HEIGHT = 100; // Override default height for Martian
            }
            else
            {
                HEIGHT = defaultHeight; // Use default height for Earthling
            }
        }

        public void SayMyName(ConsoleColor color)
        {
            Utilities.ColorWriteLine(this.username,color);
        }

    }
}
