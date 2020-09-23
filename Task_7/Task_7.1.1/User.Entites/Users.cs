using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User.Entites
{
    public class Users
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Age { get; set; }
        public List<Guid> AwardList { get; set; }
        public List<Guid> TotalUsers { get; set; }
        public Users(Guid id, string name, DateTime data, int age)
        {
            ID = Guid.NewGuid();
            DateOfBirth = data;
            Name = name;
            Age = age;
            AwardList = new List<Guid>();
            TotalUsers = new List<Guid>();
        }
    }
}
