using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame.Gui
{
    sealed class GameWindow : Window
    {


        private Button _startButton;
        private Button _creditButton;
        private Button _quitButton;
        private TextBlock _gameTitle;
        private List<Button> _buttons = new List<Button>();
        private bool StartIsPressed = false;
        private bool CreditsIsPressed = false;
        private bool QuitIsPressed = false;

        public GameWindow() : base(0, 0, 100, 30, 'x', "SHARP HERO")
        {
            _gameTitle = new TextBlock(0, 2, Width - 2, "", "This game based on coordinates", "press start if u dare", "go home? press quit", "more info - check the credits");

            _buttons.Add(_startButton = new Button(5, 15, 18, 3, "Start", 0));
            _startButton.SetNotActive();
            _buttons.Add(_creditButton = new Button(40, 15, 18, 3, "Credits", 1));
            _creditButton.SetNotActive();
            _buttons.Add(_quitButton = new Button(76, 15, 18, 3, "Quit", 2));
            _quitButton.SetNotActive();


        }

        public void ShowNextLeftButton()
        {
            if (QuitIsPressed == true && StartIsPressed == false && CreditsIsPressed == false)
            {
                QuitIsPressed = false;
                buttonas(2).SetNotActive();
                buttonas(2).Render();

                CreditsIsPressed = true;
                buttonas(1).SetActive();
                buttonas(1).Render();

            }
            else if (CreditsIsPressed == true && QuitIsPressed == false && StartIsPressed == false)
            {
                CreditsIsPressed = false;
                buttonas(1).SetNotActive();
                buttonas(1).Render();

                StartIsPressed = true;
                buttonas(0).SetActive();
                buttonas(0).Render();

            }
        }
        public int EnterPressing()
        {
            if (CreditsIsPressed == true)
            {
                return 1;
            }
            else if (StartIsPressed == true)
            {
                return 0;
            }
            else if (QuitIsPressed == true)
            {
                return 2;
            }
            return 5;
        }
        public void ShowNextRightButton()
        {
            if (CreditsIsPressed == false && QuitIsPressed == false && StartIsPressed == false)
            {
                StartIsPressed = true;
                buttonas(0).SetActive();
                buttonas(0).Render();

            }
            else if (StartIsPressed == true && CreditsIsPressed == false)
            {
                StartIsPressed = false;
                buttonas(0).SetNotActive();
                buttonas(0).Render();

                CreditsIsPressed = true;
                buttonas(1).SetActive();
                buttonas(1).Render();

            }
            else if (CreditsIsPressed == true && QuitIsPressed == false)
            {
                CreditsIsPressed = false;
                buttonas(1).SetNotActive();
                buttonas(1).Render();

                QuitIsPressed = true;
                buttonas(2).SetActive();
                buttonas(2).Render();

            }

        }


        public Button buttonas(int buttonId)
        {
            foreach (Button button in _buttons)
            {
                if (button.ButtonId() == buttonId)
                {
                    return button;
                }
            }
            return null;
        }


        public override void Render()
        {
            base.Render();
            _gameTitle.Render();
            foreach (Button button in _buttons)
            {
                button.Render();
            }
        }

    }
}
