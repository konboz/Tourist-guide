using System;
using System.Collections.Generic;
using System.Text;

namespace TouristGuide_Core
{
    class Village
    {
        public int VillageId { get; set; }
        public string Name { get; set; }
        public string Photo { get; set; }
        public string Location { get; set; }
        public List<Food> Restaurants { get; set; }
        public List<Hotel> Hotels { get; set; }
        public List<Beach> Beaches { get; set; }
        public List<Sight> Sights { get; set; }
        public List<Bar> Bars { get; set; }
    }
}
