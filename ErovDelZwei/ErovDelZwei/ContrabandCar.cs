using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErovDelZwei
{
    class ContrabandCar : Car
    {
        Random shadyGenerator = new Random();

        public ContrabandCar()
        {
            passengers = shadyGenerator.Next(1, 5); // Slumapr fram 1 till 4 individer/passagerare
            contrabandAmount = shadyGenerator.Next(1, 5); //Slumapr fram 1 till 4 stöldsgods 

        }
    }
}
