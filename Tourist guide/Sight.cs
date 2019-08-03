using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tourist_guide
{
    public partial class Sight : Form
    {
        public Sight()
        {
            InitializeComponent();
        }

        public Sight(string name)
        {
            InitializeComponent();
            this.Text = name;
        }

        private void Sight_Load(object sender, EventArgs e)
        {
            
        }
    }
}
