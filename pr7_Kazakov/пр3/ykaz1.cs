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
    public partial class ykaz1 : Form
    {
        public ykaz1()
        {
            InitializeComponent();
        }

        private void ok_Click(object sender, EventArgs e)
        {
            glavnoe ppppp = new glavnoe();
            ppppp.imae.Text = yka.Text;
            ppppp.Show();
            Hide();

 
        }


        private void otmena_Click(object sender, EventArgs e)
        {
            Hide();
            glavnoe gh4 = new glavnoe();
            DialogResult result = gh4.ShowDialog();
            switch (result)
            {
                case DialogResult.OK:

                    {
                        Close();
                        break;
                    }
                case DialogResult.Cancel:
                    {
                        return;
                    }


            }
        }
    }
}
