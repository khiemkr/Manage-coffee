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
using System.Data;

namespace WindowsFormsApplication1
{
    public partial class product : Form
    {
        public product()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuMaterialTextbox4_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox5_OnValueChanged(object sender, EventArgs e)
        {

        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-G8GIM34\SQLEXPRESS;Initial Catalog=cafe;Integrated Security=True");

        private void fillcombo()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select CatName from Category", con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("CatnName", typeof(string));
            dt.Load(rdr);
            Catcb.ValueMember = "CatName";
            Catcb.DataSource = dt;
            con.Close();
        }
        private void product_Load(object sender, EventArgs e)
        {
            fillcombo();
            populate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CATEGORYFORM cat = new CATEGORYFORM();
            cat.Show();
            this.Hide();
        }
        private void populate()
        {
            con.Open();
            string query = "select * from ProductTbl ";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder buider = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            proDGV.DataSource = ds.Tables[0];
            con.Close();
        }
        private void cancel()
        {
            proid.Text = "";
            proname.Text = "";
            proqua.Text = "";
            proprice.Text = "";
        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "insert into ProductTbl values (" + proid.Text + ",'" + proname.Text + "',"  + proqua.Text + "," + proprice.Text+ ",'" + Catcb.SelectedValue.ToString() + "')";
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

        private void proDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            proid.Text = proDGV.SelectedRows[0].Cells[0].Value.ToString();
            proname.Text = proDGV.SelectedRows[0].Cells[1].Value.ToString();
            proqua.Text = proDGV.SelectedRows[0].Cells[2].Value.ToString();
            proprice.Text = proDGV.SelectedRows[0].Cells[3].Value.ToString();
            Catcb.SelectedValue = proDGV.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                if (proid.Text == "")
                {
                    MessageBox.Show("Chọn sản phẩm cần xóa");
                }
                else
                {
                    con.Open();
                    string query = " delete from ProductTbl where Prodid =" + proid.Text + "";
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

        private void btnseller_Click(object sender, EventArgs e)
        {
            sellerform sell = new sellerform();
            sell.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                if (proid.Text == "" || proname.Text == "" || proqua.Text == "" || proqua.Text == "" || proprice.Text == "")
                {
                    MessageBox.Show("Thong tin chua hoan chinh");
                }
                else
                {
                    con.Open();
                    string query = "update ProductTbl set ProdName= '" + proname.Text + "',ProdQty='" + proqua.Text + "',Prodprice=" + proprice.Text + ",ProdCat='" + Catcb.SelectedValue.ToString() + "'where prodid=" + proid.Text + ";";
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

        private void btnselling_Click(object sender, EventArgs e)
        {
            selling selling = new selling();
            selling.Show();
            this.Hide();
        }
    }
}
