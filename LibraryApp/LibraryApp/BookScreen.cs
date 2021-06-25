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
    public partial class BookScreen : Form
    {
        public BookScreen()
        {
            InitializeComponent();
            loadData();
        }

        private void bookData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddBookScreen child = new AddBookScreen();
            child.ShowDialog();
        }

        private void modifyBt_Click(object sender, EventArgs e)
        {
            ModifyBookScreen child = new ModifyBookScreen();
            child.ShowDialog();
        }

        private void loadData()
        {
            String StrQuery;
            using (SqlConnection conn = DBUtils.GetDBConnection())
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("select * from Sach", conn);
                    cmd.CommandType = CommandType.Text;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "ss");
                    bookData.DataSource = ds.Tables["ss"];
                }
                conn.Close();
            }
           
        }
    }
}
