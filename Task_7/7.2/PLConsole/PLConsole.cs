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
        static void Main(string[] args)
        {
            var pl = new PLConsoles();
            pl.AddUser();
        }

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

            return _bll.AddUser(new Users(id, name, data, age));
        }

        private IUserBLL _bll;

        public PLConsoles()
        {
            _bll = UsersBLLDependencies.UserBLL;
        }
    }
}
