using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ConsoleApp1
{
    class DirectoryInfoTest
    {
        public static void Main()
        {
            //kullanılacak dizini tanımlama
            DirectoryInfo NewDir = new DirectoryInfo(@"C:\Test\TestDizini");
            try
            {
                //dizinin var olup olmadıgının kontrolü
                if (NewDir.Exists)
                {
                    Console.WriteLine("dizin mevcut");
                    //dizin silme işlemi
                    NewDir.Delete();
                    Console.WriteLine("dizin silindi");
                }
                //yeni dizin oluşturma
                NewDir.Create();
                Console.WriteLine("klasör olusturuldu ");
                Console.WriteLine("olusturulma tarihi " + NewDir.CreationTime);
                Console.WriteLine("bulundugu dizinin adı " + NewDir.Parent);
                Console.WriteLine("dizinin adı " + NewDir.Name);
                Console.WriteLine("dizinin tam adı " + NewDir.FullName);
                Console.WriteLine("son erişim tarihi " + NewDir.LastAccessTime);
                Console.WriteLine("son degistirilme tarihi " + NewDir.LastWriteTime);
                Console.ReadLine();
                //dizinin içerisinde alt dizin oluşturma
                DirectoryInfo SubDir = NewDir.CreateSubdirectory("AltDizin");
                //alt dizinin içerisinde alt dizin oluşturma
                SubDir.CreateSubdirectory("AltDizin2");
                //getfiles ile dizindeki dosyaların seçimi
                Console.WriteLine("{0} dizinindeki dosya sayısı {1}",NewDir.FullName,NewDir.GetFiles().Length);
                //getdirectory ile dizindeki klasörlerin secimi
                Console.WriteLine("{0} dizinindeki klasör sayısı {1}", NewDir.FullName, NewDir.GetDirectories().Length);
                Console.ReadLine();
            }
            catch(Exception e)
            {
                Console.WriteLine("işlem basarısız {0}", e.ToString());
            }
            finally
            {

            }
        }
    }
}
