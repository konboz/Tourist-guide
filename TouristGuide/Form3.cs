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
    public partial class Form3 : Form
    {
        public int counter = 0;
        public string contentType;
        public string user;
        string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=TouristGuideDb.mdb";
        OleDbConnection connection;
        public Form3(string contentType, string user)
        {
            InitializeComponent();
            this.contentType = contentType;
            this.user = user;
            label5.Text = contentType;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            connection = new OleDbConnection(connectionString);
            connection.Open();
            string query = "SELECT SightName FROM Sight WHERE VillageName LIKE(\"" + label3.Text + "\")";
            OleDbCommand command = new OleDbCommand(query, connection);
            OleDbDataReader reader = command.ExecuteReader();
            counter = reader.VisibleFieldCount;
            connection.Close();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            if (contentType == "Αξιοθέατα")
            {
                Sights sights = new Sights(label1.Text, counter, user);
                sights.Show();
                this.Hide();
            }
             
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            if (contentType == "Αξιοθέατα")
            {
                Sights sights = new Sights(label1.Text, counter, user);
                sights.Show();
                this.Hide();
            }
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            if (contentType == "Αξιοθέατα")
            {
                Sights sights = new Sights(label2.Text, counter, user);
                sights.Show();
                this.Hide();
            }
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            if (contentType == "Αξιοθέατα")
            {
                Sights sights = new Sights(label2.Text, counter, user);
                sights.Show();
                this.Hide();
            }
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            Sights sights = new Sights(label3.Text, counter, user);
            sights.Show();
            this.Hide();
        }

        private void Label3_Click(object sender, EventArgs e)
        {
            Sights sights = new Sights(label3.Text, counter, user);
            sights.Show();
            this.Hide();
        }
    }
}
