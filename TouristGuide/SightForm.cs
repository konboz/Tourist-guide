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
    public partial class SightForm : Form
    {
        public Form form;
        Utilities utility = new Utilities();
        public SightForm(Form form, Location location)
        {
            InitializeComponent();
            Text = Path.GetFileNameWithoutExtension(location.info);
            label1.Text = Path.GetFileNameWithoutExtension(location.info);
            pictureBox1.ImageLocation = location.photo;
            richTextBox1.Text = richTextBox1.Text = File.ReadAllText(location.info);
            this.form = form;
        }

        private void ΠίσωToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form.Show();
            Hide();
        }

        private void ΈξοδοςToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SightForm_Load(object sender, EventArgs e)
        {
            Utilities.HistoryAdd(this);
            GlobalVariables.currentForm = this;
        }

        private void μενούToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ιστορικόToolStripMenuItem.DropDownItems.Clear();
            utility.LoadHistoryMenu(ιστορικόToolStripMenuItem);
        }

        private void καθαρισμόςΙστορικούToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utilities.ClearHistory();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string exportLocation;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                exportLocation = saveFileDialog1.FileName;
                File.WriteAllText(exportLocation, richTextBox1.Text);
            }
        }
    }
}
