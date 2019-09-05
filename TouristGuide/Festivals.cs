using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TouristGuide
{
    public partial class Festivals: Form
    {
        public Form form;
        Utilities utility = new Utilities();
        public Festivals()
        {
            InitializeComponent();
        }

        private void μενούtoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ιστορικόtoolStripMenuItem2.DropDownItems.Clear();
            utility.LoadHistoryMenu(ιστορικόtoolStripMenuItem2);
        }

        private void ιστορικόtoolStripMenuItem2_Click(object sender, EventArgs e)
        {
            
        }

        private void καθαρισμόςΙστορικούtoolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Utilities.ClearHistory();
        }

        private void έξοδοςtoolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void Festivals_Load(object sender, EventArgs e)
        {
            Utilities.HistoryAdd(this);
            GlobalVariables.currentForm = this;
        }
    }
}
