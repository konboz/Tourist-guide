using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace TouristGuide
{
    public class Utilities
    {
        public void LoadHistoryMenu(ToolStripMenuItem history)
        { 
            foreach (Form form in GlobalVariables.history.VisitedForms)
            {
                ToolStripMenuItem item = new ToolStripMenuItem();
                item.Text = form.Text;
                history.DropDownItems.Add(item);
                item.Click += new EventHandler(ClickItem);
            }
        }

        private static void ClickItem(object sender, EventArgs e)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;
            Form clickedForm = null;
            try
            {
                foreach (Form form in GlobalVariables.history.VisitedForms)
                {
                    if (item.Text == form.Text)
                    {
                        clickedForm = form;
                        break;
                    }
                }
                GlobalVariables.currentForm.Hide();
                GlobalVariables.currentForm = clickedForm;
                clickedForm.Show();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message); ;
            }
        }

        public static void ClearHistory()
        {
            if (GlobalVariables.history != null)
            {
                GlobalVariables.history.VisitedForms.Clear();
            }
        }

        public static void HistoryAdd(Form form)
        {
            int dupCounter = 0;

            foreach (Form element in GlobalVariables.history.VisitedForms) //checks if a form with the same name is in the list
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
