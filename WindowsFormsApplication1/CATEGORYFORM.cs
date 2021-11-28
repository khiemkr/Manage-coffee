using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class CATEGORYFORM : Form
    {
        public CATEGORYFORM()
        {
            InitializeComponent();
        }
        private void populate()
        {
            con.Open();
            string query = "select * from Category ";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder buider = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            CatDGV.DataSource = ds.Tables[0];
            con.Close();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-G8GIM34\SQLEXPRESS;Initial Catalog=cafe;Integrated Security=True");
        private void cancel()
        {
            CatIDTb.Text = "";
            CatNameTb.Text = "";
            CatDesTb.Text = "";
        }
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "insert into Category values (" + CatIDTb.Text + ",'" + CatNameTb.Text + "'," + "'" + CatDesTb.Text + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Them thanh cong");
                con.Close();
                populate();
                cancel();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void CATEGORYFORM_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void CatDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CatIDTb.Text = CatDGV.SelectedRows[0].Cells[0].Value.ToString();
            CatNameTb.Text = CatDGV.SelectedRows[0].Cells[1].Value.ToString();
            CatDesTb.Text = CatDGV.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                if(CatIDTb.Text == "")
                {
                    MessageBox.Show("Chọn sản phẩm cần xóa");
                }
                else
                {
                    con.Open();
                    string query = " delete from Category where Catid =" + CatIDTb.Text + "";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xoa san pham thanh cong");
                    con.Close();
                    populate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
        
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                if ( CatIDTb.Text=="" || CatNameTb.Text== "" || CatDesTb.Text=="" )
                {
                    MessageBox.Show("Thong tin chua hoan chinh");
                }
                else
                {
                    con.Open();
                    string query = "update Category set CatName= '" + CatNameTb.Text + "',CatDesc='" + CatDesTb.Text + "'where Catid=" + CatIDTb.Text + ";" ;
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cap nhat thnah cong");
                    con.Close();
                    populate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
               
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            product pro = new product();
            pro.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sellerform sell = new sellerform();
            sell.Show();
            this.Hide();
        }

        private void btnselling_Click(object sender, EventArgs e)
        {
            selling selling = new selling();
            selling.Show();
            this.Hide();
        }
    }
}
