using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelefonRehberi.database;

namespace TelefonRehberi
{
    internal class DeleteUser
    {

        public void Delete()
        {
            while (true) {
                Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
                string input = Console.ReadLine();
                if (CheckExist(input))
                {
                    Users userDelete = CreateDatabase.PhoneList.FirstOrDefault(x=>x.FirstName==input || x.LastName==input );
                    bool confirmation = YesOrNo(userDelete);
                    if (confirmation)
                    {
                        CreateDatabase.PhoneList.Remove(userDelete);
                        Console.WriteLine("Silme işlemi gerçekleştirildi");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Silme işlemi gerçekleştirilmedi");
                        break ;
                    }

                }
                else
                {
                    if (NotExist() == 1)
                    {
                        break;
                    }
                }
             }

        }
        public bool CheckExist(string input)
        {
            bool exists = CreateDatabase.PhoneList.Any(x => x.FirstName == input || x.LastName == input);
            return exists;
        }
        public bool YesOrNo(Users input)
        {
            while (true)
            {
                Console.WriteLine(input.FirstName + " " + input.LastName + " isimli kişi rehberden silinmek üzere, onaylıyor musunuz ? Y/N");

                string option = Console.ReadLine().ToUpper();
                if (option == "Y")
                {
                    return true;
                  
                }
                else if (option == "N")
                {
                    return false;
                   
                }
                else
                {
                    Console.WriteLine("Gecersiz bir karakter girdiniz. Tekrar deneyiniz");
                }
            }

        }
        public int NotExist()
        {
            Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
            int input2;

            while (true)
            {
                Console.WriteLine("*Silmeyi sonlandırmak için : (1)");
                Console.WriteLine("*Yeniden denemek için      : (2)");

                if (int.TryParse(Console.ReadLine(), out input2))
                {
                    if (input2 == 1)
                    {
                        return 1;
                    }
                    else if (input2 == 2)
                    {
                        return 2;
                    }
                }
                else
                {
                    Console.WriteLine("Gecersiz bir karakter girdiniz. Tekrar deneyiniz ");
                }
            }
        }
    }

}
