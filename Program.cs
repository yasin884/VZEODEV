using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace YSNODEVVİZE
{
    public class Program
    {
        static void Main(string[] args)
        {
            Kitap[] KitapDizi = new Kitap[0];
            {
                try
                {
                    Console.Write("Kitap,Yazar,Basım Yılı eklemek için 1'e, Kitap,Yazar,Basım Yılını görmek için 2'ye basın: ");
                    int secim = int.Parse(Console.ReadLine());
                    if (secim == 1)

                    {

                        Console.WriteLine("Kitap ekleme adeti?");
                        byte kitapSecim = byte.Parse(Console.ReadLine());
                        KitapDizi = new Kitap[kitapSecim];
                        for (int i = 0; i < kitapSecim; i++)
                        {
                            Kitap kitap = new Kitap();
                            Console.Write($"{i + 1}. Kitabınızın adı?: ");
                            kitap.KitapTitle = Console.ReadLine();
                            Console.Write($"{i + 1}. Kitabın yazarı?: ");
                            kitap.KitapYazar = Console.ReadLine();
                            Console.Write($"{i + 1}. Kitabın basım tarihi?: ");
                            kitap.KitapTarih = DateTime.Parse(Console.ReadLine());
                            while (kitap.KitapTarih.Year > 2020)
                            {
                                Console.Write($"{i + 1}. Kitabın basım yılını 2020'den küçük giriniz!");
                                Console.Write($"{i + 1}. Kitabın basım tarihini giriniz: ");
                                kitap.KitapTarih = DateTime.Parse(Console.ReadLine());
                            }
                            Console.Write($"{i + 1}. Kitabınızın türü?: ");
                            kitap.KitapTur = Console.ReadLine();
                            Console.WriteLine("Eklendi");
                            KitapDizi[i] = kitap;
                            Kitap.dosyaYaz(kitap.KitapTitle, kitap.KitapYazar, kitap.KitapTarih, kitap.KitapTur);
                        }

                        if (secim == 2)
                        {
                            Kitap.dosyaOku();


                            Console.WriteLine("TAnımlanandan farklı bir değer girdiniz. Lütfen tekrar deneyin.");
                        }


                    }
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("Boş değer.");
                }
                catch (FormatException)
                {
                    Console.WriteLine("HATA");
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Size belirtilen değerin dışına çıktınız.");
                }
                Console.ReadKey();
            }
        }
    }
}