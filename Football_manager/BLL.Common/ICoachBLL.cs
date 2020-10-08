using EPAM.FoolballManager.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAM.FoolballManager.BLL.Common
{
    public interface ICoachBLL
    {
        IEnumerable<Players> GetAllPlayers(bool orderedById = true);
        bool AddNewPlayer(string name, int age, int amplua);
        bool DeletePlayer(int ID);
        Players GetPlayerById(int id);
        bool AddCardsToPlayer(int cardID, int playerID);
        bool AddInjurnyToPlayer(int injurnyID, int playerID);
        bool DelCardsToPlayer(int cardID, int playerID);
        bool DelInjurnyToPlayer(int injurnyID, int playerID);
    }
}
