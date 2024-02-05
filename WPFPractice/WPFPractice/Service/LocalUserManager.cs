using System.Diagnostics;
using WPFPractice.Model;

namespace WPFPractice.Service {
    internal class LocalUserManager : IUserManager {
        internal List<User> UserList { get; private set; } = new();
        void IUserManager.Register(string id, string pw, string userName) {
            if(String.IsNullOrEmpty(id))
                throw new ArgumentNullException(nameof(id), "Cannot use null or Empty value");
            if(String.IsNullOrEmpty(pw))
                throw new ArgumentNullException(nameof(id), "Cannot use null or Empty value");
            if(String.IsNullOrEmpty(userName))
                throw new ArgumentNullException(nameof(id), "Cannot use null or Empty value");

            User user = new();
            user.ID = id;
            user.PW = pw;
            user.UserName = userName;

            UserList.Add(user);
            Debug.WriteLine("Login Complete");
        }

        User IUserManager.SignIn(string id, string pw) {
            // NOTE: FIND USER BY ID
            foreach(var user in UserList) {
                if(user.ID == id) {
                    if(user.PW == pw)
                        return user;
                    else
                        throw new Exception("Wrong PW");
                } else {
                    throw new Exception("Wrong ID");
                }

            }
            return new User();
        }
    }
}
