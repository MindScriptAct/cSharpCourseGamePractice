using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleGame.Game;
namespace ConsoleGame.Gui
{
    class GuiController

    {
        private GameController _gameCtrl;
        private GameWindow _gameWind;
        private CreditWindow _creditWind;
        public GuiController()
        {
            _gameCtrl = new GameController();
            _gameWind = new GameWindow();
            _creditWind = new CreditWindow();

        }
        public void ShowMenu()
        {
            bool needToRender = false;

            _gameWind.Render();
            do
            {
                while (Console.KeyAvailable)
                {
                    ConsoleKeyInfo pressedChar = Console.ReadKey(true);
                    switch (pressedChar.Key)
                    {
                        case ConsoleKey.RightArrow:
                            _gameWind.ShowNextRightButton();
                            break;
                        case ConsoleKey.LeftArrow:
                            _gameWind.ShowNextLeftButton();
                            break;
                        case ConsoleKey.Enter:
                            if (_gameWind.EnterPressing() == 0)
                            {
                                Console.Clear();
                                _gameCtrl.StartGame();
                            }
                            else if (_gameWind.EnterPressing() == 1)
                            {
                                _creditWind.Render();
                                bool needToRenderCredits = false;
                                do
                                {
                                    while (Console.KeyAvailable)
                                    {
                                        ConsoleKeyInfo pressedChar2 = Console.ReadKey(true);
                                        switch (pressedChar2.Key)
                                        {
                                            case ConsoleKey.Escape:
                                                Console.Clear();
                                                needToRenderCredits = true;
                                                _gameWind.Render();
                                                break;
                                            case ConsoleKey.Enter:
                                                Console.Clear();
                                                needToRenderCredits = true;
                                                _gameWind.Render();
                                                break;
                                        }
                                    }
                                } while (needToRenderCredits == false);

                            }
                            else if (_gameWind.EnterPressing() == 2)
                            {
                                Environment.Exit(0);
                            }
                            else
                            {
                                break;
                            }
                            break;

                    }
                }
            } while (needToRender == false);
        }
    }

}
