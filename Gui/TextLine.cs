using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame.Gui
{
    class TextLine : GuiObject
    {
        private string _data;
        public TextLine(int x, int y, int width, string data) : base(x, y, width, 1)
        {
            _data = data;
        }
        public override void Render()
        {

            if (_data.Length < Width)
            {
                Console.SetCursorPosition(X + Width / 2 - _data.Length / 2, Y);
                Console.Write(_data);
            }
            else
            {
                Console.SetCursorPosition(X, Y);
                Console.Write(_data.Substring(0, Width));
            }
        }
    }

}
