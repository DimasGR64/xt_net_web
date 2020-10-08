using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace Football_manager.Models
{
    public class MyRoleProvider : RoleProvider
    {
        public override string[] GetRolesForUser(string username)
        {
            if (username == "Yuri_Siomin")
            {
                return new string[] { "Yuri_Siomin" };
            }
            if (username == "Medic")
            {
                return new string[] { "Medic" };
            }
            else
            {
                return new string[] { };
            }
        }
        public override bool IsUserInRole(string username, string roleName)
        {
            if (username == "Yuri_Siomin" && roleName == "Yuri_Siomin")
            {
                return true;
            }
            else if (username == "Medic" && roleName == "Medic")
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        #region role
        public override string[] GetUsersInRole(string roleName)
        {
            throw new NotImplementedException();
        }
        public override string ApplicationName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void AddUsersToRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override void CreateRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override bool DeleteRole(string roleName, bool throwOnPopulatedRole)
        {
            throw new NotImplementedException();
        }

        public override string[] FindUsersInRole(string roleName, string usernameToMatch)
        {
            throw new NotImplementedException();
        }

        public override string[] GetAllRoles()
        {
            throw new NotImplementedException();
        }





        public override void RemoveUsersFromRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override bool RoleExists(string roleName)
        {
            throw new NotImplementedException();
        }
    }
    #endregion role

}