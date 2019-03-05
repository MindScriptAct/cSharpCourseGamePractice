using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame.Gui
{
    class Window : GuiObject
    {
        private Frame _frame;
        private TextLine _windowTitle;
        public Window(int x, int y, int width, int height, char frameChar, string titleText = "") : base(x, y, width, height)
        {
            _frame = new Frame(x, y, width, height, frameChar);
            if (titleText != "")
            {
                _windowTitle = new TextLine(x + 2, y + 1, width - 4, titleText);
            }

        }
        public override void Render()
        {
            _frame.Render();

            _windowTitle?.Render();


        }
    }
}
