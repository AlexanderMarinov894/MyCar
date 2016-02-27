using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCar.Models
{
    class Vehicle
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Engine { get; set; }
        public string Power { get; set; }
        public int Year { get; set; }
        public double EngineVolume { get; set; }
        public Enum FuelType { get; set; }
        public double FuelConsumption { get; set; }
    }
}
