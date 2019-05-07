using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.GUI
{
    sealed class GameWindow : Window
    {
        private TextBlock _titleTextBlock;
        public List<Button> buttons { get; set; } = new List<Button>();

        public GameWindow() : base(0, 0, 120, 30, '%')
        {
            _titleTextBlock = new TextBlock(10, 5, 100, new List<String> { "Super duper zaidimas", "Gina Golubickiene kuryba!", "Made in Vilnius Coding School!" });

            buttons.Add(new Button(20, 13, 18, 5, "Start"));
            buttons[0].SetActive();
            buttons.Add(new Button(50, 13, 18, 5, "Credits"));
            buttons.Add(new Button(80, 13, 18, 5, "Quit"));
        }
        
        public override void Render()
        {
            base.Render();

            _titleTextBlock.Render();

            buttons[0].Render();
            buttons[1].Render();
            buttons[2].Render();

            Console.SetCursorPosition(20, 13);
        }

        public void LeftActive()
        {
            if (buttons[0].IsActive)
            {
                buttons[0].DeActive();
                buttons[0].Render();
                buttons[2].SetActive();
                buttons[2].Render();
            }
            else if (buttons[1].IsActive)
            {
                buttons[1].DeActive();
                buttons[1].Render();
                buttons[0].SetActive();
                buttons[0].Render();
            }
            else
            {
                buttons[2].DeActive();
                buttons[2].Render();
                buttons[1].SetActive();
                buttons[1].Render();
            }
        }

        public void RightActive()
        {
            if (buttons[0].IsActive)
            {
                buttons[0].DeActive();
                buttons[0].Render();
                buttons[1].SetActive();
                buttons[1].Render();
            }
            else if (buttons[1].IsActive)
            {
                buttons[1].DeActive();
                buttons[1].Render();
                buttons[2].SetActive();
                buttons[2].Render();
            }
            else
            {
                buttons[2].DeActive();
                buttons[2].Render();
                buttons[0].SetActive();
                buttons[0].Render();
            }
        }
    }
}
