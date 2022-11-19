using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelefonRehberi.database;

namespace TelefonRehberi
{
    internal class displayUser
    {
        public void UserDisplay()
        {
            foreach (Users item in CreateDatabase.PhoneList)
            {
                Show(item);

            }
        }
        public void Show(Users users)
        {
            Console.WriteLine(users.FirstName);
            Console.WriteLine(users.LastName);
            Console.WriteLine(users.TelNumber);
            Console.WriteLine("__________________");
        }
    }
}