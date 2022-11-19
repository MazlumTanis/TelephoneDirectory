using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelefonRehberi.database;

namespace TelefonRehberi.database
{
    internal class CreateDatabase
    {
        private static List<Users> _phoneList;

        static CreateDatabase()
        {
            _phoneList = new List<Users>()
            {
                new Users { FirstName = "Linda", LastName = "Burks", TelNumber = "(242) 352-0562" },
                new Users { FirstName = "Sara", LastName = "Ivy", TelNumber = "(986) 695-0671" },
                new Users { FirstName = "Cynthia", LastName = "Jones", TelNumber = "(415) 923-6596" },
                new Users { FirstName = "Toni", LastName = "Kenney", TelNumber = "(450) 379-0231" },
                new Users { FirstName = "Hiram", LastName = "Morro", TelNumber = "(643) 928-0063" }

            };
        }
            public static List<Users> PhoneList
        {
            get { return _phoneList; }
        }

    }
    }

