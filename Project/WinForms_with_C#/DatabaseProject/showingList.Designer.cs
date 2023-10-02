namespace DatabaseProject
{
    partial class showingList
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(showingList));
            this.textBox_query = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.button_query1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_query
            // 
            this.textBox_query.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_query.Location = new System.Drawing.Point(12, 12);
            this.textBox_query.Multiline = true;
            this.textBox_query.Name = "textBox_query";
            this.textBox_query.Size = new System.Drawing.Size(763, 164);
            this.textBox_query.TabIndex = 0;
            this.textBox_query.Text = resources.GetString("textBox_query.Text");
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // button_query1
            // 
            this.button_query1.BackColor = System.Drawing.Color.DarkOrange;
            this.button_query1.FlatAppearance.BorderSize = 0;
            this.button_query1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_query1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_query1.ForeColor = System.Drawing.Color.White;
            this.button_query1.Location = new System.Drawing.Point(793, 12);
            this.button_query1.Name = "button_query1";
            this.button_query1.Size = new System.Drawing.Size(277, 164);
            this.button_query1.TabIndex = 10;
            this.button_query1.Text = "Excute Query";
            this.button_query1.UseVisualStyleBackColor = false;
            this.button_query1.Click += new System.EventHandler(this.button_query1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 182);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1058, 409);
            this.dataGridView1.TabIndex = 11;
            // 
            // showingList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1082, 603);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_query1);
            this.Controls.Add(this.textBox_query);
            this.Name = "showingList";
            this.Text = "showingList";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_query;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button button_query1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}