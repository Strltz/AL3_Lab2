using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_2
{
    public class Ship : Vehicle
    {
        int _number_of_passangers;
        int _port_number;
        public Ship(double[] coords, int price, int speed, int year,
            int number_pass, int port_num) : base(coords, price, speed, year)
        {
            _port_number = port_num;
            _number_of_passangers = number_pass;
        }

        public override void print_all()
        {
            base.print_all();
            Console.WriteLine($"Passenger capacity: {_number_of_passangers}");
            Console.WriteLine($"The number of seaport: {_port_number}");
        }
    }
}
