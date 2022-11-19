using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelefonRehberi.database;

namespace TelefonRehberi
{
    internal class AddUser
    {
        public void UserAdd()
        {
            Console.WriteLine("Lütfen isim giriniz:");
            string name = Console.ReadLine();
            Console.WriteLine("Lütfen soyisim giriniz:");
            string surname = Console.ReadLine();
            Console.WriteLine("Lütfen telefon numarası giriniz:");
            string number = Console.ReadLine();

            Users person = new Users();
            person.FirstName = name;
            person.LastName = surname;
            person.TelNumber = number;

            CreateDatabase.PhoneList.Add(person);
            Console.WriteLine(name + " " + surname + " added successfully.");
        }
        public bool CheckExist(string input)
        {
            bool exists = CreateDatabase.PhoneList.Any(x => x.FirstName == input || x.LastName == input);
            return exists;
        }
    }
}
