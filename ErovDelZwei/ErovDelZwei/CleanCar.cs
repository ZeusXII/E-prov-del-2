using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErovDelZwei
{
    class CleanCar : Car
    {
        Random generator = new Random();

        public CleanCar() //Konstruktor av CleanCar
        {
            Car goodCar = new Car(); //Skapar en ny ren bild utan stöldgods
            goodCar.passengers = generator.Next(1, 3); //Skapa 1-3 passagerare
            goodCar.contrabandAmount = 0; // Antalet stöldsgods som skapas i bilen

        }
    }
}
