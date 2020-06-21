using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._2
{
    public class CreateEnum
    {
        public MotherOfEnemy CreateEnemyType(EnemyType type)
        {
            switch (type)
            {
                case EnemyType.MotherOfEnemy:
                    return new MotherOfEnemy(0);
                case EnemyType.Panter:
                    return new Panter(10);
                case EnemyType.Lion:
                    return new Lion(30);
                case EnemyType.Tiger:
                    return new Tiger(50);
                default: return null;
            }
        }
    }
    public abstract class AbstractEnemy
    {
        private int _damage;
        public AbstractEnemy(int damage)
        {
            _damage = damage;
        }
        public virtual int Damage => _damage;
    }
    public class MotherOfEnemy : AbstractEnemy
    {
        public int _damage;
        public MotherOfEnemy(int damage) : base(damage)
        {
        }
    }
    public class Panter : MotherOfEnemy
    {
        public int PanterX;
        public int PanterY;
        public int _damage;
        public Panter(int damage) : base(damage)
        {
        }
    }
    public class Lion : MotherOfEnemy
    {
        public int LionX;
        public int LionY;
        public int _damage;
        public Lion(int damage) : base(damage)
        {
        }
    }
    public class Tiger : MotherOfEnemy
    {
        public int TigerX;
        public int TigerY;
        public Tiger(int damage) : base(damage)
        {
        }
    }
    public enum EnemyType
    {
        None = 0,
        MotherOfEnemy = 1,
        Panter = 2,
        Lion = 3,
        Tiger = 4
    }
}
