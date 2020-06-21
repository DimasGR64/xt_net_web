using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._2
{
    public abstract class AbstractPlayer
    {
        private int HelthOfPlayer;
        public AbstractPlayer(int _helth)
        {
            HelthOfPlayer = _helth;
        }
    }
    public class Hero : AbstractPlayer
    {

        public int _helth;
        public Hero(int _helth) : base (_helth)
        {
        }
    }
}
