using BLL.Common;
using PL.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User.BLL.Dependencies;
using User.Entites;

namespace PL
{
    public class PLConsole : IUserPL
    {
        static void Main(string[] args)
        {
            var pl = new PLConsole();
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

        public PLConsole()
        {
            _bll = UsersBLLDependencies.UserBLL;
        }
    }

}
