using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_2
{
    public class Vehicle
    {
        protected double[] _coordinates = new double[2];
        protected int _price;
        protected int _speed;
        protected int _year;

        public Vehicle(double[] coords, int price, int speed, int year)
        {
            _coordinates = coords;
            _price = price;
            _speed = speed;
            _year = year;
        }

        public virtual void print_all()
        {
            Console.WriteLine($"Coordinates: {_coordinates[0]}; " +
                $"{_coordinates[1]}");
            Console.WriteLine($"Price: {_price}");
            Console.WriteLine($"Speed: {_speed}");
            Console.WriteLine($"Year: {_year}");
        }
    }
}
