using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTest
{
    internal class Car
    {
        public Car(string make, string model)
        {
            Model = model;
            Make = make;
        }

        public string Model { get; set; }
        public string Make { get; set; }
    }
}
