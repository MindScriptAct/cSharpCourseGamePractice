using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame.Gui
{
    class Frame : GuiObject
    {
        private char _renderChar;
        public Frame(int x, int y, int width, int height, char renderChar) : base(x, y, width, height)
        {
            _renderChar = renderChar;
        }

        public override void Render() //perdengiantys remeliai
        {
            for (int i = 0; i < Height; i++)
            {
                Console.SetCursorPosition(X, Y + i);
                for (int j = 0; j < Width; j++)
                {
                    if (i == 0 || i == Height - 1 || j == 0 || j == Width - 1)
                    {
                        Console.Write(_renderChar);
                    }
                    else
                    {
                        Console.Write(' ');
                    }

                }
            }

        }
        public void SetRenderChar(char renderChar)
        {
            _renderChar = renderChar;
        }




        public void Render2() //pereinantys remeliai
        {


            Console.SetCursorPosition(X, Y);
            for (int i = X; i < X + Width; i++)
            {
                Console.Write(_renderChar);
            }
            Console.SetCursorPosition(X, Y + Height);
            for (int i = X; i < X + Width; i++)
            {
                Console.Write(_renderChar);
            }
            Console.SetCursorPosition(X, Y);
            for (int i = Y; i < Y + Height; i++)
            {
                Console.SetCursorPosition(X, i);
                Console.Write(_renderChar);
            }
            Console.SetCursorPosition(X + Width, Y);
            for (int i = Y; i <= Y + Height; i++)
            {
                Console.SetCursorPosition(X + Width, i);
                Console.Write(_renderChar);
            }

        }
    }
}
