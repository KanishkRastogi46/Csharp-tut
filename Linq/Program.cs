using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    internal class Program
    {
        class Car
        {
            public int Cid { get; set; }
            public string ModelName { get; set; }
            public int ModelYear { get; set; }
            public string Company { get; set; }

            public Car(int cid, string company, string modelName, int modelYear)
            {
                this.Cid = cid;
                this.ModelName = modelName;
                this.ModelYear = modelYear;
                this.Company = company;
            }
            static void Main(string[] args)
            {
                List<Car> cars = new List<Car>();

                cars.Add(new Car(1, "Toyota", "Supra MK-IV", 2001));
                cars.Add(new Car(2, "BMW", "M5 CS", 2021));
                cars.Add(new Car(3, "Porsche", "911 turbo s", 2020));
                cars.Add(new Car(4, "Mercedes-Benz", "AMG GTR", 2020));
                cars.Add(new Car(5, "Audi", "R8 GT", 2015));

                // LINQ query basic syntax
                /*
                var modelYear2020 = from car in cars
                                    where car.ModelYear == 2020
                                    select car;
                
                foreach (Car car in modelYear2020 ) Console.WriteLine($"{car.ModelName} - {car.ModelYear}");
                */

                // LINQ query modern syntax
                // query for getting all cars of ModelYear 2020
                Console.WriteLine("query for getting all cars of ModelYear 2020");
                var modelYear2020 = cars.Where(car => car.ModelYear == 2020);
                foreach (Car car in modelYear2020) Console.WriteLine($"{car.ModelName} - {car.ModelYear}");

                Console.WriteLine();

                // query for arranging cars in descending order by ModelYear
                Console.WriteLine("query for arranging cars in descending order by ModelYear");
                var descOrder = cars.OrderBy((car) => -car.ModelYear);
                foreach (Car car in descOrder) Console.WriteLine($"{car.ModelName} - {car.ModelYear}");

            }
        }
    }
}
