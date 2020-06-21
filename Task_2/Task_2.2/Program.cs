using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero hero = new Hero(100);
            Panter panter = new Panter(10);
            Lion lion = new Lion(30);
            Tiger tiger = new Tiger(50);
            Cherry cherry = new Cherry(10);
            Apple apple = new Apple(30);
            Pineapple pineapple = new Pineapple(50);
            Console.WriteLine("for movwment used key: W - up, A - left, S - down D - right");// не успел разобраться как преобразовать нажатие стрелками

            while (hero._helth > 0)
            {
                MovementHero.MoveHero();
                MovementEnemy.MoveEnemy(8,8);
                if (hero.HeroX == panter.PanterX && hero.HeroY == panter.PanterY)
                {
                    hero._helth = hero._helth - panter._damage;
                }
                else if (hero.HeroX == cherry.cherryX && hero.HeroY == cherry.cherryY)
                {
                    hero._helth = hero._helth + cherry.BonusHelth;
                }
            }
            Console.WriteLine("GAME OVER");
        }
    }
}
