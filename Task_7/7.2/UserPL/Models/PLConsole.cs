using BLL.Common;
using BLL.Dependencies;
using Entites;
using PL.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLConsole
{
    public class PLConsoles : IUserPL
    {
        public void DisplayAllUsers()
        {
            throw new NotImplementedException();
        }

        public void DisplayAllAwards()
        {
            throw new NotImplementedException();
        }

        public bool AddUser()
        {
            Console.WriteLine("Adding new User:" + Environment.NewLine);
            Console.WriteLine("Input the name User:" + Environment.NewLine);
            var name = Console.ReadLine();

            var id = Guid.NewGuid();

            Console.WriteLine("Input age User:" + Environment.NewLine);
            int age = int.Parse(Console.ReadLine());

            var data = System.DateTime.Now;

            return _bllUser.AddUser(new Users(id, name, data, age));
        }
        public bool AddAwards()
        {
            Console.WriteLine("Adding new Award:" + Environment.NewLine);
            Console.WriteLine("Input the name Award:" + Environment.NewLine);
            var name = Console.ReadLine();

            var id = Guid.NewGuid();

            return _bllAward.AddAward(new Award(id, name));
        }

        private IUserBLL _bllUser;
        private IAwardBLL _bllAward;

        public PLConsoles()
        {
            _bllUser = UsersBLLDependencies.UserBLL;
            _bllAward = UsersBLLDependencies.AwardBLL;
        }
    }
}
