using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleGame.Units;

namespace ConsoleGame.Game
{
    class GameScreen
    {
        Random rnd = new Random();
        private Hero _hero;

        private int _width;
        private int _height;
        private List<Enemy> _enemies = new List<Enemy>();

        public GameScreen(int widht, int height)
        {
            _width = widht;
            _height = height;
        }
        public void SetHero(Hero hero)
        {
            _hero = hero;
        }
        public void MoveHeroRight()
        {
            if (_hero.GetX() < _width)
            {
                _hero.MoveRight();
            }

        }
        public void MoveHeroLeft()
        {
            if (_hero.GetX() > 0)
            {
                _hero.MoveLeft();
            }

        }
        public void MoveHeroUp()
        {
            if (_hero.GetY() > 0)
            {
                _hero.MoveUp();
            }
        }
        public void MoveHeroDown()
        {
            if (_hero.GetY() < _height)
            {
                _hero.MoveDown();
            }
        }
        public void AddEnemy(Enemy enemy)
        {
            _enemies.Add(enemy);
        }

        public void MoveAllEnemiesDown()
        {

            foreach (Enemy enemy in _enemies)
            {
                if (enemy.GetEnemyY() < _height)
                {
                    enemy.MoveDown();
                }

            }

        }
        public void MoveAllEnemiesUp()
        {
            foreach (Enemy enemy in _enemies)
            {
                if (enemy.GetEnemyY() > 0)
                {
                    enemy.MoveUp();
                }

            }
        }
        public Enemy GetEnemyByID(int id)
        {
            foreach (Enemy enemy in _enemies)
            {
                if (enemy.GetId() == id)
                {
                    return enemy;
                }
            }
            return null;
        }
        public void Render()
        {
            Console.WriteLine("Don't step on enemy!");
            _hero.PrintInfo();
            Console.WriteLine();
            foreach (Enemy enemy in _enemies)
            {
                enemy.PrintInfo();
            }
        }
    }
}
