using System.Collections;

namespace phone_book_app;

class Program
{
    static void Main(string[] args)
    {
        List<User> phoneBook = new List<User>();

        User user1 = new User("Mustafa", "Albayrak", "541 360 3292");
        phoneBook.Add(user1);
        User user2 = new User("Rick", "Sanchez", "111 111 1111");
        phoneBook.Add(user2);
        User user3 = new User("Rick", "Smith", "222 222 2222");
        phoneBook.Add(user3);
        User user4 = new User("Chris", "Hemsworth", "333 333 3333");
        phoneBook.Add(user4);
        User user5 = new User("Peggie", "Carter", "444 444 4444");
        phoneBook.Add(user5);
        
        /*foreach (User user in phoneBook)
        {
            Console.WriteLine($"İsim: {user.name}, Soyisim: {user.lastname}, Numara: {user.number}");
        }*/

        Console.WriteLine("Yapmak istedigin islemi seç");
        Console.WriteLine("***************************");
        Console.WriteLine("(1) Yeni Numara Kaydet, (2) Varolan Numarayı Sil, (3) Varolan Numarayı Güncelle, (4) Rehberi Listele, (5) Rehberde Arama Yap");
        int islem;
        islem = int.Parse(Console.ReadLine());
        if(islem == 1){
            string inputIsim;
            string inputSoyisim;
            string inputNumara;
            Console.WriteLine("Lütfen isim giriniz : ");
            inputIsim = Console.ReadLine();
            Console.WriteLine("Lütfen soyisim giriniz : ");
            inputSoyisim = Console.ReadLine();
            Console.WriteLine("Lütfen telefon numarası giriniz : ");
            inputNumara = Console.ReadLine();
            User user6 = new User(inputIsim,inputSoyisim,inputNumara);
            phoneBook.Add(user6);
        }else if(islem == 2){
            bool silmeIslemi = true;
            string inputSilinecekNumara;
            string yesNo;
            while(silmeIslemi){
                Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
                inputSilinecekNumara = Console.ReadLine();

                for(int i = 0; i < phoneBook.Count; i++){
                    User user = phoneBook[i];
                    if(user.name == inputSilinecekNumara || user.lastname == inputSilinecekNumara){

                        Console.WriteLine(user.name + " " + user.lastname + " isimli kişi rehberden silinmek üzere emin misiniz? (y/n)");
                        yesNo = Console.ReadLine();
                        if(yesNo == "y"){
                            phoneBook.RemoveAt(i);
                            silmeIslemi = false;
                            break;
                        }
                        
                        

                    }
                }
                    if(silmeIslemi == false){
                        break;
                    }
                
                    Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                    Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
                    Console.WriteLine("* Yeniden denemek için      : (2)");
                    int a;
                    a = int.Parse(Console.ReadLine());
                    if(a == 1){
                        silmeIslemi = false;
                    }else if(a == 2){
                        silmeIslemi = true;
                    }
            }
            

        }else if(islem == 3){
            string inputGuncelleme;
            bool guncellemeBool = true;
            while(guncellemeBool){
                Console.WriteLine("Lütfen numarasını guncellemek istediğiniz kişinin adını ya da soyadını giriniz:");
                inputGuncelleme = Console.ReadLine();

                for(int i = 0; i < phoneBook.Count; i++){
                    User user = phoneBook[i];
                    if(user.name == inputGuncelleme || user.lastname == inputGuncelleme){
                        Console.WriteLine("yeni telefon numarasını girin: ");
                        string yeniNumara = Console.ReadLine();

                        user.number = yeniNumara;
                        phoneBook[i] = user;
                        guncellemeBool = false;
                        break;
                    }



                }

                if(guncellemeBool == false){
                        break;
                    }
                Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                    Console.WriteLine("* Guncellemeyi sonlandırmak için : (1)");
                    Console.WriteLine("* Yeniden denemek için      : (2)");
                    int a;
                    a = int.Parse(Console.ReadLine());
                    if(a == 1){
                        guncellemeBool = false;
                    }else if(a == 2){
                        guncellemeBool = true;
                    }
                

            }
            

        }else if(islem == 4){
            Console.WriteLine("Telefon Rehberi ********************");
            foreach (User user in phoneBook)
            {
            Console.WriteLine($"İsim: {user.name}, Soyisim: {user.lastname}, Numara: {user.number}");
            }

        }else if(islem == 5){
            Console.WriteLine("Arama yapmak istediğiniz tipi seçin ********");
            Console.WriteLine("isim veya soyisme göre arama yapmak için (1): telefon numarasına göre aramak yapmak için (2)");
            int input;
            input = int.Parse(Console.ReadLine());
            string inputArama;
            if(input == 1){
                Console.WriteLine("isim veya soyisim gir:");
                
                inputArama = Console.ReadLine();
                for(int i = 0; i < phoneBook.Count; i++){
                    User user = phoneBook[i];
                    if(user.name == inputArama || user.lastname == inputArama){
                        Console.WriteLine($"İsim: {user.name}, Soyisim: {user.lastname}, Numara: {user.number}");
                    }



                }
                
            }else if( input == 2){
                Console.WriteLine("numara gir");
                inputArama = Console.ReadLine();
                for(int i = 0; i < phoneBook.Count; i++){
                    User user = phoneBook[i];
                    if(user.number == inputArama){
                        Console.WriteLine($"İsim: {user.name}, Soyisim: {user.lastname}, Numara: {user.number}");
                    }



                }

            }


        }

        /*foreach (User user in phoneBook)
        {
            Console.WriteLine($"İsim: {user.name}, Soyisim: {user.lastname}, Numara: {user.number}");
        }*/

        



        
        






    }

    class User{
        public string name;

        public string lastname;

        public string number;

        public User(string name, string lastname, string number){
            this.name = name;
            this.lastname = lastname;
            this.number = number;
        }
    }
}
