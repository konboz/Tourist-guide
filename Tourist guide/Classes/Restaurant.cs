using System;
using System.Collections.Generic;
using System.Text;

namespace TouristGuide
{
    public class Restaurant
    {
        public int RestaurantId { get; set; }
        public string RestaurantName { get; set; }
        public string Photo { get; set; }
        public string Location { get; set; }
        public int VillageId { get; set; }
    }
}
