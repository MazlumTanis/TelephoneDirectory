using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelefonRehberi.database;
namespace TelefonRehberi
{
    internal class SearchUser
    {
        public void Search()
        {

        Search:
            int selection;
            Console.WriteLine(" Arama yapmak istediğiniz tipi seçiniz.");
            Console.WriteLine(" **********************************************");
            Console.WriteLine(" İsim veya soyisime göre arama yapmak için: (1)");
            Console.WriteLine(" Telefon numarasına göre arama yapmak için: (2)");
            try
            {
               selection = Int32.Parse(Console.ReadLine());
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto Search;
            }
            
            if (selection == 1)
            {
                Console.WriteLine(" Lütfen arama yapmak istediğiniz isim veya soyisimi giriniz:");
                string input = Console.ReadLine();
               
                Users userSearch = CreateDatabase.PhoneList.FirstOrDefault(x=>x.FirstName==input || x.LastName==input);
                Show(userSearch);

            }
            else if(selection == 2)
            {
                Console.WriteLine(" Lütfen arama yapmak istediğiniz numarayı giriniz:");
                string input = Console.ReadLine();
               foreach(Users item in CreateDatabase.PhoneList)
                {
                    if (item.TelNumber.Contains(input))
                    {
                        Show(item);
                    }
                }

            }
            else
            {
                Console.WriteLine("Gecersiz bir karakter girdiniz.Tekrar deneyiniz");
                goto Search;
            }

        }
        public void Show(Users user)

        {
          
                Console.WriteLine(user.FirstName);
                Console.WriteLine(user.LastName);
                Console.WriteLine(user.TelNumber);
                Console.WriteLine("__________________");
        
            
        }
    }
}
