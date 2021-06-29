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
    public partial class AddBookScreen : Form
    {

        List<Item> authorList = new List<Item>();
        List<Item> genreList = new List<Item>();
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
        public AddBookScreen()
        {
            InitializeComponent();
            todayGetter.Format = DateTimePickerFormat.Custom;
            loadData();
            authorSet.DataSource = authorList;
            authorSet.DisplayMember = "value";
            authorSet.ValueMember = "id";

            genreSet.DataSource = genreList;
            genreSet.DisplayMember = "value";
            genreSet.ValueMember = "id";
            
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveBt_Click(object sender, EventArgs e)
        {
            String bID;
            if (!(String.IsNullOrEmpty(nameTaker.Text) || String.IsNullOrEmpty(posTaker.Text) || String.IsNullOrEmpty(amountTaker.Text)))
            {

                SqlConnection conn1 = DBUtils.GetDBConnection();
                conn1.Open();
                try
                {
                    string selectQuerry = "Insert into Sach (MaSach,TenSach,MaTL,MaTG,TrangThai,SoLuong,ViTri,NamSuatBan,NhaSuatBan,TriGia) values ([dbo].[idSach](),@bName,@TL,@TG,@Status,@amount,@Pos,@pubYear,@publisher,@price)";
                    SqlCommand Cmd = new SqlCommand(selectQuerry, conn1);
                    Cmd.Parameters.AddWithValue("@bName", nameTaker.Text);
                    Cmd.Parameters.AddWithValue("@TL", genreSet.SelectedValue.ToString());
                    Cmd.Parameters.AddWithValue("@TG", authorSet.SelectedValue.ToString());
                    Cmd.Parameters.AddWithValue("@Status", statusTaker.Text);
                    Cmd.Parameters.AddWithValue("@amount", Int32.Parse(amountTaker.Text));
                    Cmd.Parameters.AddWithValue("@Pos", posTaker.Text);
                    Cmd.Parameters.AddWithValue("@pubYear", Int32.Parse(publishYearTaker.Text));
                    Cmd.Parameters.AddWithValue("@publisher", publisherTaker.Text);
                    Cmd.Parameters.AddWithValue("@price", Int32.Parse(priceTaker.Text));
                    Cmd.ExecuteNonQuery();

                }
                catch (Exception s)
                {
                    conn1.Close();
                    MessageBox.Show("Failed to connect to database!!! Please try again later");
                    return;
                }
                conn1.Close();
                //find book id
                try
                {
                    conn1.Open();
                    string selectQuerry = "Select MaSach from Sach where TenSach=@bName and MaTG = @TG";
                    SqlCommand Cmd = new SqlCommand(selectQuerry, conn1);
                    Cmd.Parameters.AddWithValue("@bName", nameTaker.Text);
                    Cmd.Parameters.AddWithValue("@TG", authorSet.SelectedValue.ToString());
                    using (SqlDataReader oReader = Cmd.ExecuteReader())
                    {
                        if (oReader.HasRows)
                        {
                            oReader.Read();
                            bID = oReader["MaSach"].ToString();
                        }
                        else
                        {
                            return;
                        }
                    }
                }
                catch (Exception s)
                {
                    conn1.Close();
                    MessageBox.Show("Failed to connect to database!!! Please try again later");
                    return;
                }
                conn1.Close();

                //new PhieuThu
                conn1.Open();
                try
                {
                    string selectQuerry = "INSERT INTO PhieuNhapSach (MaPNS,NgayNhap,MaSach,SoLuongNhap) VALUES([dbo].[idPhieuThu](),@date,@bID,@amount)";
                    SqlCommand Cmd = new SqlCommand(selectQuerry, conn1);
                    Cmd.Parameters.AddWithValue("@date", todayGetter.Text);
                    Cmd.Parameters.AddWithValue("@bID", bID);
                    Cmd.Parameters.AddWithValue("@amount", Int32.Parse(amountTaker.Text));
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

        private void loadData()
        {
            SqlConnection conn = DBUtils.GetDBConnection();
            try
            {
                conn.Open();
                string selectQuerry = "Select * from TacGia";
                SqlCommand Cmd = new SqlCommand(selectQuerry, conn);
                using (SqlDataReader oReader = Cmd.ExecuteReader())
                {
                    if (oReader.HasRows)
                    {
                        while (oReader.Read())
                        {
                            authorList.Add(new Item(Int32.Parse(oReader["MaTG"].ToString()), oReader["TenTacGia"].ToString()));
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

            try
            {
                conn.Open();
                string selectQuerry = "Select * from TheLoai";
                SqlCommand Cmd = new SqlCommand(selectQuerry, conn);
                using (SqlDataReader oReader = Cmd.ExecuteReader())
                {
                    if (oReader.HasRows)
                    {
                        while (oReader.Read())
                        {
                            genreList.Add(new Item(Int32.Parse(oReader["MaTL"].ToString()), oReader["TenTheLoai"].ToString()));
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
