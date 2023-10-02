namespace DatabaseProject
{
    partial class userForm
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
            this.button_delete = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.TextBox_name = new Guna.UI.WinForms.GunaLineTextBox();
            this.TextBox_age = new Guna.UI.WinForms.GunaLineTextBox();
            this.TextBox_phone = new Guna.UI.WinForms.GunaLineTextBox();
            this.TextBox_id = new Guna.UI.WinForms.GunaLineTextBox();
            this.button_category = new System.Windows.Forms.Button();
            this.button_product = new System.Windows.Forms.Button();
            this.label_exit = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_logout = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox_roleType = new System.Windows.Forms.ComboBox();
            this.dataGridView_User = new Guna.UI.WinForms.GunaDataGridView();
            this.TextBox_pass = new Guna.UI.WinForms.GunaLineTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button_selling = new System.Windows.Forms.Button();
            this.button_search = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_User)).BeginInit();
            this.SuspendLayout();
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.Color.DarkOrange;
            this.button_delete.FlatAppearance.BorderSize = 0;
            this.button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_delete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_delete.ForeColor = System.Drawing.Color.White;
            this.button_delete.Location = new System.Drawing.Point(229, 504);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(113, 44);
            this.button_delete.TabIndex = 9;
            this.button_delete.Text = "DELETE";
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_update
            // 
            this.button_update.BackColor = System.Drawing.Color.DarkOrange;
            this.button_update.FlatAppearance.BorderSize = 0;
            this.button_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_update.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_update.ForeColor = System.Drawing.Color.White;
            this.button_update.Location = new System.Drawing.Point(126, 504);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(97, 44);
            this.button_update.TabIndex = 9;
            this.button_update.Text = "UPDATE";
            this.button_update.UseVisualStyleBackColor = false;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.Color.DarkOrange;
            this.button_add.FlatAppearance.BorderSize = 0;
            this.button_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add.ForeColor = System.Drawing.Color.White;
            this.button_add.Location = new System.Drawing.Point(17, 504);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(97, 44);
            this.button_add.TabIndex = 9;
            this.button_add.Text = "ADD";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // TextBox_name
            // 
            this.TextBox_name.BackColor = System.Drawing.Color.White;
            this.TextBox_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_name.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TextBox_name.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_name.LineColor = System.Drawing.Color.Gainsboro;
            this.TextBox_name.Location = new System.Drawing.Point(163, 198);
            this.TextBox_name.Name = "TextBox_name";
            this.TextBox_name.PasswordChar = '\0';
            this.TextBox_name.SelectedText = "";
            this.TextBox_name.Size = new System.Drawing.Size(160, 30);
            this.TextBox_name.TabIndex = 7;
            // 
            // TextBox_age
            // 
            this.TextBox_age.BackColor = System.Drawing.Color.White;
            this.TextBox_age.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_age.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TextBox_age.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_age.LineColor = System.Drawing.Color.Gainsboro;
            this.TextBox_age.Location = new System.Drawing.Point(163, 243);
            this.TextBox_age.Name = "TextBox_age";
            this.TextBox_age.PasswordChar = '\0';
            this.TextBox_age.SelectedText = "";
            this.TextBox_age.Size = new System.Drawing.Size(160, 30);
            this.TextBox_age.TabIndex = 6;
            // 
            // TextBox_phone
            // 
            this.TextBox_phone.BackColor = System.Drawing.Color.White;
            this.TextBox_phone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_phone.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TextBox_phone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_phone.LineColor = System.Drawing.Color.Gainsboro;
            this.TextBox_phone.Location = new System.Drawing.Point(163, 288);
            this.TextBox_phone.Name = "TextBox_phone";
            this.TextBox_phone.PasswordChar = '\0';
            this.TextBox_phone.SelectedText = "";
            this.TextBox_phone.Size = new System.Drawing.Size(160, 30);
            this.TextBox_phone.TabIndex = 5;
            // 
            // TextBox_id
            // 
            this.TextBox_id.BackColor = System.Drawing.Color.White;
            this.TextBox_id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_id.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TextBox_id.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_id.LineColor = System.Drawing.Color.Gainsboro;
            this.TextBox_id.Location = new System.Drawing.Point(163, 153);
            this.TextBox_id.Name = "TextBox_id";
            this.TextBox_id.PasswordChar = '\0';
            this.TextBox_id.SelectedText = "";
            this.TextBox_id.Size = new System.Drawing.Size(160, 30);
            this.TextBox_id.TabIndex = 4;
            // 
            // button_category
            // 
            this.button_category.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_category.FlatAppearance.BorderSize = 0;
            this.button_category.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_category.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_category.ForeColor = System.Drawing.Color.DarkOrange;
            this.button_category.Location = new System.Drawing.Point(23, 226);
            this.button_category.Name = "button_category";
            this.button_category.Size = new System.Drawing.Size(133, 44);
            this.button_category.TabIndex = 14;
            this.button_category.Text = "CATEGORY";
            this.button_category.UseVisualStyleBackColor = false;
            this.button_category.Click += new System.EventHandler(this.button_category_Click);
            // 
            // button_product
            // 
            this.button_product.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_product.FlatAppearance.BorderSize = 0;
            this.button_product.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_product.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_product.ForeColor = System.Drawing.Color.DarkOrange;
            this.button_product.Location = new System.Drawing.Point(21, 144);
            this.button_product.Name = "button_product";
            this.button_product.Size = new System.Drawing.Size(136, 44);
            this.button_product.TabIndex = 15;
            this.button_product.Text = "PRODUCT";
            this.button_product.UseVisualStyleBackColor = false;
            this.button_product.Click += new System.EventHandler(this.button_product_Click);
            // 
            // label_exit
            // 
            this.label_exit.AutoSize = true;
            this.label_exit.BackColor = System.Drawing.SystemColors.Control;
            this.label_exit.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_exit.ForeColor = System.Drawing.Color.DarkOrange;
            this.label_exit.Location = new System.Drawing.Point(1058, 1);
            this.label_exit.Name = "label_exit";
            this.label_exit.Size = new System.Drawing.Size(29, 31);
            this.label_exit.TabIndex = 12;
            this.label_exit.Text = "X";
            this.label_exit.Click += new System.EventHandler(this.label_exit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(38, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phone No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(38, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "AGE";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(38, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "NAME";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(38, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID";
            // 
            // button_logout
            // 
            this.button_logout.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_logout.FlatAppearance.BorderSize = 0;
            this.button_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_logout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_logout.ForeColor = System.Drawing.Color.DarkOrange;
            this.button_logout.Location = new System.Drawing.Point(32, 596);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(114, 44);
            this.button_logout.TabIndex = 16;
            this.button_logout.Text = "LOG OUT";
            this.button_logout.UseVisualStyleBackColor = false;
            this.button_logout.Click += new System.EventHandler(this.button_logout_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(315, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(202, 33);
            this.label6.TabIndex = 3;
            this.label6.Text = "MANAGE USERS";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Controls.Add(this.comboBox_roleType);
            this.panel1.Controls.Add(this.dataGridView_User);
            this.panel1.Controls.Add(this.button_delete);
            this.panel1.Controls.Add(this.button_update);
            this.panel1.Controls.Add(this.button_add);
            this.panel1.Controls.Add(this.TextBox_name);
            this.panel1.Controls.Add(this.TextBox_age);
            this.panel1.Controls.Add(this.TextBox_pass);
            this.panel1.Controls.Add(this.TextBox_phone);
            this.panel1.Controls.Add(this.TextBox_id);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(221, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(866, 614);
            this.panel1.TabIndex = 11;
            // 
            // comboBox_roleType
            // 
            this.comboBox_roleType.ForeColor = System.Drawing.Color.DarkOrange;
            this.comboBox_roleType.FormattingEnabled = true;
            this.comboBox_roleType.Items.AddRange(new object[] {
            "ADMIN\t",
            "CUSTOMER"});
            this.comboBox_roleType.Location = new System.Drawing.Point(163, 378);
            this.comboBox_roleType.Name = "comboBox_roleType";
            this.comboBox_roleType.Size = new System.Drawing.Size(160, 24);
            this.comboBox_roleType.TabIndex = 11;
            this.comboBox_roleType.Text = "Select Role";
            // 
            // dataGridView_User
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridView_User.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_User.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_User.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_User.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_User.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView_User.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_User.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_User.ColumnHeadersHeight = 29;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_User.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_User.EnableHeadersVisualStyles = false;
            this.dataGridView_User.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_User.Location = new System.Drawing.Point(344, 153);
            this.dataGridView_User.Name = "dataGridView_User";
            this.dataGridView_User.RowHeadersVisible = false;
            this.dataGridView_User.RowHeadersWidth = 51;
            this.dataGridView_User.RowTemplate.Height = 24;
            this.dataGridView_User.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_User.Size = new System.Drawing.Size(512, 458);
            this.dataGridView_User.TabIndex = 10;
            this.dataGridView_User.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dataGridView_User.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_User.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridView_User.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridView_User.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridView_User.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridView_User.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_User.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_User.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridView_User.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView_User.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView_User.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView_User.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridView_User.ThemeStyle.HeaderStyle.Height = 29;
            this.dataGridView_User.ThemeStyle.ReadOnly = false;
            this.dataGridView_User.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_User.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView_User.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView_User.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridView_User.ThemeStyle.RowsStyle.Height = 24;
            this.dataGridView_User.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_User.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridView_User.Click += new System.EventHandler(this.dataGridView_User_Click);
            // 
            // TextBox_pass
            // 
            this.TextBox_pass.BackColor = System.Drawing.Color.White;
            this.TextBox_pass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_pass.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TextBox_pass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_pass.LineColor = System.Drawing.Color.Gainsboro;
            this.TextBox_pass.Location = new System.Drawing.Point(163, 333);
            this.TextBox_pass.Name = "TextBox_pass";
            this.TextBox_pass.PasswordChar = '●';
            this.TextBox_pass.SelectedText = "";
            this.TextBox_pass.Size = new System.Drawing.Size(160, 30);
            this.TextBox_pass.TabIndex = 5;
            this.TextBox_pass.UseSystemPasswordChar = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(38, 373);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 29);
            this.label7.TabIndex = 3;
            this.label7.Text = "USER TYPE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(38, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 29);
            this.label5.TabIndex = 3;
            this.label5.Text = "PASSWORD";
            // 
            // button_selling
            // 
            this.button_selling.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_selling.FlatAppearance.BorderSize = 0;
            this.button_selling.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_selling.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_selling.ForeColor = System.Drawing.Color.DarkOrange;
            this.button_selling.Location = new System.Drawing.Point(23, 305);
            this.button_selling.Name = "button_selling";
            this.button_selling.Size = new System.Drawing.Size(133, 44);
            this.button_selling.TabIndex = 14;
            this.button_selling.Text = "SELLING";
            this.button_selling.UseVisualStyleBackColor = false;
            this.button_selling.Click += new System.EventHandler(this.button_selling_Click);
            // 
            // button_search
            // 
            this.button_search.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_search.FlatAppearance.BorderSize = 0;
            this.button_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_search.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_search.ForeColor = System.Drawing.Color.DarkOrange;
            this.button_search.Location = new System.Drawing.Point(32, 368);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(114, 44);
            this.button_search.TabIndex = 22;
            this.button_search.Text = "Search";
            this.button_search.UseVisualStyleBackColor = false;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // userForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1100, 650);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.button_selling);
            this.Controls.Add(this.button_category);
            this.Controls.Add(this.button_product);
            this.Controls.Add(this.label_exit);
            this.Controls.Add(this.button_logout);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "userForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.userForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_User)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_add;
        private Guna.UI.WinForms.GunaLineTextBox TextBox_name;
        private Guna.UI.WinForms.GunaLineTextBox TextBox_age;
        private Guna.UI.WinForms.GunaLineTextBox TextBox_phone;
        private Guna.UI.WinForms.GunaLineTextBox TextBox_id;
        private System.Windows.Forms.Button button_category;
        private System.Windows.Forms.Button button_product;
        private System.Windows.Forms.Label label_exit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_logout;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaDataGridView dataGridView_User;
        private Guna.UI.WinForms.GunaLineTextBox TextBox_pass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_roleType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_selling;
        private System.Windows.Forms.Button button_search;
    }
}