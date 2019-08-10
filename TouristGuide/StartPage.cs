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
        Utilities utility = new Utilities();
        public StartPage()
        {
            InitializeComponent();
            pictureBox7.ImageLocation = "Photos/trail.jpg";
            pictureBox1.ImageLocation = "Photos/sight1.png";
            Text = "ΑΡΧΙΚΗ ΣΕΛΙΔΑ";
        }

        private void StartPage_Load(object sender, EventArgs e)
        {
            Utilities.HistoryAdd(this);
            GlobalVariables.currentForm = this;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form3 villages = new Form3(this, "ΑΞΙΟΘΕΑΤΑ");
            villages.Show();
            Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form3 villages = new Form3(this, "ΑΞΙΟΘΕΑΤΑ");
            villages.Show();
            Hide();
        }

        private void έξοδοςToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void καθαρισμόςToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utilities.ClearHistory();
        }

        private void μενούToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ιστορικόToolStripMenuItem.DropDownItems.Clear();
            utility.LoadHistoryMenu(ιστορικόToolStripMenuItem);
        }
    }
}
