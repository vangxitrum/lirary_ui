using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryApp
{
    public partial class MainScreen : Form
    {
        Form _child;
        LoginScreen _parent;
        public MainScreen(LoginScreen parent)
        {
            InitializeComponent();
            this._parent = parent;
            _child = new DashbroadScreen();
            _child.Dock = DockStyle.Fill;
            _child.TopLevel = false;
            this.mainPanel.Controls.Add(_child);
            _child.BringToFront();
            _child.Show();
            LoadData();
        }

        void LoadData()
        {
            List<string> data = new List<String>();
            SqlConnection conn = DBUtils.GetDBConnection();
            try
            {
                conn.Open();
                string selectQuerry = "Select * from AppValue";
                SqlCommand Cmd = new SqlCommand(selectQuerry, conn);
                using (SqlDataReader oReader = Cmd.ExecuteReader())
                {
                    if (oReader.HasRows)
                    {
                        while (oReader.Read())
                        {
                            data.Add(oReader["value"].ToString());
                        }
                    }
                    else
                    {
                        MessageBox.Show("No infomation !!!");
                    }
                }
            }
            catch (Exception s)
            {
                MessageBox.Show("Failed to connect to database!!! Please try again later");
            }
            conn.Close();
            AppValue._minAge = Int32.Parse(data[0]);
            AppValue._maxAge = Int32.Parse(data[1]);
            AppValue._cardDuration = Int32.Parse(data[2]);
            AppValue._maxIssuedDay = Int32.Parse(data[3]);
            AppValue._dailyFee = Int32.Parse(data[4]);
            AppValue._overDueFee = Int32.Parse(data[5]);
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void dashBoardBt_Click(object sender, EventArgs e)
        {
            _child = new DashbroadScreen();
            _child.Dock = DockStyle.Fill;
            _child.TopLevel = false;
            this.mainPanel.Controls.Add(_child);
            _child.BringToFront();
            _child.Show();
        }

        private void booksBt_Click(object sender, EventArgs e)
        {
            _child = new BookScreen();
            _child.Dock = DockStyle.Fill;
            _child.TopLevel = false;
            this.mainPanel.Controls.Add(_child);
            _child.BringToFront();
            _child.Show();
        }

        private void readersBt_Click(object sender, EventArgs e)
        {
            _child = new ReadersScreen();
            _child.Dock = DockStyle.Fill;
            _child.TopLevel = false;
            this.mainPanel.Controls.Add(_child);
            _child.BringToFront();
            _child.Show();
        }

        private void issuedBookBt_Click(object sender, EventArgs e)
        {
            _child = new IssuedBooks();
            _child.Dock = DockStyle.Fill;
            _child.TopLevel = false;
            this.mainPanel.Controls.Add(_child);
            _child.BringToFront();
            _child.Show();
        }

        private void returnBookBt_Click(object sender, EventArgs e)
        {
            _child = new ReturnBookScreen();
            _child.Dock = DockStyle.Fill;
            _child.TopLevel = false;
            this.mainPanel.Controls.Add(_child);
            _child.BringToFront();
            _child.Show();
        }

        private void logOutBt_Click(object sender, EventArgs e)
        {
            this._parent.Show();
            this.Close();
        }

        private void settingsBt_Click(object sender, EventArgs e)
        {
            _child = new SettingScreen();
            _child.Dock = DockStyle.Fill;
            _child.TopLevel = false;
            this.mainPanel.Controls.Add(_child);
            _child.BringToFront();
            _child.Show();
        }
    }
}
