using EPAM.FoolballManager.DALCoach;
using EPAM.FoolballManager.DALCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAM.FoolballManager.DALDependencies
{
    public class CoachDALDependencies
    {
        public static ICoachDAL _coachDAL;
        public static ICoachDAL TheCoachDAL => _coachDAL ?? (_coachDAL = new CoachDAL());

    }
}
