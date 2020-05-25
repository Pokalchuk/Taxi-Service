using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TaxiService
{
    static public class Base
    {
        private const int AmountTaxists = 300;
        private const int AmountUsers = 300;
        private const int AmountCars = AmountTaxists / 3;
        public static string RandomName(this Random rand)
        {
            const int Names = 15;
            string[] names = { "Vasil", "Roma", "Petro", "Nadia", "Irina", "Ivan", "Fedor", "Ostin", "Igor", "Artem", "Kolia", "Arthur", "Vitaliy", "Viktoria", "Stepan" };
            return names[rand.Next(Names)];
        }
        public static string RandomSurname(this Random rand)
        {
            const int Surnames = 15;
            string[] surnames = { "Pokalchuk", "Melnyk", "Porobko", "Kozachok", "Sagaidachniy", "Vasilevichka", "Gaychuk", "Parhomenko", "Samsonov", "Galkin", "Vlasenko", "Vilenskiy", "Pokhulyk", "Mizavich", "Koval" };
            return surnames[rand.Next(Surnames)];
        }
        public static string RandomStreet(this Random rand)
        {
            const int Streets = 15;
            string[] streets = { "Shevchenka", "Bohoyavlenska", "Omega", "Mir", "Moskovskaya", "Oleni Teligi", "Volodimira", "Romanovicha", "Yabluneva", "Sagaychuka", "Polovtsia", "Ogirkova", "Vishneva", "Zlota", "Soborna" };
            return streets[rand.Next(Streets)] +$":{rand.Next(1,45)}" + $",Entrance:{rand.Next(1,7)} ";
        }

        public static string RandomNameEconomCar(this Random rand)
        {
            const int Names = 5;
            string[] names = { "Lada", "Renault", "Cherry", "Citroen", "Ford" };
            return names[rand.Next(Names)];
        }
        public static string RandomNameLuxuryCar(this Random rand)
        {
            const int Names = 5;
            string[] names = { "Bugatti", "Alfa Romeo", "Bentley", "Maybach ", "Porsche" };
            return names[rand.Next(Names)];
        }
        public static string RandomNameTruck(this Random rand)
        {
            const int Names = 5;
            string[] names = { "Freightliner", "SNVI", "Fuso Canter", "Seddon Atkinson", "Scania" };
            return names[rand.Next(Names)];
        }
        public static string RandomModelCar(this Random rand)
        {
            const int Models = 5;
            string[] models = { "1", "2", "3", "4", "5" };
            return models[rand.Next(Models)];
        }
        public static string RandomNumberCar(this Random rand)
        {
            const int Codes = 5;
            string[] registAreaCode = { "BK", "AA", "BH", "AE", "CB" };
            const int SeriesNumber = 10;
            string[] seriesNumbers = { "BA", "KA", "AC", "BC", "AA", "AE", "CB", "BK", "CK", "AC" };
            int registrationNumber = 1001 + rand.Next(8900);
            string registrationNumberStr = registrationNumber.ToString();

            string number = registAreaCode[rand.Next(Codes)] + 
                registrationNumberStr + seriesNumbers[rand.Next(SeriesNumber)];
            return number;
        }
        public static bool NextBool(this Random rand)
        {
            return (rand.Next(100) <= 50) ? true : false;
        }
        public static void CreateBaseCars()
        {
            Random rand = new Random();
            List<Taxist> taxists = new List<Taxist>(AmountTaxists);
            for (int i = 0; i < taxists.Capacity; ++i)
            {
                taxists.Add(new Taxist(rand.RandomName(), rand.RandomSurname(),rand.NextBool()));
            }

            List<EconomCar> economCars = new List<EconomCar>(AmountCars);
            for (int i = 0; i < economCars.Capacity; ++i)
            {
                economCars.Add(new EconomCar(rand.RandomNameEconomCar(), rand.RandomModelCar(),
                    rand.RandomNumberCar(), rand.Next(1, 5), 
                    taxists[i], rand.NextBool(), rand.NextBool()));
            }

            List<LuxuryCar> luxuryCars = new List<LuxuryCar>(AmountCars);
            for (int i = 0; i < luxuryCars.Capacity; ++i)
            {
                luxuryCars.Add(new LuxuryCar(rand.RandomNameLuxuryCar(), rand.RandomModelCar(),
                    rand.RandomNumberCar(), rand.Next(1, 3), 
                    taxists[i + economCars.Capacity], rand.NextBool(), rand.NextBool()));
            }

            List<Truck> trucks = new List<Truck>(AmountCars);
            for (int i = 0; i < trucks.Capacity; ++i)
            {
                trucks.Add(new Truck(rand.RandomNameTruck(), rand.RandomModelCar(),
                    rand.RandomNumberCar(), rand.Next(1, 3), 
                    taxists[i + economCars.Capacity + luxuryCars.Capacity], rand.Next(10001)));
            }

            XmlSerializer xmlSerializerEconom = new XmlSerializer(typeof(List<EconomCar>));
            using (Stream stream = File.Create(@"..\..\XML\EconomCars.xml"))
            {
                xmlSerializerEconom.Serialize(stream, economCars);
            }

            XmlSerializer xmlSerializerLuxury = new XmlSerializer(typeof(List<LuxuryCar>));
            using (Stream stream = File.Create(@"..\..\XML\LuxuryCars.xml"))
            {
                xmlSerializerLuxury.Serialize(stream, luxuryCars);
            }

            XmlSerializer xmlSerializerTruck = new XmlSerializer(typeof(List<Truck>));
            using (Stream stream = File.Create(@"..\..\XML\Trucks.xml"))
            {
                xmlSerializerTruck.Serialize(stream, trucks);
            }

        }
        public static void CreateBaseUsers()
        {
            Random rand = new Random();
            List<User> users = new List<User>(AmountUsers);
            for (int i = 0; i < AmountUsers; ++i)
            {
                users.Add(new User(rand.RandomName(),
                    rand.RandomSurname(), rand.RandomStreet()));
            }
            //Econom
            List<EconomCar> economCars = new List<EconomCar>(AmountCars);
            for (int i = 0; i < economCars.Capacity; ++i)
            {
                economCars.Add(new EconomCar(rand.Next(1, 5),
                    rand.NextBool(), rand.NextBool(), users[i]));
            }
            XmlSerializer xmlSerializerEconom = new XmlSerializer(typeof(List<EconomCar>));
            using (Stream stream = File.Create(@"..\..\XML\UserBase\UsersEconomCars.xml"))
            {
                xmlSerializerEconom.Serialize(stream, economCars);
            }
            //Luxury
            List<LuxuryCar> luxuryCars = new List<LuxuryCar>(AmountCars);
            for (int i = 0; i < luxuryCars.Capacity; ++i)
            {
                luxuryCars.Add
                    (new LuxuryCar(rand.Next(1, 3), rand.NextBool(),
                    rand.NextBool(), users[i + economCars.Capacity]));
            }
            XmlSerializer xmlSerializerLuxury = new XmlSerializer(typeof(List<LuxuryCar>));
            using (Stream stream = File.Create(@"..\..\XML\UserBase\UsersLuxuryCars.xml"))
            {
                xmlSerializerLuxury.Serialize(stream, luxuryCars);
            }
            //Truck
            List<Truck> trucks = new List<Truck>(AmountCars);
            for (int i = 0; i < luxuryCars.Capacity; ++i)
            {
                trucks.Add(new Truck(rand.Next(1, 3), rand.Next(10000),
                    users[i + economCars.Capacity + luxuryCars.Capacity]));
            }
            XmlSerializer xmlSerializerTruck = new XmlSerializer(typeof(List<Truck>));
            using (Stream stream = File.Create(@"..\..\XML\UserBase\UsersTrucks.xml"))
            {
                xmlSerializerTruck.Serialize(stream, trucks);
            }
        }
    }
}
