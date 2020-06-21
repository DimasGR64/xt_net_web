using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._2
{
    public class CreateBonus
    {
        public BonusMother CreateBonusType(BonusType type)
        {
            switch (type)
            {
                case BonusType.BonusMother:
                    return new BonusMother(0);
                case BonusType.Cherry:
                    return new Cherry(10);
                case BonusType.Apple:
                    return new Apple(30);
                case BonusType.PineApple:
                    return new Pineapple(50);
                default: return null;
            }
        }
    }
    
    public abstract class AbstractBonus
    {
        private int BonusHelth;
        public virtual int Helth => BonusHelth;
        public AbstractBonus(int helth)
        {
            BonusHelth = helth;
        }
    }
   
    public class BonusMother : AbstractBonus
    {
        public int BonusHelth;
        public BonusMother(int helth) : base(helth)
        {
        }
    }
    public class Cherry : BonusMother
    {
        public int BonusHelth;
        public int cherryX = 55;
        public int cherryY = 15;
        public Cherry(int helth) : base(helth)
        {            
        }
    }
    public class Apple : BonusMother
    {
        public int BonusHelth;
        public int AppleX = 87;
        public int AppleY = 26;
        public Apple(int helth) : base(helth)
        {
        }
    }
    public class Pineapple : BonusMother
    {
        public int pineappleX = 32;
        public int pineappleY = 5;
        public int BonusHelth;
        public Pineapple(int helth) : base(helth)
        {
        }
    }
    public enum BonusType
    {
        None = 0,
        BonusMother = 1,
        Cherry = 2,
        Apple = 3,
        PineApple = 4
    }
}
