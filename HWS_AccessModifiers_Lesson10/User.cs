using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWS_AccessModifiers_Lesson10
{
    public class User
    {
        //Static Fields
        public const string NAME = "";
        public static User[] users = new User[3];
        //Instance Fields
        public readonly int id = 1000;
        public string userName;
        public string password;
        public bool isLogin;
        public Permission permission;

        public User()
        {
            id = 200;
        }
        public User(string userName, string password, bool isLogin, Permission permission)
        {
            this.userName = userName;
            this.password = password;
            this.isLogin = isLogin;
            this.permission = permission;
        }

        //public void ChangeId()
        //{
        //    id = 150;
        //}

        public static Permission Login(string userName, string password)
        {
            for (int i = 0; i < users.Length; i++)
            {
                if (userName.ToLower() == users[i].userName.ToLower() &&
                    password.ToLower() == users[i].password.ToLower())
                {
                    users[i].isLogin = true;
                    return users[i].permission;
                }
            }

            return Permission.None;
        }

        public static void Logout(User user)
        {
            user.isLogin = false;
        }
    }
