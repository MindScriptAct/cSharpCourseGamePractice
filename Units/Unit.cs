using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame.Units
{
    abstract class Unit
    {
        protected int X;
        protected int Y;
        protected string Name;

        public Unit(int X, int Y, string Name)
        {
            this.X = X;
            this.Y = Y;
            this.Name = Name;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"{Name} is at {X} : {Y}");
        }
    }
}
