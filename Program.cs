using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IkiBoyutluDizilerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Öğrenci sayısını giriniz:");
            
            
                byte satir = byte.Parse(Console.ReadLine());
           
            string[,] ogrenciler = new string[satir+1,6];//ad soyad için +1

            
            ogrenciler[0,0] = "Ad";
            ogrenciler[0,1] = "Soyad";
            ogrenciler[0, 2] = "Vize";
            ogrenciler[0, 3] = "Final";
            ogrenciler[0, 4] = "Ortalama";
            ogrenciler[0, 5] = "Harf Notu";
            
            for (int i = 1; i < ogrenciler.GetLength(0); i++)// iki boyutlu diziler için satırlar 0. boyut olduğundan parametre 0 oldu tüm satıları al demiş olduk.
            {
                for (int j = 0; j < ogrenciler.GetLength(1); j++)//1. boyut sutünlar.
                {
                    

                    
                    switch (j)
                    {
                        case 0:
                            Console.WriteLine("Öğrenci adı Giriniz:");
                            ogrenciler[i, j] = Console.ReadLine();
                            break;
                        case 1:
                            Console.WriteLine("Öğrenci Soyadı Giriniz:");
                            ogrenciler[i, j] = Console.ReadLine();
                            break;

                        case 2:
                            Console.WriteLine("Öğrenci Vize notunu Giriniz:");
                            
                            
                            ogrenciler[i, j] = Console.ReadLine();
                            break;
                        case 3:
                            Console.WriteLine("Öğrenci Final notunu Giriniz:");
                            
                            
                            ogrenciler[i, j] = Console.ReadLine();
                            
                            break;
                        case 4:
                            int s1 = int.Parse(ogrenciler[i, 2]);
                            int s2 = int.Parse(ogrenciler[i, 3]);
                           
                            string s3 = Convert.ToString(((s1 * 40) / 100) + ((s2 * 60) / 100));
                            ogrenciler[i, j] = s3;
                            break;
                       case 5:
                            int h3 = int.Parse(ogrenciler[i, 4]);
                           
                            if (h3>89)
                            {
                                ogrenciler[i, j] = "AA";
                             
                            }
                            else if (h3>84)
                            {
                                ogrenciler[i, j] = "BA";
                            }
                            else if (h3>79)
                            {
                                ogrenciler[i, j] = "BB";
                            }
                            else if (h3>74)
                            {
                                ogrenciler[i, j] = "CB";
                            }
                            else if (h3>64)
                            {
                                ogrenciler[i, j] = "CC";
                            }
                            else if (h3>59)
                            {
                                ogrenciler[i, j] = "DC";
                            }
                            else if (h3>54)
                            {
                                ogrenciler[i, j] = "DD";
                            }
                            else if (h3>49)
                            {
                                ogrenciler[i, j] = "FD";
                            }
                            else
                            {
                                ogrenciler[i, j] = "FF";
                            }
                            break;

                        
                    }
                    
                    

                    
                    
                }
            }
            for (int i = 0; i < ogrenciler.GetLength(0); i++)
            {
                for (int j = 0; j < ogrenciler.GetLength(1); j++)
                {
                    Console.Write(ogrenciler[i,j]+"\t");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
            // içi içe iki forlar tablonun tüm hücrelerine sıra ile ulaşılıyor.


        }
    }
}
