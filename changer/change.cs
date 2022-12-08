using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace changer
{
    public class change
    {
        static int MyFavoriteNumber;

        static amounts andrey = new amounts("andrey", 77, MyFavoriteNumber);
        public static string putler;
        
        public static FileInfo shesh = new FileInfo(putler);
        public static void xml()
        {




            putler = Console.ReadLine();
            amounts andrey = new amounts();
            andrey.name = "Андрей";
            andrey.age = 77;
            andrey.MyFavoriteNumber = 13;
            XmlSerializer xml = new XmlSerializer(typeof(amounts));
            using (FileStream fs = new FileStream(putler, FileMode.OpenOrCreate))

            {
                xml.Serialize(fs, andrey);
            }
        }






        public static void desxml()
        {

                ConsoleKeyInfo tiny = Console.ReadKey();

                  
                    
                    XmlSerializer xml = new XmlSerializer(typeof(amounts));
                    using (FileStream fs = new FileStream(putler, FileMode.Open))
                    {

                        xml.Serialize(fs,andrey);
                    }
                
            
        }
        public static void biggy()
        {
            ConsoleKeyInfo kaif = Console.ReadKey();
            Console.WriteLine("Укажите расположение для файла");
            putler = Console.ReadLine();
            FileInfo TP = new FileInfo(putler);
            if (TP.Extension == ".txt")
            {
                txt.txtit();

            }

            if (TP.Extension == ".xml")
            {

                change.xml();

            }
            if (TP.Extension == ".json")
            {
                txt.JsonSave();
            }
            
        }



        
    } 
} 
