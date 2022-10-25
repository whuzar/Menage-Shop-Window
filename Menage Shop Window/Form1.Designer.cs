namespace Menage_Shop_Window
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.name_txt = new System.Windows.Forms.TextBox();
            this.desc_txt = new System.Windows.Forms.TextBox();
            this.cat_txt = new System.Windows.Forms.TextBox();
            this.amount_txt = new System.Windows.Forms.TextBox();
            this.price_txt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.describe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.Insertdata = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Describe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Category";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Amount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Price";
            // 
            // name_txt
            // 
            this.name_txt.Location = new System.Drawing.Point(90, 39);
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(169, 27);
            this.name_txt.TabIndex = 5;
            this.name_txt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // desc_txt
            // 
            this.desc_txt.Location = new System.Drawing.Point(90, 85);
            this.desc_txt.Name = "desc_txt";
            this.desc_txt.Size = new System.Drawing.Size(169, 27);
            this.desc_txt.TabIndex = 6;
            this.desc_txt.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // cat_txt
            // 
            this.cat_txt.Location = new System.Drawing.Point(90, 130);
            this.cat_txt.Name = "cat_txt";
            this.cat_txt.Size = new System.Drawing.Size(169, 27);
            this.cat_txt.TabIndex = 7;
            this.cat_txt.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // amount_txt
            // 
            this.amount_txt.Location = new System.Drawing.Point(90, 168);
            this.amount_txt.Name = "amount_txt";
            this.amount_txt.Size = new System.Drawing.Size(169, 27);
            this.amount_txt.TabIndex = 8;
            this.amount_txt.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // price_txt
            // 
            this.price_txt.Location = new System.Drawing.Point(90, 212);
            this.price_txt.Name = "price_txt";
            this.price_txt.Size = new System.Drawing.Size(169, 27);
            this.price_txt.TabIndex = 9;
            this.price_txt.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.describe,
            this.category,
            this.amount,
            this.price});
            this.dataGridView1.Location = new System.Drawing.Point(285, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(679, 552);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.Width = 125;
            // 
            // describe
            // 
            this.describe.HeaderText = "Describe";
            this.describe.MinimumWidth = 6;
            this.describe.Name = "describe";
            this.describe.Width = 125;
            // 
            // category
            // 
            this.category.HeaderText = "Category";
            this.category.MinimumWidth = 6;
            this.category.Name = "category";
            this.category.Width = 125;
            // 
            // amount
            // 
            this.amount.HeaderText = "Amount";
            this.amount.MinimumWidth = 6;
            this.amount.Name = "amount";
            this.amount.Width = 125;
            // 
            // price
            // 
            this.price.HeaderText = "Price";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            this.price.Width = 125;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 29);
            this.button1.TabIndex = 11;
            this.button1.Text = "By Category";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Insertdata
            // 
            this.Insertdata.Location = new System.Drawing.Point(12, 332);
            this.Insertdata.Name = "Insertdata";
            this.Insertdata.Size = new System.Drawing.Size(114, 29);
            this.Insertdata.TabIndex = 12;
            this.Insertdata.Text = "Add";
            this.Insertdata.UseVisualStyleBackColor = true;
            this.Insertdata.Click += new System.EventHandler(this.button2_Click);
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(12, 386);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(114, 29);
            this.edit.TabIndex = 13;
            this.edit.Text = "Edit";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 440);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(114, 29);
            this.button4.TabIndex = 14;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 603);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.Insertdata);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.price_txt);
            this.Controls.Add(this.amount_txt);
            this.Controls.Add(this.cat_txt);
            this.Controls.Add(this.desc_txt);
            this.Controls.Add(this.name_txt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox name_txt;
        private TextBox desc_txt;
        private TextBox cat_txt;
        private TextBox amount_txt;
        private TextBox price_txt;
        private DataGridView dataGridView1;
        private Button button1;
        private Button Insertdata;
        private Button edit;
        private Button button4;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn describe;
        private DataGridViewTextBoxColumn category;
        private DataGridViewTextBoxColumn amount;
        private DataGridViewTextBoxColumn price;
    }
}