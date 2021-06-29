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
    public partial class ModifyBookScreen : Form
    {
        List<Item> authorList = new List<Item>();
        List<Item> genreList = new List<Item>();
        String bookID;
        String bName, TG, TL, Status, Amount, Pos, PubYear, Publisher, Price;

        private void saveBt_Click(object sender, EventArgs e)
        {
            SqlConnection conn = DBUtils.GetDBConnection();
            try
            {
                conn.Open();
                string selectQuerry = "UPDATE Sach SET TenSach = @TenSach, MaTL = @TL,MaTG = @TG,TrangThai = @status,SoLuong = @amount, ViTri = @pos,NamSuatBan = @pubYear,NhaSuatBan = @publisher,TriGia = @price From Sach WHERE MaSach = @bID";
                SqlCommand Cmd = new SqlCommand(selectQuerry, conn);
                Cmd.Parameters.AddWithValue("@TenSach", nameTaker.Text);
                Cmd.Parameters.AddWithValue("@TL", genreSet.SelectedValue.ToString());
                Cmd.Parameters.AddWithValue("@TG", authorSet.SelectedValue.ToString());
                Cmd.Parameters.AddWithValue("@status", statusTaker.Text);
                Cmd.Parameters.AddWithValue("@amount", Int32.Parse(amountTaker.Text));
                Cmd.Parameters.AddWithValue("@pos", posTaker.Text);
                Cmd.Parameters.AddWithValue("@pubYear", Int32.Parse(publishYearTaker.Text));
                Cmd.Parameters.AddWithValue("@publisher", publisherTaker.Text);
                Cmd.Parameters.AddWithValue("@price", Int32.Parse(priceTaker.Text));
                Cmd.Parameters.AddWithValue("@bID", bookID);
                Cmd.ExecuteNonQuery();
            }
            catch (Exception s)
            {
                MessageBox.Show("Failed to connect to database!!! Please try again later");
            }
            conn.Close();
        }

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
        public ModifyBookScreen(String id,String name,String tg, String tl, String status, String amount, String pos, String pubyear, String publisher, String price)
        {
            this.bookID = id;
            this.bName = name;
            this.TG = tg;
            this.TL = tl;
            this.Status = status;
            this.Amount = amount;
            this.Pos = pos;
            this.PubYear = pubyear;
            this.Publisher = publisher;
            this.Price = price;
            

            InitializeComponent();
            loadData();
            //set author
            authorSet.DataSource = authorList;
            authorSet.DisplayMember = "value";
            authorSet.ValueMember = "id";
            //authorSet.SelectedValue = Int32.Parse(TG);
            authorSet.SelectedIndex = Int32.Parse(TG) - 1;
            //set genre
            genreSet.DataSource = genreList;
            genreSet.DisplayMember = "value";
            genreSet.ValueMember = "id";
            genreSet.SelectedIndex = Int32.Parse(TL) - 1;

            this.nameTaker.Text = name;
            this.statusTaker.Text = status;
            this.amountTaker.Text = amount;
            this.posTaker.Text = pos;
            this.publisherTaker.Text = publisher;
            this.publishYearTaker.Text = pubyear;
            this.priceTaker.Text = price;

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
