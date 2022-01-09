using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabindingListToClass
{
    public class Cars
    {
        public static List<Car> GetCars()
        {
            return new List<Car>()
            {
                new Car(){Owner = "Jhon", BrandType = BrandType.MercedesBenz,  Type = CarType.Hatchback},
                new Car(){Owner = "Emma", BrandType = BrandType.BMW, Type = CarType.Sedan},
                new Car(){Owner = "Lil Z", BrandType = BrandType.AlfaRomeo, Type = CarType.SUV}
            }.ToList();
        }
    }
}
