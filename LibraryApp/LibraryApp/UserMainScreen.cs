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
        Form _child;
        LoginScreen _parent;
        string _rID;
        public UserMainScreen(LoginScreen parent,string rID)
        {
            InitializeComponent();
            this._parent = parent;
            this._rID = rID;
            _child = new UserIssuedBookScreen(_rID);
            _child.Dock = DockStyle.Fill;
            _child.TopLevel = false;
            this.mainPanel.Controls.Add(_child);
            _child.BringToFront();
            _child.Show();
        }

        private void logOutBt_Click(object sender, EventArgs e)
        {
            this.Close();
            this._parent.Show();
        }

        private void booksBt_Click(object sender, EventArgs e)
        {
            _child = new UserIssuedBookScreen(_rID);
            _child.Dock = DockStyle.Fill;
            _child.TopLevel = false;
            this.mainPanel.Controls.Add(_child);
            _child.BringToFront();
            _child.Show();
        }

        private void readersBt_Click(object sender, EventArgs e)
        {
            _child = new UserInfoScreen(_rID);
            _child.Dock = DockStyle.Fill;
            _child.TopLevel = false;
            this.mainPanel.Controls.Add(_child);
            _child.BringToFront();
            _child.Show();
        }

        private void exitBt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
