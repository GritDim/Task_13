using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Building building = new Building(10, 10, 10, 10);
            MultiBuilding multiBuilding = new MultiBuilding(20, 20, 20, 20, 5);
            Console.WriteLine(building.GetInfo());
            Console.WriteLine(multiBuilding.GetInfo());
            Console.ReadKey();
        }
    }
}
