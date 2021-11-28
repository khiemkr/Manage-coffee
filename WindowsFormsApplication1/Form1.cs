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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox2_OnValueChanged(object sender, EventArgs e)
        {
            txtpass.isPassword = true;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        public static string SellerName = "";
        public static string role = "";

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)// cancel khi nhập sai
        {
            txtuser.Text = "";
            txtpass.Text = "";
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-G8GIM34\SQLEXPRESS;Initial Catalog=cafe;Integrated Security=True");
        private void btnlogin_Click(object sender, EventArgs e)
        {
            if(txtuser.Text==""||txtpass.Text==""){
                MessageBox.Show("Ban chua nhap user hoac password");
            }
            else
            {
                if (rolecb.SelectedItem.ToString() == "ADMIN")
                {
                    role = "ADMIN";
                    if (txtuser.Text == "admin" && txtpass.Text=="admin")
                    {
                        product pro = new product();
                        pro.Show();
                        this.Hide();
                        
                    }
                    else
                    {
                        MessageBox.Show("Ten tai khoan hoac mat khau khong chinh xac");
                    }
                }
                else 
                {
                    con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("select count(*) from SellerTbl where SellerName ='" +txtuser.Text+ "'and SellerPass = '" + txtpass.Text + "'",con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt); //kiểm tra tài khoản từ csdl
                    if (dt.Rows[0][0].ToString() =="1")
                    {
                        SellerName = txtuser.Text;
                        role = "seller";
                        selling sell = new selling();
                        sell.Show();
                        
                        this.Hide();
                        con.Close();
                    }
                    else
                    {
                        MessageBox.Show("Ban da nhap sai tai khoan hoac mat khau");
                    }
                    con.Close();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)//bat sư kien enter
        {
            this.KeyPreview = true;
            this.KeyDown += Form1_KeyDown;
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnlogin_Click(sender, e);
            }
        }
    }
}
