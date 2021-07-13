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
   
    public partial class SettingScreen : Form
    {
        List<string> _data = new List<string>();
        public SettingScreen()
        {
            InitializeComponent();
            LoadData();
        }

       void LoadData()
        {
            minAgeTaker.Text = AppValue._minAge.ToString();
            maxAgeTaker.Text = AppValue._maxAge.ToString();
            cardDurationTaker.Text = AppValue._cardDuration.ToString();
            maxIssuedDay.Text = AppValue._maxIssuedDay.ToString();
            dailyFeeTaker.Text = AppValue._dailyFee.ToString();
            overdueFeeTaker.Text = AppValue._overDueFee.ToString();
            _data.Add(AppValue._minAge.ToString());
            _data.Add(AppValue._maxAge.ToString());
            _data.Add(AppValue._cardDuration.ToString());
            _data.Add(AppValue._maxIssuedDay.ToString());
            _data.Add(AppValue._dailyFee.ToString());
            _data.Add(AppValue._overDueFee.ToString());
        }

        private void KeyPressMask(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }

        private void saveBt_Click(object sender, EventArgs e)
        {
            bool flat = true;
            List<string> newData = new List<string>();
            List<string> columnName = new List<string>();
            columnName.Add("TuoiToiThieu");
            columnName.Add("TuoiToiDa");
            columnName.Add("ThoiHanThe");
            columnName.Add("SoNgayMuonToiDa");
            columnName.Add("PhiMuonNgay");
            columnName.Add("PhiPhatNgay ");
            newData.Add(minAgeTaker.Text);
            newData.Add(maxAgeTaker.Text);
            newData.Add(cardDurationTaker.Text);
            newData.Add(maxIssuedDay.Text);
            newData.Add(dailyFeeTaker.Text);
            newData.Add(overdueFeeTaker.Text);
            AppValue._minAge = Int32.Parse(minAgeTaker.Text);
            AppValue._maxAge = Int32.Parse(maxAgeTaker.Text);
            AppValue._cardDuration = Int32.Parse(cardDurationTaker.Text);
            AppValue._maxIssuedDay = Int32.Parse(maxIssuedDay.Text);
            AppValue._dailyFee = Int32.Parse(dailyFeeTaker.Text);
            AppValue._overDueFee = Int32.Parse(overdueFeeTaker.Text);
            for (int i = 0; i < newData.Count; i++)
            {
                if (newData[i] != _data[i])
                {
                    SqlConnection conn = DBUtils.GetDBConnection();
                    try
                    {
                        conn.Open();
                        string selectQuerry = "UPDATE AppValue SET value = @value where name = @name";
                        SqlCommand Cmd = new SqlCommand(selectQuerry, conn);
                        Cmd.Parameters.AddWithValue("@name",columnName[i]);
                        Cmd.Parameters.AddWithValue("@value", Int32.Parse(newData[i]));
                        Cmd.ExecuteNonQuery();
                    }
                    catch (Exception s)
                    {
                        flat = false;
                        MessageBox.Show("Failed to connect to database!!! Please try again later");
                    }
                    conn.Close();
                }
            }
            if (flat)
            {
                MessageBox.Show("Success!!!");
            }
            else
            {
                MessageBox.Show("Failed!!!");
            }
        }
    }
}
 