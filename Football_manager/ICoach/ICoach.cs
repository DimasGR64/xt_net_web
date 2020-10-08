using EPAM.FoolballManager.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAM.FoolballManager.DALCommon
{
    public interface ICoachDAL
    {
        IEnumerable<Players> GetAllPlayers(bool orderedById = true);
        bool AddNewPlayer(string name, int amplua, int age);
        bool DeletePlayer(int ID);
        bool AddCardsToPlayer(int cardID, int playerID);
        bool AddInjurnyToPlayer(int injurnyID, int playerID);
        bool DelCardsToPlayer(int cardID, int playerID);
        bool DelInjurnyToPlayer(int injurnyID, int playerID);
    }
}
