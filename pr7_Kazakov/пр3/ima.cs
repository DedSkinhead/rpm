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
    public partial class ima : Form
    {
        public ima()
        {
            InitializeComponent();
        }

        private void Yes_Click(object sender, EventArgs e)
        {
            Hide();
            ykaz1 ykaz = new ykaz1();
            DialogResult result = ykaz.ShowDialog();
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

        private void No_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
