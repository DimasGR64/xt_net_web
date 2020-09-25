using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entites
{
    public class Award
    {
        public Guid ID { get; }
        public string Type { get; set; }
        public List<Guid> ListOfAwarded { get; }
        public List<Guid> TotalAward { get; set; }
        public Award(Guid id, string type)
        {
            ID = id;
            Type = type;
            ListOfAwarded = new List<Guid>();
            TotalAward = new List<Guid>();
        }
    }
}
