using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame.Units
{
    class Hero : Unit
    {
        public Hero(int X, int Y, string Name) : base(X, Y, Name)
        {
        }
        public void MoveRight()
        {
            X++;
        }
        public void MoveLeft()
        {
            X--;
        }
        public void MoveUp()
        {
            Y--;
        }
        public void MoveDown()
        {
            Y++;
        }
        public int GetX()
        {
            return X;
        }
        public int GetY()
        {
            return Y;
        }
    }
}
