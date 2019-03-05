using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame.Gui
{
    abstract class GuiObject
    {
        protected int Height;
        protected int Width;
        protected int X;
        protected int Y;

        public GuiObject(int x, int y, int width, int height)
        {
            Height = height;
            Width = width;
            X = x;
            Y = y;
        }
        abstract public void Render();
    }

}
