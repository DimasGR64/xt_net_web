using Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALCommon
{
    public interface IRewardingDAL
    {
        IUserDAL Users { get; }
        IAwardDAL Awards { get; }
        void Rewaeding(Users userId, Award awardId);
        void UnRewaeding(Users userId, Award awardId);
    }
}
