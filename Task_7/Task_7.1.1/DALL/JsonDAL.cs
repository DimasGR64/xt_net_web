using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User.Entites;
using Newtonsoft.Json;
using DAL;
using DAL.Common;

namespace DAL
{
    public class JsonDAL : IUserDAL
    {
        public const string LocalDataPath = "Data\\";
        #region User
        public void AddUser(Users user)
        {
            if (user == null)
                throw new ArgumentNullException(nameof(Users));

            var userName = "User" + user.ID + ".json";

            var userStr = JsonConvert.SerializeObject(user);

            using (var writer = new StreamWriter(LocalDataPath + userName))
                writer.Write(userStr);
        }
        public IEnumerable<Users> GetAllUsers()
        {
            var directory = new DirectoryInfo(Environment.CurrentDirectory + "\\" + LocalDataPath);

            foreach (var file in directory.GetFiles())
                using (var reader = new StreamReader(file.FullName))
                    yield return JsonConvert.DeserializeObject<Users>(reader.ReadToEnd());
        }
        public Users GetUserByID(Guid id)
        {
            return GetAllUsers().FirstOrDefault(n => n.ID == id);
        }
        public IEnumerable<UsersWithAwards> GetAllUserWithAwards()
        {
            var directory = new DirectoryInfo(Environment.CurrentDirectory + "\\" + LocalDataPath);

            foreach (var file in directory.GetFiles())
                using (var reader = new StreamReader(file.FullName))
                    yield return JsonConvert.DeserializeObject<UsersWithAwards>(reader.ReadToEnd());
        }
        #endregion User
        #region Award
        public void AddAward(Award award)
        {
            if (award == null)
                throw new ArgumentNullException(nameof(Users));

            var awardName = "User" + award.ID + ".json";

            var awardStr = JsonConvert.SerializeObject(award);

            using (var writer = new StreamWriter(LocalDataPath + awardName))
                writer.Write(awardStr);
        }
        public IEnumerable<Award> GetAllAward()
        {
            var directory = new DirectoryInfo(Environment.CurrentDirectory + "\\" + LocalDataPath);

            foreach (var file in directory.GetFiles())
                using (var reader = new StreamReader(file.FullName))
                    yield return JsonConvert.DeserializeObject<Award>(reader.ReadToEnd());
        }
        public Award GetAwardByID(Guid id)
        {
            return GetAllAward().FirstOrDefault(n => n.ID == id);
        }
        #endregion Award
        public void AddAwardOnUser(Users user, Award award)
        {
            if (user == null)
                throw new ArgumentNullException(nameof(Users));
            if (award == null)
                throw new ArgumentNullException(nameof(Award));

            user.AwardList.Add(award.ID);
            award.ListOfAwarded.Add(user.ID);
        }
        public bool DeleteUser(Guid id)
        {
            try
            {
                File.Delete(Path.Combine(LocalDataPath, id.ToString()));
                return true;
            }
            catch (Exception)
            {
                throw new ArgumentNullException("File witn such id is absent");
            }
        }
    }
}
