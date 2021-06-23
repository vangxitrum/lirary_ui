using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryApp
{
    public partial class ReadersScreen : Form
    {
        public ReadersScreen()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddReader child = new AddReader();
            child.ShowDialog();
        }

        private void payBt_Click(object sender, EventArgs e)
        {
            PayDebtScreen child = new PayDebtScreen();
            child.ShowDialog();
        }
    }
}
