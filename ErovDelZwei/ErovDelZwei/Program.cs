using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErovDelZwei
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hur många bilar ska skapas?: ");
            int amount;
            while (true) //Felhantering
            {
                try
                {
                     amount = int.Parse(Console.ReadLine());
                    if(amount <= 0)
                    {
                        throw new SystemException("Ooga booga"); //"Try catchar" om användaren skriver in talet 0 
                    }
                    break;
                }
                catch
                {
                    Console.WriteLine("Enabrt tal över 0 är accepterade");
                }
            }
            Console.Clear();
            
            List<Car> cars = new List<Car>(amount); //Skapar en lista med antalet bilar användaren vill kolla/skapa

            /*Car goodCar = new CleanCar(); //Skapar en ny ren bild utan stöldgods
            Car shadyCar = new ContrabandCar(); //Skapar en ond bild med passagerare och stöldgods
            */

            for (int i = 0; i < amount; i++) //Gör så att det skapas amount många bilar 
            {
                cars.Add(RandomCarType()); //Lägger till en ny bil i stora listan 

            }

            int carNr = 0; //Håller koll på bilnummret
            foreach (var car in cars)
            {
                if (car.Examine())
                {
                    Console.WriteLine("OBS! Stöldgods!");
                }
                else
                {
                    Console.WriteLine("Inget stöldgods");
                }
               
                carNr++;
                Console.WriteLine("Bil nr: " + carNr);
                Console.WriteLine("Passengers: " + car.passengers); //car byter värde efter vare loop, liknar en for(i < =: ...; +1) 
                Console.WriteLine("Contraband: " + car.contrabandAmount);
                Console.WriteLine("---------------------------------------------------------");

            }
            //Console.WriteLine("Passengers: " + cars[0].passengers); // [0] är första elementet (goodCar)

            Console.ReadKey();
        }

        static Random generator = new Random();

        static Car RandomCarType()
        {
            List<Car> differentCars = new List<Car>() { new CleanCar(), new ContrabandCar() }; //Skapar en lista med nya bilobjekt av olika typ

            int carTypeIndex = generator.Next(0, 2); // Genererar ett index föratt hämta en random bilobjekt  

            return differentCars[carTypeIndex]; //retunerar objektet på carTypeIndex

        }
    }
}
