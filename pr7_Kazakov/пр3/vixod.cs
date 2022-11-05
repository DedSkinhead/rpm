using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace пр3
{
    public partial class vixod : Form
    {
        public vixod()
        {
            InitializeComponent();
        }

        private void zaverhenie_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void otmena_Click(object sender, EventArgs e)
        {
            Hide();
            this.Close();
        }
    }
}
