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
            passengers = generator.Next(1, 4); //Skapa 1-3 passagerare
            contrabandAmount = 0; // Antalet stöldsgods som skapas i bilen

        }
    }
}
