using BLL.Common;
using DAL.Dependencies;
using DALCommon;
using Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User.BLL
{
    public class UserManager : IUserBLL, IRewardingDAL, IAwardBLL
    {
        public const string LocalDataPath = "Data\\";

        private IUserDAL _userDAL;
        private IAwardDAL _awardDAL;
        public IUserDAL Users { get; }
        public IAwardDAL Awards { get; }

        #region IUser
        public UserManager()
        {
            _userDAL = UserDALDependencies.UserDAL;
            _awardDAL = UserDALDependencies.AwardDAL;
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
        public bool AddAward(Award award)
        {
            if (award.ID == Guid.Empty)
            {

                return false;
            }
            _awardDAL.AddAward(award);
            return true;
        }
        #region Award
        public IEnumerable<Award> GetAllAward()
        {
            foreach (var item in _awardDAL.GetAllAwards())
            {
                yield return item;
            }
        }

        public Award GetAwardByID(Guid id)
        {
            return _awardDAL.GetAllAwards().FirstOrDefault(n => n.ID == id);
        }

        public Award DeleteAward(Guid id)
        {
            //TODO
            return _awardDAL.GetAwardByID(id);
        }
        #endregion Award
    }
}
