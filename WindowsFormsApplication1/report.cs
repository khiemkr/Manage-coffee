using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class report : Form
    {
        public report()
        {
            InitializeComponent();
        }

        private void report_Load(object sender, EventArgs e)
        {
            reportViewer1.Reset();
            // định dạng report
            reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.Normal);
            reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
            //reportViewer1.ZoomPercent = 100;
            // cấu hình report
            DataSet1 dts = new DataSet1();
            dts.BeginInit();
            this.reportViewer1.LocalReport.DataSources.Add(
                new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dts.Tables["BillTbl"]));
            this.reportViewer1.LocalReport.ReportPath = "../../Report.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            dts.EndInit();
            // kết nối csdl
            string connectionString = @"Data Source=DESKTOP-G8GIM34\SQLEXPRESS;Initial Catalog=cafe;Integrated Security=True";

            // xuất report
            DataSet1TableAdapters.BillTblTableAdapter tabill = new DataSet1TableAdapters.BillTblTableAdapter();
            tabill.Connection.ConnectionString = connectionString;
            tabill.ClearBeforeFill = true;
            tabill.Fill(dts.BillTbl);

            this.reportViewer1.RefreshReport();
          
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            selling sel = new selling();
            this.Hide();
            sel.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            selling sel = new selling();
            this.Hide();
            sel.Show();
        }
    }
    
}
