using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame.Gui
{
   sealed class TextBlock : GuiObject
    {
        private List<TextLine> _textBlocks = new List<TextLine>();

        public TextBlock(int x, int y, int width, params string[] texts) : base(x, y, width, texts.Length)
        {
            for (int i = 0; i < texts.Length; i++)
            {
                _textBlocks.Add(new TextLine(x, y + i, width, texts[i]));
            }
        }

        public override void Render()
        {
            foreach (TextLine item in _textBlocks)
            {
                item.Render();
            }
        }
    }
}
