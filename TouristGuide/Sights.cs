using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace TouristGuide
{
    public partial class Sights : Form
    {
        string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=TouristGuideDb.mdb";
        OleDbConnection connection;
        public Sights(string villageName, string user)
        {
            InitializeComponent();
            label1.Text = villageName;
            var labels = new List<Label> { label2, label3, label4, label5, label6, label7 };
            connection.Open();
            string query = "SELECT SightName FROM Sight WHERE VillageName LIKE(\"" + villageName + "\")";
            OleDbCommand command = new OleDbCommand(query, connection);
            OleDbDataReader reader = command.ExecuteReader();

            for (int i = 0; i < 3; i++)
            {
                labels[i].Visible = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Sight sight = new Sight(label1.Text);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Sight sight = new Sight(label1.Text);
            sight.Show();
            this.Hide();
        }

        private void Sights_Load(object sender, EventArgs e)
        {
           
        }
    }
}
