namespace WindowsFormsApplication1
{
    partial class selling
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(selling));
            this.panel1 = new System.Windows.Forms.Panel();
            this.proid = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label8 = new System.Windows.Forms.Label();
            this.BillIDDGV = new Guna.UI.WinForms.GunaDataGridView();
            this.sellername = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.proDGV = new Guna.UI.WinForms.GunaDataGridView();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.proprice = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.proqua = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.proname = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.billid = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnselling = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnproduct = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BillIDDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.proid);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.BillIDDGV);
            this.panel1.Controls.Add(this.sellername);
            this.panel1.Controls.Add(this.Date);
            this.panel1.Controls.Add(this.proDGV);
            this.panel1.Controls.Add(this.btndelete);
            this.panel1.Controls.Add(this.btnedit);
            this.panel1.Controls.Add(this.btnadd);
            this.panel1.Controls.Add(this.proprice);
            this.panel1.Controls.Add(this.proqua);
            this.panel1.Controls.Add(this.proname);
            this.panel1.Controls.Add(this.billid);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.Color.Purple;
            this.panel1.Location = new System.Drawing.Point(150, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1081, 501);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // proid
            // 
            this.proid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.proid.Enabled = false;
            this.proid.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.proid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.proid.HintForeColor = System.Drawing.Color.Empty;
            this.proid.HintText = "";
            this.proid.isPassword = false;
            this.proid.LineFocusedColor = System.Drawing.Color.Blue;
            this.proid.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.proid.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.proid.LineThickness = 3;
            this.proid.Location = new System.Drawing.Point(132, 86);
            this.proid.Margin = new System.Windows.Forms.Padding(4);
            this.proid.Name = "proid";
            this.proid.Size = new System.Drawing.Size(213, 25);
            this.proid.TabIndex = 25;
            this.proid.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(20, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 20);
            this.label8.TabIndex = 24;
            this.label8.Text = "PROID";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // BillIDDGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.BillIDDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.BillIDDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BillIDDGV.BackgroundColor = System.Drawing.Color.White;
            this.BillIDDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BillIDDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.BillIDDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BillIDDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.BillIDDGV.ColumnHeadersHeight = 25;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BillIDDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.BillIDDGV.EnableHeadersVisualStyles = false;
            this.BillIDDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.BillIDDGV.Location = new System.Drawing.Point(467, 47);
            this.BillIDDGV.Name = "BillIDDGV";
            this.BillIDDGV.RowHeadersVisible = false;
            this.BillIDDGV.RowHeadersWidth = 51;
            this.BillIDDGV.RowTemplate.Height = 24;
            this.BillIDDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BillIDDGV.Size = new System.Drawing.Size(572, 345);
            this.BillIDDGV.TabIndex = 19;
            this.BillIDDGV.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.BillIDDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.BillIDDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.BillIDDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.BillIDDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.BillIDDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.BillIDDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.BillIDDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.BillIDDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.BillIDDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.BillIDDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.BillIDDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.BillIDDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.BillIDDGV.ThemeStyle.HeaderStyle.Height = 25;
            this.BillIDDGV.ThemeStyle.ReadOnly = false;
            this.BillIDDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.BillIDDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.BillIDDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.BillIDDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Purple;
            this.BillIDDGV.ThemeStyle.RowsStyle.Height = 24;
            this.BillIDDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.BillIDDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.BillIDDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BillIDDGV_CellContentClick);
            // 
            // sellername
            // 
            this.sellername.AutoSize = true;
            this.sellername.Font = new System.Drawing.Font("Hobo Std", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellername.ForeColor = System.Drawing.Color.Black;
            this.sellername.Location = new System.Drawing.Point(19, 8);
            this.sellername.Name = "sellername";
            this.sellername.Size = new System.Drawing.Size(62, 24);
            this.sellername.TabIndex = 17;
            this.sellername.Text = "Seller:";
            this.sellername.Click += new System.EventHandler(this.sellername_Click);
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Font = new System.Drawing.Font("Hobo Std", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.ForeColor = System.Drawing.Color.Black;
            this.Date.Location = new System.Drawing.Point(974, 9);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(47, 24);
            this.Date.TabIndex = 16;
            this.Date.Text = "Date";
            this.Date.Click += new System.EventHandler(this.Date_Click);
            // 
            // proDGV
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.proDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.proDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.proDGV.BackgroundColor = System.Drawing.Color.White;
            this.proDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.proDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.proDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.proDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.proDGV.ColumnHeadersHeight = 25;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.proDGV.DefaultCellStyle = dataGridViewCellStyle6;
            this.proDGV.EnableHeadersVisualStyles = false;
            this.proDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.proDGV.Location = new System.Drawing.Point(11, 252);
            this.proDGV.Name = "proDGV";
            this.proDGV.RowHeadersVisible = false;
            this.proDGV.RowHeadersWidth = 51;
            this.proDGV.RowTemplate.Height = 24;
            this.proDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.proDGV.Size = new System.Drawing.Size(334, 230);
            this.proDGV.TabIndex = 13;
            this.proDGV.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.proDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.proDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.proDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.proDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.proDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.proDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.proDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.proDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.proDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.proDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.proDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.proDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.proDGV.ThemeStyle.HeaderStyle.Height = 25;
            this.proDGV.ThemeStyle.ReadOnly = false;
            this.proDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.proDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.proDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.proDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Purple;
            this.proDGV.ThemeStyle.RowsStyle.Height = 24;
            this.proDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.proDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.proDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.proDGV_CellContentClick);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.Purple;
            this.btndelete.FlatAppearance.BorderSize = 0;
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndelete.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btndelete.Location = new System.Drawing.Point(938, 445);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(101, 37);
            this.btndelete.TabIndex = 12;
            this.btndelete.Text = "DELETE";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnedit
            // 
            this.btnedit.BackColor = System.Drawing.Color.Purple;
            this.btnedit.FlatAppearance.BorderSize = 0;
            this.btnedit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnedit.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnedit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnedit.Location = new System.Drawing.Point(701, 445);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(82, 37);
            this.btnedit.TabIndex = 11;
            this.btnedit.Text = "PRINT";
            this.btnedit.UseVisualStyleBackColor = false;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.Purple;
            this.btnadd.FlatAppearance.BorderSize = 0;
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadd.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnadd.Location = new System.Drawing.Point(467, 445);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(69, 37);
            this.btnadd.TabIndex = 6;
            this.btnadd.Text = "ADD";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // proprice
            // 
            this.proprice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.proprice.Enabled = false;
            this.proprice.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.proprice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.proprice.HintForeColor = System.Drawing.Color.Empty;
            this.proprice.HintText = "";
            this.proprice.isPassword = false;
            this.proprice.LineFocusedColor = System.Drawing.Color.Blue;
            this.proprice.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.proprice.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.proprice.LineThickness = 3;
            this.proprice.Location = new System.Drawing.Point(132, 201);
            this.proprice.Margin = new System.Windows.Forms.Padding(4);
            this.proprice.Name = "proprice";
            this.proprice.Size = new System.Drawing.Size(213, 25);
            this.proprice.TabIndex = 9;
            this.proprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // proqua
            // 
            this.proqua.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.proqua.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.proqua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.proqua.HintForeColor = System.Drawing.Color.Empty;
            this.proqua.HintText = "";
            this.proqua.isPassword = false;
            this.proqua.LineFocusedColor = System.Drawing.Color.Blue;
            this.proqua.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.proqua.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.proqua.LineThickness = 3;
            this.proqua.Location = new System.Drawing.Point(132, 159);
            this.proqua.Margin = new System.Windows.Forms.Padding(4);
            this.proqua.Name = "proqua";
            this.proqua.Size = new System.Drawing.Size(213, 27);
            this.proqua.TabIndex = 8;
            this.proqua.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // proname
            // 
            this.proname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.proname.Enabled = false;
            this.proname.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.proname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.proname.HintForeColor = System.Drawing.Color.Empty;
            this.proname.HintText = "";
            this.proname.isPassword = false;
            this.proname.LineFocusedColor = System.Drawing.Color.Blue;
            this.proname.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.proname.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.proname.LineThickness = 3;
            this.proname.Location = new System.Drawing.Point(132, 112);
            this.proname.Margin = new System.Windows.Forms.Padding(4);
            this.proname.Name = "proname";
            this.proname.Size = new System.Drawing.Size(213, 35);
            this.proname.TabIndex = 7;
            this.proname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // billid
            // 
            this.billid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.billid.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.billid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.billid.HintForeColor = System.Drawing.Color.Empty;
            this.billid.HintText = "";
            this.billid.isPassword = false;
            this.billid.LineFocusedColor = System.Drawing.Color.Blue;
            this.billid.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.billid.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.billid.LineThickness = 3;
            this.billid.Location = new System.Drawing.Point(132, 42);
            this.billid.Margin = new System.Windows.Forms.Padding(4);
            this.billid.Name = "billid";
            this.billid.Size = new System.Drawing.Size(213, 25);
            this.billid.TabIndex = 6;
            this.billid.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "PRICE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "QUATITY";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "PRONAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "BILLD";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(479, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "SELLING";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.Control;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Mistral", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button5.Location = new System.Drawing.Point(409, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(420, 58);
            this.button5.TabIndex = 15;
            this.button5.Text = "THE K8 COFFEE";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.Control;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Purple;
            this.button6.Location = new System.Drawing.Point(1216, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(43, 37);
            this.button6.TabIndex = 20;
            this.button6.Text = "X";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Purple;
            this.label6.Location = new System.Drawing.Point(27, 519);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 24);
            this.label6.TabIndex = 26;
            this.label6.Text = "LOG OUT";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // btnselling
            // 
            this.btnselling.BackColor = System.Drawing.SystemColors.Control;
            this.btnselling.FlatAppearance.BorderSize = 0;
            this.btnselling.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnselling.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnselling.ForeColor = System.Drawing.Color.Purple;
            this.btnselling.Location = new System.Drawing.Point(7, 340);
            this.btnselling.Name = "btnselling";
            this.btnselling.Size = new System.Drawing.Size(137, 40);
            this.btnselling.TabIndex = 28;
            this.btnselling.Text = "SELLER";
            this.btnselling.UseVisualStyleBackColor = false;
            this.btnselling.Click += new System.EventHandler(this.btnselling_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Purple;
            this.button2.Location = new System.Drawing.Point(7, 250);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 40);
            this.button2.TabIndex = 27;
            this.button2.Text = "CATEGORIES";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnproduct
            // 
            this.btnproduct.BackColor = System.Drawing.SystemColors.Control;
            this.btnproduct.FlatAppearance.BorderSize = 0;
            this.btnproduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnproduct.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnproduct.ForeColor = System.Drawing.Color.Purple;
            this.btnproduct.Location = new System.Drawing.Point(7, 154);
            this.btnproduct.Name = "btnproduct";
            this.btnproduct.Size = new System.Drawing.Size(137, 40);
            this.btnproduct.TabIndex = 26;
            this.btnproduct.Text = "PRODUCT";
            this.btnproduct.UseVisualStyleBackColor = false;
            this.btnproduct.Click += new System.EventHandler(this.btnproduct_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.logocafe1;
            this.pictureBox1.Location = new System.Drawing.Point(7, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // selling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 627);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnselling);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btnproduct);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "selling";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "selling";
            this.Load += new System.EventHandler(this.selling_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BillIDDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaDataGridView proDGV;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnadd;
        private Bunifu.Framework.UI.BunifuMaterialTextbox proprice;
        private Bunifu.Framework.UI.BunifuMaterialTextbox proqua;
        private Bunifu.Framework.UI.BunifuMaterialTextbox proname;
        private Bunifu.Framework.UI.BunifuMaterialTextbox billid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Label sellername;
        private Guna.UI.WinForms.GunaDataGridView BillIDDGV;
        private Bunifu.Framework.UI.BunifuMaterialTextbox proid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnselling;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnproduct;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}