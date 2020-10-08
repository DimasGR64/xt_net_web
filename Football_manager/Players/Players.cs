using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAM.FoolballManager.Entites
{
    public class Players
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Amplua_ID { get; set; }
        public int Injurny_ID { get; set; }
        public int Cards_ID { get; set; }
        public override string ToString()
        {
            return string.Format("{0}, {1}, {2}, {3}, {4}, {5}", ID, Name, Age, Amplua_ID, Injurny_ID, Cards_ID);
        }
        public Players Player(int id, string name, int amplua, int age, int injurny, int cards)
        {
            return new Players()
            {
                ID = id,
                Name = name,
                Amplua_ID = amplua,
                Age = age,
                Injurny_ID = injurny,
                Cards_ID = cards
            };
        }
    }
}
