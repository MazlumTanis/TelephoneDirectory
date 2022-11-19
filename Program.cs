using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonRehberi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int selectOpt;


            while (true)
            {

                Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçin :)");
                Console.WriteLine("*****************************************");

                Console.WriteLine(" (1) Yeni numara kaydetmek");
                Console.WriteLine(" (2) Varolan numarayı silmek");
                Console.WriteLine(" (3) Varolan numarayı güncellemek");
                Console.WriteLine(" (4) Rehberi listelemek");
                Console.WriteLine(" (5) Rehberde arama yapmak ");

                selectOpt = Int32.Parse(Console.ReadLine());
                switch (selectOpt)
                {
                    case 1:
                      AddUser addUser = new AddUser();
                        addUser.UserAdd();
                        break;
                    case 2:
                        DeleteUser deleteUser = new DeleteUser();
                        deleteUser.Delete();
                        break;
                    case 3:
                        UpdateUser updateUser = new UpdateUser();
                        updateUser.userUpdate();
                        break;
                    case 4:
                        displayUser displayUser=new displayUser();
                        displayUser.UserDisplay();
                        break;
                    case 5:
                        SearchUser searchUser=new SearchUser();
                        searchUser.Search();
                        break;

                    default:
                        Console.WriteLine("Error lütfen belirtilen aralıkta bir numara giriniz");
                        break;
                }
            }
        }
    }
}
