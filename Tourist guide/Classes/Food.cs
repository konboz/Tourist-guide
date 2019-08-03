using System;
using System.Collections.Generic;
using System.Text;

namespace TouristGuide
{
    public class Food
    {
        public int FoodId { get; set; }
        public string FoodName { get; set; }
        public string Photo { get; set; }
        public string Location { get; set; }
        public int VillageId { get; set; }
    }
}
