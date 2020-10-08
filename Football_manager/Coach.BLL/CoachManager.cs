using EPAM.FoolballManager.BLL.Common;
using EPAM.FoolballManager.Coach;
using EPAM.FoolballManager.DALCoach;
using EPAM.FoolballManager.DALCommon;
using EPAM.FoolballManager.DALDependencies;
using EPAM.FoolballManager.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAM.FoolballManager.Coach.BLL
{
    public class CoachManager : ICoachBLL
    {
        private ICoachDAL _coachDAL;
        public ICoachDAL Player { get; }
        public CoachDAL CoachDAL => new CoachDAL();
        public CoachManager()
        {
            _coachDAL = CoachDALDependencies.TheCoachDAL;
        }
        public bool AddNewPlayer(string name, int amplua, int age)
        {
            _coachDAL.AddNewPlayer(name, amplua, age);
            return true;
        }
        public IEnumerable<Players> GetAllPlayers(bool orderdById = true)
        {
            foreach (var item in _coachDAL.GetAllPlayers())
            {
                yield return item;
            }
        }

        public bool DeletePlayer(int ID)
        {
            return _coachDAL.DeletePlayer(ID);
        }

        public Players GetPlayerById(int id)
        {
            return _coachDAL.GetAllPlayers().FirstOrDefault(n => n.ID == id);
        }

        public bool AddCardsToPlayer(int cardID, int playerID)
        {
           return _coachDAL.AddCardsToPlayer(cardID, playerID);
        }

        public bool AddInjurnyToPlayer(int injurnyID, int playerID)
        {
            return _coachDAL.AddInjurnyToPlayer(injurnyID, playerID);
        }

        public bool DelCardsToPlayer(int cardID, int playerID)
        {
            return _coachDAL.DelCardsToPlayer(cardID, playerID);
        }

        public bool DelInjurnyToPlayer(int injurnyID, int playerID)
        {
            return _coachDAL.DelInjurnyToPlayer(injurnyID, playerID);
        }

        //public IEnumerable<Players> GetAllPlayers(bool orderdById = true) => CoachDAL.GetAllPlayers(orderdById);
    }
}
