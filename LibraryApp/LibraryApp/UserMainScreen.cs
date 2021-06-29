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
    public partial class UserMainScreen : Form
    {
        Form child;
        LoginScreen _parent;
        string _rID;
        public UserMainScreen(LoginScreen parent,string rID)
        {
            InitializeComponent();
            this._parent = parent;
            this._rID = rID;
            child = new UserIssuedBookScreen(_rID);
            child.Dock = DockStyle.Fill;
            child.TopLevel = false;
            this.mainPanel.Controls.Add(child);
            child.BringToFront();
            child.Show();
        }

        private void logOutBt_Click(object sender, EventArgs e)
        {
            this.Close();
            this._parent.Show();
        }

        private void booksBt_Click(object sender, EventArgs e)
        {
            child = new UserIssuedBookScreen(_rID);
            child.Dock = DockStyle.Fill;
            child.TopLevel = false;
            this.mainPanel.Controls.Add(child);
            child.BringToFront();
            child.Show();
        }

        private void readersBt_Click(object sender, EventArgs e)
        {
            child = new UserInfoScreen(_rID);
            child.Dock = DockStyle.Fill;
            child.TopLevel = false;
            this.mainPanel.Controls.Add(child);
            child.BringToFront();
            child.Show();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
