using Game.Game;
using Game.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.SpecialClasses
{
    class GuiController : Window
    {
        private GameWindow _gameWindow;
        private CreditWindow _creditWindow;
        private GameController _gameController;

        public GuiController() : base(0, 0, 120, 30, '%')
        {
            _gameWindow = new GameWindow();
            _gameWindow.Render();
            _gameController = new GameController();
        }

        public void ShowMenu()
        {
            CheckKey();
        }

        public void CheckKey()
        {
            var ch = Console.ReadKey(false).Key;
            switch (ch)
            {
                case ConsoleKey.Enter:
                    if(_gameWindow.buttons[0].IsActive)
                    {
                        _gameController.StartGame();
                        _gameWindow.Render();
                        ShowMenu();
                    }
                    else if (_gameWindow.buttons[1].IsActive)
                    {
                        _creditWindow = new CreditWindow();
                        _creditWindow.Render();
                        checkCreditWindow();
                    }
                    else
                    {
                        break;
                    }
                    break;
                case ConsoleKey.LeftArrow:
                    _gameWindow.LeftActive();
                    CheckKey();
                    break;
                case ConsoleKey.RightArrow:
                    _gameWindow.RightActive();
                    CheckKey();
                    break;
                default:
                    CheckKey();
                    break;
            }
        }

        public void checkCreditWindow()
        {
            var check = Console.ReadKey(false).Key;
            switch (check)
            {
                case ConsoleKey.Enter:
                    _gameWindow.Render();
                    ShowMenu();
                    break;
                case ConsoleKey.Escape:
                    _gameWindow.Render();
                    ShowMenu();
                    break;
                default:
                    checkCreditWindow();
                    break;
            }
        }
    }
}
