using Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALCommon
{
    public interface IAwardDAL
    {
        void AddAward(Award award);
        IEnumerable<Award> GetAllAwards();
        Award GetAwardByID(Guid id);
        bool DeleteAward(Guid id);
    }
}
