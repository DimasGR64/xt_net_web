using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User.Entites
{
    public class UsersWithAwards
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public List<Award> UsersWithAwardList { get; set; }
        protected UsersWithAwards(Guid id, string name, DateTime dateOfBirth)
        {
            ID = Guid.NewGuid();
            Name = name;
            DateOfBirth = dateOfBirth;
            UsersWithAwardList = new List<Award>();
        }
    }
}
