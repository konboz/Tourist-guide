using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TouristGuide
{
    public partial class StartPage : Form
    {
        public StartPage()
        {
            InitializeComponent();
            pictureBox7.ImageLocation = "Photos/trail.jpg";
            pictureBox1.ImageLocation = "Photos/sight1.png";
        }

        private void StartPage_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            Form3 villages = new Form3(this, "ΑΞΙΟΘΕΑΤΑ");

            if (GlobalVariables.history != null)
            {
                GlobalVariables.history.VisitedForms.Add(villages);
            }
            Utilities.HistoryAdd(villages);
            villages.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form3 villages = new Form3(this, "ΑΞΙΟΘΕΑΤΑ");
            Utilities.HistoryAdd(villages);
            villages.Show();
            this.Hide();
        }

        private void TreeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void ΈξοδοςToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
