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
    public partial class AddReader : Form
    {
        
        List<Item> items = new List<Item>();
        class Item
        {
            public int id { get; set; }
            public string value { get; set; }
            public Item(int id,string value)
            {
                this.id = id;
                this.value = value;
            }
        }

        public AddReader()
        {
            InitializeComponent();
            loadData();
            birthDayTaker.Format = DateTimePickerFormat.Custom;
            readerTypeSet.DataSource = items;
            readerTypeSet.DisplayMember = "value";
            readerTypeSet.ValueMember = "id";

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void loadData()
        {
            SqlConnection conn = DBUtils.GetDBConnection();
            try
            {
                conn.Open();
                string selectQuerry = "Select * from LoaiDocGia";
                SqlCommand Cmd = new SqlCommand(selectQuerry, conn);
                using (SqlDataReader oReader = Cmd.ExecuteReader())
                {
                    if (oReader.HasRows)
                    {
                        while (oReader.Read())
                        {
                            items.Add(new Item(Int32.Parse(oReader["MaLoaiDocGIa"].ToString()), oReader["TenLoaiDocGia"].ToString()));
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
        }

        private void saveBt_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;
            DateTime birthDay = birthDayTaker.Value.Date;
            int readerAge = (int)today.Subtract(birthDay).TotalDays / 356;
            MessageBox.Show(readerAge.ToString());
            if (readerAge < AppValue._minAge)
            {
                MessageBox.Show("Reader is not old enough!!!");
                return;
            }
            else if (readerAge > AppValue._maxAge)
            {
                MessageBox.Show("Reader is too old!!!");
                return;
            }
            String temp = DateTime.Today.ToString("d");
            temp = temp.Replace('/', '-');
            
            List<int> todayData = splitData(temp);
            temp = todayData[0].ToString()+ '-' + todayData[1].ToString()+ '-' + todayData[2].ToString();
            if (!(String.IsNullOrEmpty(nameTaker.Text) || String.IsNullOrEmpty(addressTaker.Text) || String.IsNullOrEmpty(emailTaker.Text)))
            {

                SqlConnection conn1 = DBUtils.GetDBConnection();
                conn1.Open();
                try
                {
                    string selectQuerry = "INSERT INTO DocGia (MaDocGia,HoTen,MaLoaiDocGia,NgaySinh,DiaChi,Email,NgayLapThe,TongNo) VALUES([dbo].[idDocGia](),@name,@readerType,@birthDate,@address,@email,@signInDate,0)";
                    SqlCommand Cmd = new SqlCommand(selectQuerry, conn1);
                    Cmd.Parameters.AddWithValue("@name", nameTaker.Text);
                    Cmd.Parameters.AddWithValue("@readerType", readerTypeSet.SelectedValue.ToString());
                    Cmd.Parameters.AddWithValue("@birthDate", birthDayTaker.Text);
                    Cmd.Parameters.AddWithValue("@email", emailTaker.Text);
                    Cmd.Parameters.AddWithValue("@signInDate",temp);
                    Cmd.Parameters.AddWithValue("@address", addressTaker.Text);
                    Cmd.ExecuteNonQuery();

                }
                catch (Exception s)
                {
                    conn1.Close();
                    MessageBox.Show("Failed to connect to database!!! Please try again later");
                    return;
                }
                conn1.Close();
                this.Close();
            }
            else
            {
                MessageBox.Show("Fill Infomation !!!");
            }
        }

        private List<int> splitData(string date)
        {
            List<int> rs = new List<int>();
            int pos = date.IndexOf('-', 0), start = 0;
            while (pos != -1)
            {
                string temp = date.Substring(start, pos - start);
                rs.Add(Int32.Parse(temp));
                start = pos + 1;
                pos = date.IndexOf('-', start);
            }
            string temp1 = date.Substring(start, date.Length - start);
            rs.Add(Int32.Parse(temp1));
            return rs;
        }
    }
}
