using DAL.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User.DLL.Dependencies;
using User.Entites;
using Newtonsoft.Json;
using System.IO;
using BLL.Common;
using DLL.Common;

namespace User.Bll
{
    public class UserManager : IUserBLL, IRewarding
    {
        public const string LocalDataPath = "Data\\";

        private IUserDAL _userDAL;
        public IUserDAL Users { get; }
        public IAwardDAL Awards { get; }
        
        #region IUser
        public UserManager()
        {
            _userDAL = UserDALDependencies.UserDAL;
        }
        public bool AddUser(Users user)
        {
            if (user.ID == Guid.Empty)
            {
                
                return false;
            }
            _userDAL.AddUser(user);
            return true;
        }
        public IEnumerable<Users> GetAllUser()
        {
            foreach (var item in _userDAL.GetAllUsers())
            {
                yield return item;
            }
        }
        public Users GetUserByID(Guid id)
        {
            return _userDAL.GetAllUsers().FirstOrDefault(n => n.ID == id);
        }
        public IEnumerable<UsersWithAwards> GetAllUserWithAwards()
        {
            throw new NotImplementedException();
        }
        public bool DeleteUser(Guid id)
        {
            if (id == Guid.Empty)
            {
                throw new ArgumentNullException("User is absent");
            }
            else
            {
                return _userDAL.DeleteUser(id);
            }
        }

        public void Rewaeding(Users user, Award award)
        {
            if (user.ID == Guid.Empty)
            {
                throw new ArgumentNullException("User is absent");
            }
            if (award.ID == Guid.Empty)
            {
                throw new ArgumentNullException("Award is absent");
            }
        }
        public void UnRewaeding(Users user, Award award)
        {
            if (user.ID == Guid.Empty)
            {
                throw new ArgumentNullException("User is absent");
            }
            if (award.ID == Guid.Empty)
            {
                throw new ArgumentNullException("Award is absent");
            }
        }
        #endregion Iuser

    }
}
