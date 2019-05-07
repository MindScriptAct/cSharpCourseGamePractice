using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Game
{
    class Unit
    {
        protected int X;
        protected int Y;
        protected string Name;

        public Unit(int x, int y, string name)
        {
            X = x;
            Y = y;
            Name = name;
        }

        public void PrintInfo()
        {
            Console.WriteLine("Position x:{0} , y:{1}", X, Y);
        }
    }
}
