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
            Console.WriteLine("Hur många bilar ska skapas?");
            int amount;
            while (true) //Felhantering
            {
                try
                {
                     amount = int.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Enabrt tal över 0 är accepterade");
                }
            }
         
            List<int> cars = new List<int>(amount); //Skapar en lista med antalet bilar användaren vill kolla/skapa
            //kunde inte  lista ut hur jag kunde lägga in Cleancar metod konstruktorn som ett element så det tog stopp...





            Console.WriteLine("Du kan redan nu ge mig ett F");
            Console.ReadKey();
        }
    }
}
