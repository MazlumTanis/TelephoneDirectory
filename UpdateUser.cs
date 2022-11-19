using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelefonRehberi.database;
namespace TelefonRehberi
{
    internal class UpdateUser
    {

      public void userUpdate()
        {
            userUpdate:
            while (true) {
                Console.WriteLine("Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz.");
                string input = Console.ReadLine();
                Users UserEdit = CreateDatabase.PhoneList.FirstOrDefault(x => x.FirstName == input || x.LastName == input);

                if(UserEdit != null)
                {
                    Console.WriteLine("Lütfen numarayı giriniz:");
                    string newPhoneNumb=Console.ReadLine();
                    UserEdit.TelNumber = newPhoneNumb;
                }
                else
                {
                    Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı.Lütfen bir seçim yapınız.");
                    while (true)
                    {

                        Console.WriteLine("* Güncellemeyi sonlandırmak için : (1)");
                        Console.WriteLine("* Yeniden denemek için      : (2)");
                        string choice = Console.ReadLine();
                        if (choice == "1")
                        {
                            Console.WriteLine("Çıkış yapıldı.");
                            return;
                        }
                        else if (choice == "2")
                            goto userUpdate;
                        else
                        {
                            Console.WriteLine("Gecersiz bir karakter girdiniz. Tekrar deneyiniz");
                        }
                    }
                }

                Console.WriteLine("Güncelleme başarıyla gerçekleştirilmiştir.");
            }
        }
    }

}
