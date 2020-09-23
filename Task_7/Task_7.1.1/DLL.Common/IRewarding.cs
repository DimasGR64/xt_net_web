using DAL.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User.Entites;

namespace DLL.Common
{
    public interface IRewarding
    {
        IUserDAL Users { get; }
        IAwardDAL Awards { get; }
        void Rewaeding(Users userId, Award awardId);
        void UnRewaeding(Users userId, Award awardId);
    }
}
