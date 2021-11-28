namespace WindowsFormsApplication1
{
    partial class sellerform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sellerform));
            this.panel1 = new System.Windows.Forms.Panel();
            this.sellpass = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.sellDGV = new Guna.UI.WinForms.GunaDataGridView();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.sellphone = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.sellage = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.sellname = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.sellid = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnselling = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnproduct = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sellDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.sellpass);
            this.panel1.Controls.Add(this.sellDGV);
            this.panel1.Controls.Add(this.btndelete);
            this.panel1.Controls.Add(this.btnedit);
            this.panel1.Controls.Add(this.btnadd);
            this.panel1.Controls.Add(this.sellphone);
            this.panel1.Controls.Add(this.sellage);
            this.panel1.Controls.Add(this.sellname);
            this.panel1.Controls.Add(this.sellid);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.Color.Purple;
            this.panel1.Location = new System.Drawing.Point(151, 116);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(714, 423);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // sellpass
            // 
            this.sellpass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sellpass.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.sellpass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sellpass.HintForeColor = System.Drawing.Color.Empty;
            this.sellpass.HintText = "";
            this.sellpass.isPassword = false;
            this.sellpass.LineFocusedColor = System.Drawing.Color.Blue;
            this.sellpass.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.sellpass.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.sellpass.LineThickness = 3;
            this.sellpass.Location = new System.Drawing.Point(158, 243);
            this.sellpass.Margin = new System.Windows.Forms.Padding(4);
            this.sellpass.Name = "sellpass";
            this.sellpass.Size = new System.Drawing.Size(161, 25);
            this.sellpass.TabIndex = 14;
            this.sellpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.sellpass.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox5_OnValueChanged);
            // 
            // sellDGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.sellDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.sellDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.sellDGV.BackgroundColor = System.Drawing.Color.White;
            this.sellDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sellDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.sellDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.sellDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.sellDGV.ColumnHeadersHeight = 25;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.sellDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.sellDGV.EnableHeadersVisualStyles = false;
            this.sellDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.sellDGV.Location = new System.Drawing.Point(366, 86);
            this.sellDGV.Name = "sellDGV";
            this.sellDGV.RowHeadersVisible = false;
            this.sellDGV.RowHeadersWidth = 51;
            this.sellDGV.RowTemplate.Height = 24;
            this.sellDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.sellDGV.Size = new System.Drawing.Size(322, 323);
            this.sellDGV.TabIndex = 13;
            this.sellDGV.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.sellDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.sellDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.sellDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.sellDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.sellDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.sellDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.sellDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.sellDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.sellDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.sellDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.sellDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.sellDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.sellDGV.ThemeStyle.HeaderStyle.Height = 25;
            this.sellDGV.ThemeStyle.ReadOnly = false;
            this.sellDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.sellDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.sellDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.sellDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Purple;
            this.sellDGV.ThemeStyle.RowsStyle.Height = 24;
            this.sellDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.sellDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.sellDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sellDGV_CellContentClick);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.Purple;
            this.btndelete.FlatAppearance.BorderSize = 0;
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndelete.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btndelete.Location = new System.Drawing.Point(218, 313);
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
            this.btnedit.Location = new System.Drawing.Point(122, 313);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(69, 37);
            this.btnedit.TabIndex = 11;
            this.btnedit.Text = "EDIT";
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
            this.btnadd.Location = new System.Drawing.Point(24, 313);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(69, 37);
            this.btnadd.TabIndex = 6;
            this.btnadd.Text = "ADD";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // sellphone
            // 
            this.sellphone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sellphone.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.sellphone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sellphone.HintForeColor = System.Drawing.Color.Empty;
            this.sellphone.HintText = "";
            this.sellphone.isPassword = false;
            this.sellphone.LineFocusedColor = System.Drawing.Color.Blue;
            this.sellphone.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.sellphone.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.sellphone.LineThickness = 3;
            this.sellphone.Location = new System.Drawing.Point(158, 201);
            this.sellphone.Margin = new System.Windows.Forms.Padding(4);
            this.sellphone.Name = "sellphone";
            this.sellphone.Size = new System.Drawing.Size(161, 25);
            this.sellphone.TabIndex = 9;
            this.sellphone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // sellage
            // 
            this.sellage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sellage.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.sellage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sellage.HintForeColor = System.Drawing.Color.Empty;
            this.sellage.HintText = "";
            this.sellage.isPassword = false;
            this.sellage.LineFocusedColor = System.Drawing.Color.Blue;
            this.sellage.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.sellage.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.sellage.LineThickness = 3;
            this.sellage.Location = new System.Drawing.Point(158, 154);
            this.sellage.Margin = new System.Windows.Forms.Padding(4);
            this.sellage.Name = "sellage";
            this.sellage.Size = new System.Drawing.Size(161, 27);
            this.sellage.TabIndex = 8;
            this.sellage.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // sellname
            // 
            this.sellname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sellname.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.sellname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sellname.HintForeColor = System.Drawing.Color.Empty;
            this.sellname.HintText = "";
            this.sellname.isPassword = false;
            this.sellname.LineFocusedColor = System.Drawing.Color.Blue;
            this.sellname.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.sellname.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.sellname.LineThickness = 3;
            this.sellname.Location = new System.Drawing.Point(158, 101);
            this.sellname.Margin = new System.Windows.Forms.Padding(4);
            this.sellname.Name = "sellname";
            this.sellname.Size = new System.Drawing.Size(161, 35);
            this.sellname.TabIndex = 7;
            this.sellname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // sellid
            // 
            this.sellid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sellid.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.sellid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sellid.HintForeColor = System.Drawing.Color.Empty;
            this.sellid.HintText = "";
            this.sellid.isPassword = false;
            this.sellid.LineFocusedColor = System.Drawing.Color.Blue;
            this.sellid.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.sellid.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.sellid.LineThickness = 3;
            this.sellid.Location = new System.Drawing.Point(158, 68);
            this.sellid.Margin = new System.Windows.Forms.Padding(4);
            this.sellid.Name = "sellid";
            this.sellid.Size = new System.Drawing.Size(161, 25);
            this.sellid.TabIndex = 6;
            this.sellid.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "PASSWORD";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "PHONE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(46, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "AGE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "NAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(267, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "MANAGE SELLERS";
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.SystemColors.Control;
            this.btnexit.FlatAppearance.BorderSize = 0;
            this.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnexit.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.ForeColor = System.Drawing.Color.Purple;
            this.btnexit.Location = new System.Drawing.Point(834, 12);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(43, 37);
            this.btnexit.TabIndex = 6;
            this.btnexit.Text = "X";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnselling
            // 
            this.btnselling.BackColor = System.Drawing.SystemColors.Control;
            this.btnselling.FlatAppearance.BorderSize = 0;
            this.btnselling.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnselling.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnselling.ForeColor = System.Drawing.Color.Purple;
            this.btnselling.Location = new System.Drawing.Point(8, 341);
            this.btnselling.Name = "btnselling";
            this.btnselling.Size = new System.Drawing.Size(137, 40);
            this.btnselling.TabIndex = 16;
            this.btnselling.Text = "SELLING";
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
            this.button2.Location = new System.Drawing.Point(8, 251);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 40);
            this.button2.TabIndex = 15;
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
            this.btnproduct.Location = new System.Drawing.Point(8, 155);
            this.btnproduct.Name = "btnproduct";
            this.btnproduct.Size = new System.Drawing.Size(137, 40);
            this.btnproduct.TabIndex = 14;
            this.btnproduct.Text = "PRODUCT";
            this.btnproduct.UseVisualStyleBackColor = false;
            this.btnproduct.Click += new System.EventHandler(this.btnproduct_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.Control;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Mistral", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button5.Location = new System.Drawing.Point(258, 5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(420, 58);
            this.button5.TabIndex = 17;
            this.button5.Text = "THE K8 COFFEE";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.logocafe2;
            this.pictureBox1.Location = new System.Drawing.Point(8, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // sellerform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 565);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnselling);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnproduct);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "sellerform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "sellerform";
            this.Load += new System.EventHandler(this.sellerform_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sellDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaDataGridView sellDGV;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnadd;
        private Bunifu.Framework.UI.BunifuMaterialTextbox sellphone;
        private Bunifu.Framework.UI.BunifuMaterialTextbox sellage;
        private Bunifu.Framework.UI.BunifuMaterialTextbox sellname;
        private Bunifu.Framework.UI.BunifuMaterialTextbox sellid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnselling;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnproduct;
        private Bunifu.Framework.UI.BunifuMaterialTextbox sellpass;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}