using System;
using System.Collections.Generic;
using System.Text;

namespace TouristGuide_Core
{
    public class Sight
    {
        public int SightId { get; set; }
        public string Name { get; private set; }
        public string Photos { get; set; }
        public string Directions { get; private set; }
        public int VillageId { get; set; }
    }
}
