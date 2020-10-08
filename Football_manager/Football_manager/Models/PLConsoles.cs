//using EPAM.FoolballManager.BLL.Common;
//using EPAM.FoolballManager.BLL.Dependencies;
//using EPAM.FoolballManager.Entites;
//using Football_manager.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace PLConsole
//{
//    public class PLConsoles : ICoachPL
//    {
//        private ICoachBLL _bllCoach;
//        public PLConsoles()
//        {
//            _bllCoach = CoachBLLDependencies.TheCoachBLL;
//        }
//        public bool AddNewPlayer(string name, int amplua, int age)
//        {
//            name = Console.ReadLine();

//            age = int.Parse(Console.ReadLine());

//            amplua = int.Parse(Console.ReadLine());

//            return _bllCoach.AddNewPlayer(name,age,amplua);
//        }

//        public IEnumerable<Players> GetAllPlayers(bool orderedById = true)
//        {
//            return _bllCoach.GetAllPlayers();
//        }

//        public bool DeletePlayer(int ID)
//        {
//           return _bllCoach.DeletePlayer(ID);
//        }

//        public Players GetPlayerById(int id)
//        {
//            return _bllCoach.GetPlayerById(id);
//        }
//        public bool AddCardsToPlayer(int cardID, int playerID)
//        {
//            return _bllCoach.AddCardsToPlayer(cardID, playerID);
//        }

//        public bool AddInjurnyToPlayer(int injurnyID, int playerID)
//        {
//            return _bllCoach.AddInjurnyToPlayer(injurnyID, playerID);
//        }

//        public bool DelCardsToPlayer(int cardID, int playerID)
//        {
//            return _bllCoach.DelCardsToPlayer(cardID, playerID);
//        }

//        public bool DelInjurnyToPlayer(int injurnyID, int playerID)
//        {
//            return _bllCoach.DelInjurnyToPlayer(injurnyID, playerID);
//        }
//    }
//}
