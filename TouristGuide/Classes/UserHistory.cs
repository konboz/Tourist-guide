using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace TouristGuide
{
    public class UserHistory
    {
        public List<Form> VisitedForms { get; set; }

        public UserHistory()
        {
            VisitedForms = new List<Form>();
        }
    }
}
