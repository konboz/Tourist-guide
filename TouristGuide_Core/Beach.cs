using System;
using System.Collections.Generic;
using System.Text;

namespace TouristGuide_Core
{
    public class Beach
    {
        public int BeachId { get; set; }
        public string Name { get; private set; }
        public string Photos { get; set; }
        public string Directions { get; private set; }
        public int VillageId { get; set; }
    }
}
