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
    
    public partial class ModifyReader : Form
    {
        List<Item> items = new List<Item>();
        class Item
        {
            public int id { get; set; }
            public string value { get; set; }
            public Item(int id, string value)
            {
                this.id = id;
                this.value = value;
            }
        }
        string rName, rAddress, rBirth, rDebt, rEmail, rSignDate,rType,rID;

        private void ModifyReader_Load(object sender, EventArgs e)
        {

        }

        private void saveBt_Click(object sender, EventArgs e)
        {
            SqlConnection conn = DBUtils.GetDBConnection();
            try
            {
                conn.Open();
                string selectQuerry = "UPDATE DocGia SET HoTen = @rName, MaLoaiDocGia = @tID,NgaySinh = @birth,DiaChi = @address, Email = @email,NgayLapThe = @signInDate,TongNo = @debt From DocGia WHERE MaDocGia = @rID";
                SqlCommand Cmd = new SqlCommand(selectQuerry, conn);
                Cmd.Parameters.AddWithValue("@rName", nameTaker.Text);
                Cmd.Parameters.AddWithValue("@tID", readerTypeSet.SelectedValue.ToString());
                Cmd.Parameters.AddWithValue("@birth", birthDayTaker.Text);
                Cmd.Parameters.AddWithValue("@address", addressTaker.Text);
                Cmd.Parameters.AddWithValue("@email", emailTaker.Text);
                Cmd.Parameters.AddWithValue("@signInDate", signInDateTaker.Text);
                Cmd.Parameters.AddWithValue("@debt", Int32.Parse(debtTaker.Text));
                Cmd.Parameters.AddWithValue("@rID", rID);
                Cmd.ExecuteNonQuery();
            }
            catch (Exception s)
            {
                MessageBox.Show("Failed to connect to database!!! Please try again later");
            }
            conn.Close();
            this.Close();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public ModifyReader(string ID,string name, string address, string birth, string debt, string email,string signDate,string type)
        {
            InitializeComponent();
            loadData();
            birthDayTaker.Format = DateTimePickerFormat.Custom;
            signInDateTaker.Format = DateTimePickerFormat.Custom;
            readerTypeSet.DataSource = items;
            readerTypeSet.DisplayMember = "value";
            readerTypeSet.ValueMember = "id";
            readerTypeSet.SelectedIndex = Int32.Parse(type) - 1;
            this.nameTaker.Text = name;
            this.addressTaker.Text = address;
            this.birthDayTaker.Text = birth;
            this.debtTaker.Text = debt;
            this.emailTaker.Text = email;
            this.signInDateTaker.Text = signDate;
            this.rType = type;
            this.rName = name;
            this.rAddress = address;
            this.rBirth = birth;
            this.rDebt = debt;
            this.rEmail = email;
            this.rSignDate = signDate;
            this.rID = ID;
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
    }
}
