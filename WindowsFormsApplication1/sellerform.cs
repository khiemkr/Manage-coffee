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
    public partial class sellerform : Form
    {
        public sellerform()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-G8GIM34\SQLEXPRESS;Initial Catalog=cafe;Integrated Security=True");
        private void bunifuMaterialTextbox5_OnValueChanged(object sender, EventArgs e)
        {

        }
        private void populate()
        {
            con.Open();
            string query = "select * from SellerTbl ";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder buider = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            sellDGV.DataSource = ds.Tables[0];
            con.Close();
        }
        private void sellDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            sellid.Text = sellDGV.SelectedRows[0].Cells[0].Value.ToString();
            sellname.Text = sellDGV.SelectedRows[0].Cells[1].Value.ToString();
            sellage.Text = sellDGV.SelectedRows[0].Cells[2].Value.ToString();
            sellphone.Text = sellDGV.SelectedRows[0].Cells[3].Value.ToString();
            sellpass.Text = sellDGV.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            populate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CATEGORYFORM cat = new CATEGORYFORM();
            cat.Show();
            this.Hide();
        }

        private void btnproduct_Click(object sender, EventArgs e)
        {
            product pro = new product();
            pro.Show();
            this.Hide();
        }

        private void sellerform_Load(object sender, EventArgs e)
        {
           
        }
        private void cancel()
        {
            sellid.Text = "";
            sellname.Text = "";
            sellage.Text = "";
            sellphone.Text = "";
            sellpass.Text = "";
        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "insert into SellerTbl values (" + sellid.Text + ",'" + sellname.Text + "'," + sellage.Text+ ",'" + sellphone.Text + "','" + sellpass.Text + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Them thanh cong");
                con.Close();
                populate();
                con.Close();
                populate();
                cancel();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            try
            {
                if (sellid.Text == "" || sellname.Text == "" || sellage.Text == "" || sellphone.Text == "" || sellpass.Text == "")
                {
                    MessageBox.Show("Thong tin chua hoan chinh");
                }
                else
                {
                    con.Open();
                    string query = "update SellerTbl set SellerName= '" + sellname.Text + "',SellerAge=" + sellage.Text + ",SellerPhone='" + sellphone.Text + "',SellerPass='" + sellpass.Text + "'where SellerID=" + sellid.Text + ";";
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

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (sellid.Text == "")
                {
                    MessageBox.Show("Chọn sản phẩm cần xóa");
                }
                else
                {
                    con.Open();
                    string query = " delete from SellerTbl where SellerID =" + sellid.Text + "";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xoa san pham thanh cong");
                    con.Close();
                    populate();
                    sellid.Text = "";
                    sellname.Text = "";
                    sellage.Text = "";
                    sellphone.Text = "";
                    sellpass.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);

            }
        }

        private void btnselling_Click(object sender, EventArgs e)
        {
            selling selling = new selling();
            selling.Show();
            this.Hide();
        }
    }
}
