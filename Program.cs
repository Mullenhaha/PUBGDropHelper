using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace PUBGDropHelper
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "PUBG drophelper";
            string headerTitle = @"

  ____  _   _ ____   ____       _                 _          _                 
 |  _ \| | | | __ ) / ___|   __| |_ __ ___  _ __ | |__   ___| |_ __   ___ _ __ 
 | |_) | | | |  _ \| |  _   / _` | '__/ _ \| '_ \| '_ \ / _ | | '_ \ / _ | '__|
 |  __/| |_| | |_) | |_| | | (_| | | | (_) | |_) | | | |  __| | |_) |  __| |   
 |_|    \___/|____/ \____|  \__,_|_|  \___/| .__/|_| |_|\___|_| .__/ \___|_|   
                                           |_|                |_|              
                                      
";
            Console.WriteLine(headerTitle);

            bool mapSelected = false;

            string[] erangelArray = { "Zharki", "Severny", "Shooting Range", "Stalber", "Kameski", "Yasnaya Polyana", "Rozhok", "Georgopol", "Hospital", "Gatka", "Ruins", "Pochinki", "School", "Shelter", "Prison", "Mainsion", "Lipovka", "Mylta Power", "Mylta", "Farm", "Ferry Pier", "Quarry", "Primorsk", "Sosnovka Military Base", "Novorepnoye" };
            string[] miramarArray = { "Chumacera", "El Pozo", "La Cobreria", "Los Leones", "Valle del Mar", "Monte Nuevo", "San Martin", "Cruz del Valle", "El Azahar", "Impala", "Los Higos", "Pecado", "Puerto Paraíso", "Tierra Bronca", "Torre Ahumada", "La Bendita", "Hacienda del Patrón", "Prison" };
            string[] sanhokArray = { "Ha Tinh", "Camp Alpha", "Ruins", "Tambang", "Na Kham", "Sahmee", "Camp Charlie", "Pai Nan", "Docks", "Cave", "Kampong", "Lakawi", "Bhan", "Bootcamp", "Camp Bravo", "Paradise Resort", "Mongnai", "Tat Mok", "Khao"};
            string[] vikendiArray = { "Milnar", "Winery" , "Abbey", "Volnova", "Hot Springs", "Cantra", "Dino Park", "Movatra", "Vihar", "Tovar", "Castle", "Cement Factory", "Peshkova", "Trevno", "Cosmodrome", "Coal Mine", "Mount Kreznic", "Zabava", "Port", "Krichas", "Goroka", "Villa", "Dobro Mesto" };
            string[] sentenceArray = { "You are going to the eastern part of ", "Get ready for entry into the western part of ", "Pack you bags and get ready for action in the middle of ", "You are are going to the northern part of ", "Today's destination is the southern part of " };

            void goodLuck()
            {
                string goodLuckTypewrite = "Good luck....";
                for (int i = 0; i < goodLuckTypewrite.Length; i++) {
                    Console.Write(goodLuckTypewrite[i]);
                    Thread.Sleep(200);
                    }
            };

                                 
            while (mapSelected == false) {

                Console.WriteLine("Select your map by entering a number.");
                Console.WriteLine("1    -   Erangel");
                Console.WriteLine("2    -   Miramar");
                Console.WriteLine("3    -   Sanhok");
                Console.WriteLine("4    -   Vikendie");
                string mapSelection = Console.ReadLine();
                Console.WriteLine("___________________________________________________");

                switch (mapSelection) {
                    case "1": {
                            mapSelected = true;
                            Random rand = new Random();
                            int indexMap = rand.Next(erangelArray.Length);
                            int indexSentence = rand.Next(sentenceArray.Length);
                            Console.WriteLine($"{sentenceArray[indexSentence]}" + $"{erangelArray[indexMap]}" + " in Erangel");
                            goodLuck();
                            Console.ReadKey();
                            break;
                        };
                    case "2": {
                            mapSelected = true;
                            Random rand = new Random();
                            int indexMap = rand.Next(miramarArray.Length);
                            int indexSentence = rand.Next(sentenceArray.Length);
                            Console.WriteLine($"{sentenceArray[indexSentence]}" + $"{miramarArray[indexMap]}" + " in Miramar");
                            goodLuck();
                            Console.ReadKey();
                            break;
                        };
                    case "3": {
                            mapSelected = true;
                            Random rand = new Random();
                            int indexMap = rand.Next(sanhokArray.Length);
                            int indexSentence = rand.Next(sentenceArray.Length);
                            Console.WriteLine($"{sentenceArray[indexSentence]}" + $"{sanhokArray[indexMap]}" + " in Sanhok");
                            goodLuck();
                            Console.ReadKey();
                            break;
                        };
                    case "4": {
                            mapSelected = true;
                            Random rand = new Random();
                            int indexMap = rand.Next(vikendiArray.Length);
                            int indexSentence = rand.Next(sentenceArray.Length);
                            Console.WriteLine($"{sentenceArray[indexSentence]}" + $"{vikendiArray[indexMap]}" + " in Vikendi");
                            goodLuck();
                            Console.ReadKey();
                            break;
                        };
                    default: 
                            mapSelected = false;
                            Console.WriteLine("Enter a number!");
                            break;
                }
            }
        }
    }
}
