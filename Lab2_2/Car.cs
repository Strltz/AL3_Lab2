using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_2
{
    public class Car : Vehicle
    {
        public Car(double[] coords, int price, int speed, int year) :
            base(coords, price, speed, year) { }
    }
}
