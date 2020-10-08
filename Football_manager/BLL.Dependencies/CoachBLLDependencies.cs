using EPAM.FoolballManager.BLL.Common;
using EPAM.FoolballManager.Coach.BLL;
using EPAM.FoolballManager.DALCoach;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAM.FoolballManager.BLL.Dependencies
{
    public class CoachBLLDependencies
    {
        public static ICoachBLL _coachBLL;
        public static ICoachBLL TheCoachBLL => _coachBLL ?? (_coachBLL = new CoachManager());
    }
}
