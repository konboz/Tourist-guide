using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TouristGuide
{
    public static class Utilities
    {
        public static void LoadHistoryMenu(ToolStripMenuItem history)
        {
            int id = 0;

            foreach (Form form in GlobalVariables.history.VisitedForms)
            {
                ToolStripMenuItem item = new ToolStripMenuItem(form.Text);
                item.Tag = id;
                id++;

                history.DropDownItems.Add(item);
            }
        }

        public static void HistoryAdd(Form form)
        {
            if (GlobalVariables.history != null && !GlobalVariables.history.VisitedForms.Contains(form))
            {
                GlobalVariables.history.VisitedForms.Add(form);
            }
        }
    }
}
