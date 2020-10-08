using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAM.FoolballManager.Entites
{
    public class Cards
    {
        public string yellou = "Attention, one more and the player will miss the next match";

        public string Red = "Sorry, player missed next match";
        public int ID { get; set; }
        public string type { get; set; }
    }
}
