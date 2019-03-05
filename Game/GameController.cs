using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleGame.Units;
using ConsoleGame.Gui;
namespace ConsoleGame.Game
{
    class GameController
    {

        private GameScreen myGame = new GameScreen(10, 30);
        public GameController()
        {

        }
        public void InitGame()
        {
            Console.WriteLine("---Console Game---");
            Console.Write("Write Hero name: ");
            Random rnd = new Random();
            string enemyName = "Mob";
            int enemyId = 0;
            string inputName = Console.ReadLine();
            myGame.SetHero(new Hero(1, 1, inputName));
            for (int i = 0; i < 10; i++)
            {
                myGame.AddEnemy(new Enemy(enemyId, rnd.Next(0, 10), rnd.Next(0, 10), enemyName + " " + enemyId));
                enemyId++;

            }
        }
        public void StartGameLoop()
        {

            bool needToRender = false;
            do
            {
                Console.Clear();
                myGame.Render();
                while (Console.KeyAvailable)
                {
                    ConsoleKeyInfo pressedChar = Console.ReadKey(true);

                    switch (pressedChar.Key)
                    {
                        case ConsoleKey.Escape:
                            needToRender = true;
                            break;
                        case ConsoleKey.RightArrow:
                            myGame.MoveHeroRight();
                            myGame.MoveAllEnemiesDown();
                            needToRender = false;
                            break;
                        case ConsoleKey.LeftArrow:
                            myGame.MoveHeroLeft();
                            myGame.MoveAllEnemiesUp();
                            needToRender = false;
                            break;
                        case ConsoleKey.UpArrow:
                            myGame.MoveHeroUp();
                            needToRender = false;
                            break;
                        case ConsoleKey.DownArrow:
                            myGame.MoveHeroDown();
                            needToRender = false;
                            break;
                    }
                }
                System.Threading.Thread.Sleep(250);
            } while (needToRender == false);
            Console.Clear();
            GuiController gui = new GuiController();
            gui.ShowMenu();
        }
        public void StartGame()
        {
            InitGame();
            StartGameLoop();
        }
    }
}
