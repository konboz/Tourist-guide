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
        public SightForm(Form form, Sight sight)
        {
            InitializeComponent();
            Text = Path.GetFileNameWithoutExtension(sight.info);
            label1.Text = Path.GetFileNameWithoutExtension(sight.info);
            pictureBox1.ImageLocation = sight.photo;
            richTextBox1.Text = richTextBox1.Text = File.ReadAllText(sight.info);
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

        private void ΑποθήκευσηΠληροφοριώνToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string exportLocation;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                exportLocation = saveFileDialog1.FileName;
                File.WriteAllText(exportLocation, richTextBox1.Text);
            }
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

        private void καθαρισμόςToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Utilities.ClearHistory();
        }
    }
}
