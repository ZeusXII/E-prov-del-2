using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErovDelZwei
{
    class Car
    {
        public int passengers;
        public int contrabandAmount;
        public bool alreadyChecked;

        Random generator = new Random();



        public bool Examine()
        {
            if(contrabandAmount > 0)
            {
                alreadyChecked = true;
                return true;
            }
            else
            {
                alreadyChecked = true;
                return false;
            }
        }


    }
}
