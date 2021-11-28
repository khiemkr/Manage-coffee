using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WindowsFormsApplication1
{
    public partial class selling : Form
    {
        public selling()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-G8GIM34\SQLEXPRESS;Initial Catalog=cafe;Integrated Security=True");
        
        private void populate()
        {
            con.Open();
            string query = "select ProdID,ProdName,ProdPrice from ProductTbl ";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder buider = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            proDGV.DataSource = ds.Tables[0];
            con.Close();
        }
        private void populatebill()
        {
            con.Open();//hiện dũ liệu lên datagridview
            string query = "select Billid,SellerName,proid,proname,proprice,proSL,Billdate,toAmt from BillTbl ";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder buider = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            BillIDDGV.DataSource = ds.Tables[0];
            con.Close();
        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();// them du liệu
                int total = Convert.ToInt32(proprice.Text) * Convert.ToInt32(proqua.Text);
                Grdtotal = total;
                string query = "insert into BillTbl values (" + billid.Text + ",'" + sellername.Text + "'," + proid.Text + ",'" + proname.Text + "',"  + proprice.Text + ","  +proqua.Text + ",'" + Date.Text +"'," + Grdtotal + ")";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Them thanh cong");
                con.Close();
                populatebill();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void selling_Load(object sender, EventArgs e)
        {
            populate();// gọi lại hàm
            populatebill();
            sellername.Text = Form1.SellerName; //biến static sellername form1 khi tiến hành lấy dữ liệu từ table
            if(Form1.role=="ADMIN" )
            {
                btnselling.Enabled = true;
                button2.Enabled = true;
                btnproduct.Enabled = true;

            }
            if (Form1.role== "seller")
            {
                btnselling.Enabled = false;
                button2.Enabled = false;
                btnproduct.Enabled = false;
            }
        }

        private void proDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            proid.Text = proDGV.SelectedRows[0].Cells[0].Value.ToString();
            proname.Text = proDGV.SelectedRows[0].Cells[1].Value.ToString();
            proprice.Text = proDGV.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void Date_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Date.Text = DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString();//lấy thời gian hệ thống
        }
        int Grdtotal = 0;
        private void thanhtien_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnseller_Click(object sender, EventArgs e)
        {
            sellerform sell = new sellerform();
            sell.Show();
            this.Hide();
        }

        private void btncat_Click(object sender, EventArgs e)
        {
            CATEGORYFORM cat = new CATEGORYFORM();
            cat.Show();
            this.Hide();
        }

        private void btnpro_Click(object sender, EventArgs e)
        {
            product pro = new product();
            pro.Show();
            this.Hide();
        }

        private void btnedit_Click(object sender, EventArgs e)//xuất hóa đơn sau khi xuất tiến hành xóa từ cdsl
        {
            if (billid.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn sản phẩm");
            }
            else
            {
                report rp = new report();
                this.Hide();
                rp.Show();
                try
                {
                    con.Open();
                    string query = " delete from BillTbl";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    populatebill();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);

                }
            }
        }

        private void btndelete_Click(object sender, EventArgs e)//xóa sản phẩm
        {
            try
            {
                if (billid.Text == "")
                {
                    MessageBox.Show("Chọn sản phẩm cần xóa");
                }
                else
                {
                    con.Open();
                    string query = " delete from BillTbl where Billid =" + billid.Text + "";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xoa san pham thanh cong");
                    con.Close();
                    populatebill();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);

            }
        }

        private void BillIDDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)// click chuột hiện dữ liệu từ datagridview
        {
            billid.Text = BillIDDGV.SelectedRows[0].Cells[0].Value.ToString();
            proid.Text = BillIDDGV.SelectedRows[0].Cells[1].Value.ToString();
            proname.Text = BillIDDGV.SelectedRows[0].Cells[2].Value.ToString();
            proqua.Text = BillIDDGV.SelectedRows[0].Cells[3].Value.ToString();
            proprice.Text = BillIDDGV.SelectedRows[0].Cells[4].Value.ToString();
            
        }

        private void OrderDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 ho = new Form1();
            ho.Show();
        }

        private void sellername_Click(object sender, EventArgs e)
        {

        }

        private void btnproduct_Click(object sender, EventArgs e)
        {
            product pro = new product();
            this.Hide();
            pro.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CATEGORYFORM cat = new CATEGORYFORM();
            this.Hide();
            cat.Show();
        }

        private void btnselling_Click(object sender, EventArgs e)
        {
            sellerform sel = new sellerform();
            this.Hide();
            sel.Show();
        }
    }
}
