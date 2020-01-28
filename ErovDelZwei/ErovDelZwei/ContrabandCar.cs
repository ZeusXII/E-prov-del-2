using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErovDelZwei
{
    class ContrabandCar
    {
        Random shadyGenerator = new Random();

        public ContrabandCar()
        {
            Car shadyCar = new Car(); //Skapar en ond bild med passagerare och stöldgods
            shadyCar.passengers = shadyGenerator.Next(1, 4); // Slumapr fram 1 till 4 individer/passagerare
            shadyCar.contrabandAmount = shadyGenerator.Next(1, 4); //Slumapr fram 1 till 4 stöldsgods 

        }
    }
}
