using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6.Humans
{
    internal class Human
    {
        public int Height { get; set; }
        public int Weight { get; set; }

        public Human( int Height,int Weight)
        {
            this.Height = Height;
            this.Weight = Weight;
        }

    }
}
