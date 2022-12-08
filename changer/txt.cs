using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace changer
{
    public static class txt
    {

        public static string sil;
        public static string pepope;
        public static string persik;
        public static void save_()
        {
            Console.WriteLine("F1 - сохранение");
            ConsoleKeyInfo T = Console.ReadKey();
            if (T.Key == ConsoleKey.F1)
            {
                Console.Clear();
                Console.WriteLine("Название сюда");
                sil = Console.ReadLine();
                FileInfo finik = new FileInfo(sil);
                if (finik.Extension == ".txt")
                {

                }
            }
        }


        public static void save()
        {

            ConsoleKeyInfo key = Console.ReadKey(true);
            while (key.Key != ConsoleKey.Escape)
            {

                if (key.Key == ConsoleKey.F1)
                {
                    Console.Clear();
                    string txt;
                    Console.WriteLine("Содержимое файла");
                    txt = File.ReadAllText("C:\\Users\\Andre\\OneDrive\\Рабочий стол\\грымза.txt");
                    Console.WriteLine(txt);
                }





                if (key.Key == ConsoleKey.F2)
                {
                    Console.Clear();
                    sil = Console.ReadLine();
                    FileInfo been = new FileInfo(sil);
                    txtit();
                }
                if (key.Key == ConsoleKey.F3)
                {
                    Console.Clear();
                    sil = Console.ReadLine();
                    FileInfo GG = new FileInfo(sil);
                    change.xml();
                }
                Console.ReadKey(true);


            }
        }

        public static void txtit()
        {
            pepope = File.ReadAllText(sil);
            Console.WriteLine(pepope);
        }
        public static void txts()
        {
            File.WriteAllText(sil, pepope);
        }
        public static void JsonSave()
        {
            string json = JsonConvert.SerializeObject(persik);
            File.WriteAllText(sil, json);
        }
        public static void Json()
        {
            pepope = File.ReadAllText(sil);
            List<amounts> res = JsonConvert.DeserializeObject <List<amounts>> (pepope);
            foreach (amounts i in res)
            {
                Console.WriteLine(i);
            }



        }
    }
}
