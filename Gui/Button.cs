using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame.Gui
{
    class Button : GuiObject
    {
        private Frame _buttonFrame;
        private TextLine _label;
        private bool _isActive;
        private int _buttonId;

        public Button(int x, int y, int width, int height, string label, int buttonId) : base(x, y, width, height)
        {
            _buttonFrame = new Frame(x, y, width, height, '*');
            _label = new TextLine(x + 1, y + Height / 2, Width - 2, label);
            _buttonId = buttonId;
            SetNotActive();
        }

        public override void Render()
        {
            _buttonFrame.Render();
            _label.Render();
        }
        public void SetActive()
        {
            _buttonFrame.SetRenderChar('x');
            _isActive = true;
        }
        public void SetNotActive()
        {
            _buttonFrame.SetRenderChar('o');
            _isActive = false;
        }
        public bool GetIsActive()
        {
            return _isActive;
        }
        public void PrintButton()
        {
            _buttonFrame.Render();
            _label.Render();
        }
        public int ButtonId()
        {
            return _buttonId;
        }
    }
}
