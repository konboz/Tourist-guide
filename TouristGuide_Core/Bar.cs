using System;
using System.Collections.Generic;
using System.Text;

namespace TouristGuide_Core
{
    public class Bar
    {
        public int BarId { get; set; }
        public string Name { get; private set; }
        public string Photo { get; set; }
        public string Directions { get; private set; }
        public int VillageId { get; set; }
    }
}
