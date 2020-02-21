using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BookForRide.Entity
{
    public class Bike
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public Nullable<int> Speed { get; set; }
        public string ModelNo { get; set; }
        public Nullable<int> Mileage { get; set; }
        public string Photo { get; set; }

        public override string ToString()
        {
            return $"Classname=Bike, Id={Id}, Name={Name}";
        }

       

    }

    
}
