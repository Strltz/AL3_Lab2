using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_2
{
    public class Plane : Vehicle
    {
        int _height;
        int _number_of_passangers;
        public Plane(double[] coords, int price, int speed, int year,
            int height, int number_pass) : base(coords, price, speed, year)
        {
            _height = height;
            _number_of_passangers = number_pass;
        }

        public override void print_all()
        {
            base.print_all();
            Console.WriteLine($"Height: {_height}");
            Console.WriteLine($"Passenger capacity: {_number_of_passangers}");
        }
    }
}
