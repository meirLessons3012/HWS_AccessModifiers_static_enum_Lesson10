using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWS_AccessModifiers_Lesson10
{
    internal class ClientManagmenent
    {
        private int counter;
        private string[] clientsNames;
        private int[] clientsAges;
        private bool[] clientsIsVeg;
        private string[] clientsPhones;

        public ClientManagmenent()
        {
            clientsNames = new string[10];
            clientsAges = new int[10];
            clientsIsVeg  = new bool[10];
            clientsPhones = new string[10];
        }

        public bool TryAddNewUser(string newName, int newAge, bool isVeg, string phone)
        {
            if(AddNewNameToList(newName) && AddNewAgeToList(newAge) && AddNewIsVegToList(isVeg) && AddNewPhoneToList(phone))
            {
                counter++;
                return true;
            }
            return false;
        }

        private bool AddNewNameToList(string newName)
        {
            if(!string.IsNullOrEmpty(newName) && counter < clientsNames.Length)
            {
                clientsNames[counter] = newName;
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool AddNewAgeToList(int newAge)
        {
            clientsAges[counter] = newAge;
            return true;
        }

        private bool AddNewIsVegToList(bool isVeg)
        {
            clientsIsVeg[counter] = isVeg;
            return true;
        }

        private bool AddNewPhoneToList(string newPhone)
        {
            clientsPhones[counter] = newPhone;
            return true;
        }
    }
}
