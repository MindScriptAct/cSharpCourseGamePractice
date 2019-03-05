using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame.Units
{
    class Enemy : Unit
    {
        private int _id;

        public Enemy(int id, int X, int Y, string Name) : base(X, Y, Name)
        {
            _id = id;
        }
        public void MoveDown()
        {
            Y++;
        }
        public void MoveUp()
        {
            Y--;
        }
        public int GetEnemyY()
        {
            return Y;
        }
        public int GetId()
        {
            return _id;
        }
    }
}
