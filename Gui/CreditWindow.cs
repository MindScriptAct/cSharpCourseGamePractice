using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame.Gui
{
   sealed class CreditWindow : Window
    {
        private Button _backButton;
        private TextBlock _creditTextBlock;
        public CreditWindow() : base(28, 5, 50, 20, '*', "Credits")
        {
            _backButton = new Button(48, 18, 10, 3, "Back", 3);
            _backButton.SetActive();
            _creditTextBlock = new TextBlock(29, 12, Width - 2, "This game made by VCS student Tadas", "2019");
        }

        public override void Render()
        {
            base.Render();

            _creditTextBlock.Render();
            _backButton.Render();
        }
    }
}
