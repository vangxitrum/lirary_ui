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
    public partial class DashbroadScreen : Form
    {
        public DashbroadScreen()
        {
            InitializeComponent();
            LoadData();
           
        }

        private void LoadData()
        {
            genreRP.Rows.Clear();
            SqlConnection conn = DBUtils.GetDBConnection();
            try
            {
                conn.Open();
                string selectQuerry = "select *, Round(Tile,2) as TiLe from TheLoai";
                SqlCommand Cmd = new SqlCommand(selectQuerry, conn);

                using (SqlDataReader oReader = Cmd.ExecuteReader())
                {
                    if (oReader.HasRows)
                    {
                        while (oReader.Read())
                        {
                            genreRP.Rows.Add(
                                oReader["MaTL"].ToString(),
                                oReader["TenTheLoai"].ToString(),
                                oReader["SoLuotMuon"].ToString(),
                                oReader["TiLe"].ToString()
                                );
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
                string selectQuerry = "select a.MaSach,TenSach,SoNgayMuon,SoNgayTraTre from Sach a, BaoCaoSach b where a.MaSach = b.MaSach";
                SqlCommand Cmd = new SqlCommand(selectQuerry, conn);

                using (SqlDataReader oReader = Cmd.ExecuteReader())
                {
                    if (oReader.HasRows)
                    {
                        while (oReader.Read())
                        {
                            bookRP.Rows.Add(
                                oReader["MaSach"].ToString(),
                                oReader["TenSach"].ToString(),
                                oReader["SoNgayMuon"].ToString(),
                                oReader["SoNgayTraTre"].ToString()
                                );
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
