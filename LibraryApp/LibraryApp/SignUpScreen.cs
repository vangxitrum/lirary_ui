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
    public partial class SignUpScreen : Form
    {
        Form parent;
        public SignUpScreen()
        {
            InitializeComponent();
        }

        public SignUpScreen(Form parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.parent.Show();
            this.Close();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
