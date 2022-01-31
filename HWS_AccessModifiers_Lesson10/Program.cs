using System;

namespace HWS_AccessModifiers_Lesson10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region HWS Access Modifiers

            ClientManagmenent cm1 = new ClientManagmenent();
            //cm1.AddNewNameToList("Yoske");
            //cm1.AddNewAgeToList(24);
            //cm1.AddNewIsVegToList(true);
            cm1.TryAddNewUser("Dano", 25, false, "91872081723");

            ClientManagmenent cm2 = new ClientManagmenent();

            //cm1.counter++;
            #endregion

            #region HWS Static Modifiers

            Console.WriteLine("3.2Beta");
            User u1 = new User
            {
                userName = "1",
                password = "1",
                permission = Permission.Admin,
                isLogin = false
            };
            User u2 = new User
            {
                userName = "2",
                password = "2",
                permission = Permission.Admin,
                isLogin = false
            };
            User u3 = new User
            {
                userName = "3",
                password = "3",
                permission = Permission.User,
                isLogin = false
            };
            User.users[0] = u1;
            User.users[1] = u2;
            User.users[2] = u3;
            User.Logout(u2);//static Method
            User.Login("1", "1");//static Method

            #endregion

            #region Enum Exr

            DaysOfWeek someDay = DaysOfWeek.Sunday;

            // Get All Values As Strin Array
            string[] s = Enum.GetNames(typeof(DaysOfWeek));

            //Parse
            string dayFromUser = "Monday";
            DaysOfWeek afterParse = (DaysOfWeek)Enum.Parse(typeof(DaysOfWeek), dayFromUser);
            //DaysOfWeek dd = DaysOfWeek.Tuesday;


            int res;
            int.TryParse("3aa2", out res);

            //Get Number Value From Enum
            int xx = (int)DaysOfWeek.Saturday;// = 6

            string nameOfValue = DaysOfWeek.Sunday.ToString();// = "Sunday"

            #endregion

        }
    }

    public enum DaysOfWeek
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
    }
}
