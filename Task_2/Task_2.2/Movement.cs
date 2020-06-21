using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._2
{
    public abstract class AbstractMovement
    {
        private int speed;
        public int move;
    }
    public class MovementEnemy : AbstractMovement
    {
        public static int MoveEnemy(int coordinateX, int coordinateY)
        {
            GameArea area = new GameArea();
            Random r = new Random();
            int EnemyX = r.Next(0, area.Width);
            int EnemyY = r.Next(0, area.Height);
            int StepEnemy = r.Next(0, 4);

            switch (StepEnemy)
            {
                case 1:
                    return EnemyX--;
                case 2:
                    return EnemyX++;
                case 3:
                    return EnemyY--;
                default:
                    return EnemyY++;
            }
        }
    }
    public class MovementHero
    {
        public int HeroX = 55;
        public int HeroY = 15;
        public char move;
        public static void MoveHero()
        {
            MovementHero hero = new MovementHero();
            Border bord = new Border();
            GameArea area = new GameArea();
            ConsoleKeyInfo key = Console.ReadKey();
            var step = key.ToString();

            if (step == "a" && hero.HeroX > 0 && hero.HeroX != bord.BorderX) // movemet left
            {
                hero.HeroX--;
            }
            else if (step == "d" && hero.HeroX < area.Width && hero.HeroX != bord.BorderX) // movemet right
            {
                hero.HeroX--;
            }
            else if (step == "s" && hero.HeroY < area.Height && hero.HeroY != bord.BorderY) // movemet down
            {
                hero.HeroY++;
            }
            else if (step == "up" && hero.HeroY > 0 && hero.HeroY != bord.BorderY) // movemet up
            {
                hero.HeroY--;
            }
        }
    }
}