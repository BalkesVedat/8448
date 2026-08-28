using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{

    internal class Program
    {
       static List<Customer> CustomerList = new List<Customer>();

        static void Main(string[] args)
        {
            Customer c1 = new Customer();
            c1.AccountNumber = 1;
            c1.Password = 1234;
            c1.CustomerName = "Ahmet Bey";
            c1.EMail = "aaa@bbb.com";

            CustomerList.Add(c1);

            Customer c2 = new Customer() { AccountNumber = 2, Password = 1234, CustomerName = "Ayşe Hanım", EMail = "sss@dddd.com", Balance = 100 };

            CustomerList.Add(c2);

            CustomerList.Add(new Customer() { AccountNumber = 3, Password = 1234, CustomerName = "Hakan Bey" });

            //Customer c4 = new Customer(4,"Zeynep Hanım", 1234, string.Empty, 0);

            CustomerList.Add(new Customer(4, "Zeynep Hanım", 1234, string.Empty, 0));

        // Giriş yapılıyor

        reEnter:
            Console.Write("Hesap No Gir:");

            int hesapNo = 0;

            try
            {
                hesapNo = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("\r\n");
                goto reEnter;
            }

        passwordEnter:
            Console.Write("Şifrenizi Girin:");

            int password = 0;

            try
            {
                password = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("\r\n");
                goto passwordEnter;
            }

            // Kullanıcı Kontrol

            // Customer customer = CustomerList.Where(a => a.AccountNumber == hesapNo).FirstOrDefault();

            Customer customer = MusteriGetir(hesapNo);

            if (customer.AccountNumber == 0 || password != customer.Password)
            {
                Console.WriteLine("Girdiğiniz Bilgiler hatalı, kontrol ederek tekrar giriniz.");
                goto reEnter;
            }

            int secim = 0;

            while (secim != 5)
            {
            menu:
                Console.Clear();
                Console.WriteLine($"Hoşgeldiniz Sayın {customer.CustomerName},");

                //Menü göster
                Console.WriteLine("İşlem Menüsü");
                Console.WriteLine("---------------------");
                Console.WriteLine("1 - Bakiye Görüntüle");
                Console.WriteLine("2 - Para Yatırma");
                Console.WriteLine("3 - Para Çekme");
                Console.WriteLine("4 - Havale/EFT");
                Console.WriteLine("5 - Çıkış");

                Console.Write("Lütfen işleminizi Seçiniz (1/2/3/4/5):");

              try
                {
                    secim = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Lütfen 1, 2, 3, 4, 5 seçeneklerinden birini girerek tekrar deneyiniz.");
                    Console.ReadKey();
                    goto menu;
                }

                // seçim kontrolü

                switch (secim)
                {
                    case 1:
                        BakiyeGoster(customer);
                        Console.ReadKey();
                        break;
                    case 2:
                        customer.Balance = ParaYatir(customer);
                        BakiyeGoster(customer);
                        Console.ReadKey();
                        break;
                    case 3:
                        customer.Balance = ParaCek(customer,0);
                        BakiyeGoster(customer);
                        Console.ReadKey();
                        break;
                    case 4:
                        Havale(customer);
                        Console.ReadKey();
                        break;
                    case 5:
                        //Cikis();
                        break;
                    default:
                        Console.WriteLine("Lütfen 1, 2, 3, 4, 5 seçeneklerinden birini girerek tekrar deneyiniz.");
                        Console.ReadKey();
                       // goto menu;
                        break;
                }

            }

            Console.WriteLine("Hoşçakalın...");
            Console.ReadKey();

        }

        private static Customer MusteriGetir(int hesapNo)
        {
            Customer customer = new Customer();

            foreach (Customer item in CustomerList)
            {
                if (item.AccountNumber == hesapNo)
                {
                    customer = item;
                }
            }
            return customer;
        }



        private static void Havale(Customer customer)
        {        
            Console.Write("Havale yapılacak HesapNo gir :");

            int karsiHesapNo = 0;

            try
            {
                karsiHesapNo = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Girilen Hesapno hatalı");
                Havale(customer);
            }

            //müşteri kontrol

            Customer karsiMusteri = MusteriGetir(karsiHesapNo);

            if (karsiMusteri.AccountNumber==0)
            {
                Console.WriteLine("Girdiğiniz HesapNo geçerli değil. Lütfen tekrar deneyiniz.");
                Havale(customer);
            }

            tekrar:
            Console.Write("Tutarı Giriniz:");
            double tutar = 0;
            try
            {
                tutar = double.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Geçersiz tutar. ");
                 goto tekrar;
            }

            customer.Balance = ParaCek(customer,tutar);
            ParaYatir(karsiMusteri,tutar);
            BakiyeGoster(customer);
        }

        private static void BakiyeGoster(Customer customer)
        {
            Console.WriteLine($"Hesap Bakiyeniz : {customer.Balance} 'dir.");
        }

        private static double ParaYatir(Customer customer) 
        {
        //tekrar:
            Console.Write("Tutarı Giriniz:");
            double tutar = 0;
            try
            {
                tutar = double.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("\r\n");
                // goto tekrar;
                ParaYatir(customer);
            }

            return customer.Balance + tutar;
        }

        private static double ParaYatir(Customer customer, double tutar)
        {
            if (tutar > 0) 
            {
                return customer.Balance + tutar;
            }

            //tekrar:
            Console.Write("Tutarı Giriniz:");
            
            try
            {
                tutar = double.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("\r\n");
                // goto tekrar;
                ParaYatir(customer);
            }

            return customer.Balance + tutar;
        }

        private static double ParaCek(Customer customer, double tutar)
        {
            if (tutar > 0 && tutar <= customer.Balance)
            {
                return customer.Balance - tutar;
            }
            else
            {
               // Console.WriteLine("Girilen Tutar hatalı yada bakiye yetersiz"); 
            }

            tekrar:
            Console.Write("Tutarı Giriniz:");
            try
            {
                tutar = double.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Girilen Tutar hatalı");
                // goto tekrar;
                ParaCek(customer,0);
            }

            if (tutar <= customer.Balance)
            {
                Console.WriteLine($"{tutar} TL hesabınızdan düşüldü.");
                return customer.Balance - tutar;
            }
            else 
            {
                Console.WriteLine($"Hesap Bakiyeniz yeterli değil lütfen yeni tutar giriniz. Bakiyeniz {customer.Balance} TL dir.");
                 goto tekrar;
               // Console.ReadKey();
               // return customer.Balance;
            }  

            

        }


    }
}
