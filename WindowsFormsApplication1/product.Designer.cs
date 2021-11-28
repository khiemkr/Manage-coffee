namespace WindowsFormsApplication1
{
    partial class product
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(product));
            this.panel1 = new System.Windows.Forms.Panel();
            this.proDGV = new Guna.UI.WinForms.GunaDataGridView();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.Catcb = new System.Windows.Forms.ComboBox();
            this.proprice = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.proqua = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.proname = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.proid = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnseller = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnselling = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.proDGV);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.btnadd);
            this.panel1.Controls.Add(this.Catcb);
            this.panel1.Controls.Add(this.proprice);
            this.panel1.Controls.Add(this.proqua);
            this.panel1.Controls.Add(this.proname);
            this.panel1.Controls.Add(this.proid);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.Color.Purple;
            this.panel1.Location = new System.Drawing.Point(155, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(714, 438);
            this.panel1.TabIndex = 0;
            // 
            // proDGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.proDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.proDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.proDGV.BackgroundColor = System.Drawing.Color.White;
            this.proDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.proDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.proDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.proDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.proDGV.ColumnHeadersHeight = 25;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.proDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.proDGV.EnableHeadersVisualStyles = false;
            this.proDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.proDGV.Location = new System.Drawing.Point(366, 86);
            this.proDGV.Name = "proDGV";
            this.proDGV.RowHeadersVisible = false;
            this.proDGV.RowHeadersWidth = 51;
            this.proDGV.RowTemplate.Height = 24;
            this.proDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.proDGV.Size = new System.Drawing.Size(322, 356);
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
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Purple;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button8.Location = new System.Drawing.Point(218, 313);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(101, 37);
            this.button8.TabIndex = 12;
            this.button8.Text = "DELETE";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Purple;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button7.Location = new System.Drawing.Point(122, 313);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(69, 37);
            this.button7.TabIndex = 11;
            this.button7.Text = "EDIT";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
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
            // Catcb
            // 
            this.Catcb.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Catcb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Catcb.FormattingEnabled = true;
            this.Catcb.Items.AddRange(new object[] {
            "DRINK",
            "PASTRY"});
            this.Catcb.Location = new System.Drawing.Point(158, 246);
            this.Catcb.Name = "Catcb";
            this.Catcb.Size = new System.Drawing.Size(161, 27);
            this.Catcb.TabIndex = 10;
            this.Catcb.Text = "SELECT CATEGOGY";
            // 
            // proprice
            // 
            this.proprice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.proprice.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.proprice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.proprice.HintForeColor = System.Drawing.Color.Empty;
            this.proprice.HintText = "";
            this.proprice.isPassword = false;
            this.proprice.LineFocusedColor = System.Drawing.Color.Blue;
            this.proprice.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.proprice.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.proprice.LineThickness = 3;
            this.proprice.Location = new System.Drawing.Point(158, 201);
            this.proprice.Margin = new System.Windows.Forms.Padding(4);
            this.proprice.Name = "proprice";
            this.proprice.Size = new System.Drawing.Size(161, 25);
            this.proprice.TabIndex = 9;
            this.proprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.proprice.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox4_OnValueChanged);
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
            this.proqua.Location = new System.Drawing.Point(158, 154);
            this.proqua.Margin = new System.Windows.Forms.Padding(4);
            this.proqua.Name = "proqua";
            this.proqua.Size = new System.Drawing.Size(161, 27);
            this.proqua.TabIndex = 8;
            this.proqua.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // proname
            // 
            this.proname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.proname.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.proname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.proname.HintForeColor = System.Drawing.Color.Empty;
            this.proname.HintText = "";
            this.proname.isPassword = false;
            this.proname.LineFocusedColor = System.Drawing.Color.Blue;
            this.proname.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.proname.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.proname.LineThickness = 3;
            this.proname.Location = new System.Drawing.Point(158, 101);
            this.proname.Margin = new System.Windows.Forms.Padding(4);
            this.proname.Name = "proname";
            this.proname.Size = new System.Drawing.Size(161, 35);
            this.proname.TabIndex = 7;
            this.proname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // proid
            // 
            this.proid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.proid.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.proid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.proid.HintForeColor = System.Drawing.Color.Empty;
            this.proid.HintText = "";
            this.proid.isPassword = false;
            this.proid.LineFocusedColor = System.Drawing.Color.Blue;
            this.proid.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.proid.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.proid.LineThickness = 3;
            this.proid.Location = new System.Drawing.Point(158, 68);
            this.proid.Margin = new System.Windows.Forms.Padding(4);
            this.proid.Name = "proid";
            this.proid.Size = new System.Drawing.Size(161, 25);
            this.proid.TabIndex = 6;
            this.proid.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "CATEROGY";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 206);
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
            this.label4.Location = new System.Drawing.Point(29, 161);
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
            this.label1.Size = new System.Drawing.Size(180, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "MANAGE PRODUCT";
            // 
            // btnseller
            // 
            this.btnseller.BackColor = System.Drawing.SystemColors.Control;
            this.btnseller.FlatAppearance.BorderSize = 0;
            this.btnseller.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnseller.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnseller.ForeColor = System.Drawing.Color.Purple;
            this.btnseller.Location = new System.Drawing.Point(12, 149);
            this.btnseller.Name = "btnseller";
            this.btnseller.Size = new System.Drawing.Size(137, 40);
            this.btnseller.TabIndex = 1;
            this.btnseller.Text = "SELLER";
            this.btnseller.UseVisualStyleBackColor = false;
            this.btnseller.Click += new System.EventHandler(this.btnseller_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Purple;
            this.button2.Location = new System.Drawing.Point(12, 245);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 40);
            this.button2.TabIndex = 2;
            this.button2.Text = "CATEROGY";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnselling
            // 
            this.btnselling.BackColor = System.Drawing.SystemColors.Control;
            this.btnselling.FlatAppearance.BorderSize = 0;
            this.btnselling.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnselling.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnselling.ForeColor = System.Drawing.Color.Purple;
            this.btnselling.Location = new System.Drawing.Point(12, 335);
            this.btnselling.Name = "btnselling";
            this.btnselling.Size = new System.Drawing.Size(137, 40);
            this.btnselling.TabIndex = 3;
            this.btnselling.Text = "SELLING";
            this.btnselling.UseVisualStyleBackColor = false;
            this.btnselling.Click += new System.EventHandler(this.btnselling_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.Control;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Mistral", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button5.Location = new System.Drawing.Point(297, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(420, 58);
            this.button5.TabIndex = 5;
            this.button5.Text = "THE K8 COFFEE";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.Control;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Purple;
            this.button6.Location = new System.Drawing.Point(843, 1);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(43, 37);
            this.button6.TabIndex = 5;
            this.button6.Text = "X";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.logocafe3;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 565);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnselling);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnseller);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "product";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "product";
            this.Load += new System.EventHandler(this.product_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnseller;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnselling;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox proid;
        private Bunifu.Framework.UI.BunifuMaterialTextbox proprice;
        private Bunifu.Framework.UI.BunifuMaterialTextbox proqua;
        private Bunifu.Framework.UI.BunifuMaterialTextbox proname;
        private System.Windows.Forms.ComboBox Catcb;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button btnadd;
        private Guna.UI.WinForms.GunaDataGridView proDGV;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}