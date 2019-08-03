using System;
using System.Collections.Generic;
using System.Text;

namespace TouristGuide_Core
{
    public class Food
    {
        public int FoodId { get; set; }
        public string Name { get; set; }
        public string Photo { get; set; }
        public string Location { get; set; }
        public int VillageId { get; set; }
    }
}
