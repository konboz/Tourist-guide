using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace TouristGuide
{
    public static class Utilities
    {
        public static void LoadHistoryMenu(ToolStripMenuItem history)
        {
            //int id = 0;
     
            foreach (Form form in GlobalVariables.history.VisitedForms)
            {
                ToolStripMenuItem item = new ToolStripMenuItem(form.Text);
                //item.Tag = id;
                //id++;
                if (!history.DropDownItems.Contains(item)) //Gia na min yparxoun diploeggrafes sto menu tou istorikou
                {
                    history.DropDownItems.Add(item);
                }
            }
        }

        public static void ClearHistory(ToolStripMenuItem history)
        {
            if (GlobalVariables.history != null)
            {
                GlobalVariables.history.VisitedForms.Clear();
            }
            history.DropDownItems.Clear();
        }

        public static void HistoryAdd(Form form)
        {
            int dupCounter = 0;
            /* if (GlobalVariables.history != null)*/ // Gia tin apofygi exception se periptvsi pou to istoriko einai adeio kai gia apofygi diploeggrafwn sti lista
            foreach (Form element in GlobalVariables.history.VisitedForms)
            {
                if (element.Text == form.Text)
                {
                    dupCounter = 1;
                    break;
                }
            }
            if (dupCounter == 0)
            {
                GlobalVariables.history.VisitedForms.Add(form);
            }
        }
    }
}
