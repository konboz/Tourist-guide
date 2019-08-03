using System;
using System.Collections.Generic;
using System.Text;

namespace TouristGuide_Core
{
    class Village
    {
        public int VillageId { get; set; }
        public string Name { get; private set; }
        public string Photos { get; set; }
        public string Directions { get; private set; }
        public List<Food> Restaurants { get; private set; }
        public List<Hotel> Hotels { get; private set; }
        public List<Beach> Beaches { get; private set; }
        public List<Sight> Sights { get; private set; }
        public List<Bar> Bars { get; private set; }
    }
}
