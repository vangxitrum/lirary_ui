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
    public partial class MainScreen : Form
    {
        Form child;
        LoginScreen _parent;
        public MainScreen(LoginScreen parent)
        {
            InitializeComponent();
            this._parent = parent;
        }


        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void dashBoardBt_Click(object sender, EventArgs e)
        {
            child = new DashbroadScreen();
            child.Dock = DockStyle.Fill;
            child.TopLevel = false;
            this.mainPanel.Controls.Add(child);
            child.BringToFront();
            child.Show();
        }

        private void booksBt_Click(object sender, EventArgs e)
        {
            child = new BookScreen();
            child.Dock = DockStyle.Fill;
            child.TopLevel = false;
            this.mainPanel.Controls.Add(child);
            child.BringToFront();
            child.Show();
        }

        private void readersBt_Click(object sender, EventArgs e)
        {
            child = new ReadersScreen();
            child.Dock = DockStyle.Fill;
            child.TopLevel = false;
            this.mainPanel.Controls.Add(child);
            child.BringToFront();
            child.Show();
        }

        private void issuedBookBt_Click(object sender, EventArgs e)
        {
            child = new IssuedBooks();
            child.Dock = DockStyle.Fill;
            child.TopLevel = false;
            this.mainPanel.Controls.Add(child);
            child.BringToFront();
            child.Show();
        }

        private void returnBookBt_Click(object sender, EventArgs e)
        {
            child = new ReturnBookScreen();
            child.Dock = DockStyle.Fill;
            child.TopLevel = false;
            this.mainPanel.Controls.Add(child);
            child.BringToFront();
            child.Show();
        }

        private void logOutBt_Click(object sender, EventArgs e)
        {
            this._parent.Show();
            this.Close();
        }

        
    }
}
