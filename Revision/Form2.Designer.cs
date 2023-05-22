namespace Revision
{
    partial class ADDPRODUCTFORM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ADDPRODUCTFORM));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtAddCategory = new System.Windows.Forms.Button();
            this.LoadCategories = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.AddCategory = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.no = new System.Windows.Forms.Label();
            this.SupplierID = new System.Windows.Forms.TextBox();
            this.MainForm = new System.Windows.Forms.Button();
            this.ClearProInof = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.Price = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Amount = new System.Windows.Forms.TextBox();
            this.Productdescription = new System.Windows.Forms.TextBox();
            this.Addproduct = new System.Windows.Forms.Button();
            this.productPic = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.SearchMain = new System.Windows.Forms.TextBox();
            this.datagradInform = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productPic)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagradInform)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtAddCategory);
            this.groupBox1.Controls.Add(this.LoadCategories);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.AddCategory);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.no);
            this.groupBox1.Controls.Add(this.SupplierID);
            this.groupBox1.Controls.Add(this.MainForm);
            this.groupBox1.Controls.Add(this.ClearProInof);
            this.groupBox1.Controls.Add(this.back);
            this.groupBox1.Controls.Add(this.Price);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Amount);
            this.groupBox1.Controls.Add(this.Productdescription);
            this.groupBox1.Controls.Add(this.Addproduct);
            this.groupBox1.Controls.Add(this.productPic);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Black", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(500, 580);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add New Product";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // BtAddCategory
            // 
            this.BtAddCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtAddCategory.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtAddCategory.ForeColor = System.Drawing.Color.Transparent;
            this.BtAddCategory.Location = new System.Drawing.Point(275, 52);
            this.BtAddCategory.Name = "BtAddCategory";
            this.BtAddCategory.Size = new System.Drawing.Size(69, 31);
            this.BtAddCategory.TabIndex = 24;
            this.BtAddCategory.Text = "ADD";
            this.BtAddCategory.UseVisualStyleBackColor = false;
            this.BtAddCategory.Click += new System.EventHandler(this.button2_Click);
            // 
            // LoadCategories
            // 
            this.LoadCategories.FormattingEnabled = true;
            this.LoadCategories.Location = new System.Drawing.Point(235, 207);
            this.LoadCategories.Name = "LoadCategories";
            this.LoadCategories.Size = new System.Drawing.Size(248, 33);
            this.LoadCategories.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(237, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Product Category :";
            // 
            // AddCategory
            // 
            this.AddCategory.Location = new System.Drawing.Point(25, 52);
            this.AddCategory.Name = "AddCategory";
            this.AddCategory.Size = new System.Drawing.Size(319, 31);
            this.AddCategory.TabIndex = 18;
            this.AddCategory.TextChanged += new System.EventHandler(this.Category_TextChanged_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(28, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Add New Category :";
            // 
            // no
            // 
            this.no.AutoSize = true;
            this.no.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.no.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.no.Location = new System.Drawing.Point(237, 110);
            this.no.Name = "no";
            this.no.Size = new System.Drawing.Size(82, 20);
            this.no.TabIndex = 16;
            this.no.Text = "SupplierID";
            this.no.Click += new System.EventHandler(this.label5_Click);
            // 
            // SupplierID
            // 
            this.SupplierID.Location = new System.Drawing.Point(237, 141);
            this.SupplierID.Name = "SupplierID";
            this.SupplierID.Size = new System.Drawing.Size(81, 31);
            this.SupplierID.TabIndex = 15;
            this.SupplierID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // MainForm
            // 
            this.MainForm.BackColor = System.Drawing.Color.PaleVioletRed;
            this.MainForm.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MainForm.Location = new System.Drawing.Point(26, 486);
            this.MainForm.Name = "MainForm";
            this.MainForm.Size = new System.Drawing.Size(459, 38);
            this.MainForm.TabIndex = 12;
            this.MainForm.Text = "All Product ";
            this.MainForm.UseVisualStyleBackColor = false;
            this.MainForm.Click += new System.EventHandler(this.MainForm_Click);
            // 
            // ClearProInof
            // 
            this.ClearProInof.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClearProInof.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ClearProInof.Location = new System.Drawing.Point(237, 404);
            this.ClearProInof.Name = "ClearProInof";
            this.ClearProInof.Size = new System.Drawing.Size(245, 36);
            this.ClearProInof.TabIndex = 11;
            this.ClearProInof.Text = "Clear";
            this.ClearProInof.UseVisualStyleBackColor = false;
            this.ClearProInof.Click += new System.EventHandler(this.ClearProInof_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.CadetBlue;
            this.back.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.back.Location = new System.Drawing.Point(29, 530);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(456, 38);
            this.back.TabIndex = 10;
            this.back.Text = "Main Form";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // Price
            // 
            this.Price.Location = new System.Drawing.Point(414, 141);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(68, 31);
            this.Price.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(414, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Price :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(237, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Description :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(337, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Amount :";
            // 
            // Amount
            // 
            this.Amount.Location = new System.Drawing.Point(333, 141);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(77, 31);
            this.Amount.TabIndex = 5;
            // 
            // Productdescription
            // 
            this.Productdescription.Location = new System.Drawing.Point(237, 268);
            this.Productdescription.Multiline = true;
            this.Productdescription.Name = "Productdescription";
            this.Productdescription.Size = new System.Drawing.Size(245, 89);
            this.Productdescription.TabIndex = 4;
            // 
            // Addproduct
            // 
            this.Addproduct.BackColor = System.Drawing.Color.Coral;
            this.Addproduct.Location = new System.Drawing.Point(237, 360);
            this.Addproduct.Name = "Addproduct";
            this.Addproduct.Size = new System.Drawing.Size(245, 38);
            this.Addproduct.TabIndex = 3;
            this.Addproduct.Text = "Add Product";
            this.Addproduct.UseVisualStyleBackColor = false;
            this.Addproduct.Click += new System.EventHandler(this.Addproduct_Click);
            // 
            // productPic
            // 
            this.productPic.Image = global::Revision.Properties.Resources._default;
            this.productPic.Location = new System.Drawing.Point(26, 113);
            this.productPic.Name = "productPic";
            this.productPic.Size = new System.Drawing.Size(205, 327);
            this.productPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.productPic.TabIndex = 2;
            this.productPic.TabStop = false;
            this.productPic.Click += new System.EventHandler(this.productPic_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.pictureBox10);
            this.groupBox2.Controls.Add(this.SearchMain);
            this.groupBox2.Controls.Add(this.datagradInform);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.groupBox2.ForeColor = System.Drawing.Color.Tomato;
            this.groupBox2.Location = new System.Drawing.Point(543, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(926, 571);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Supplier Information";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(10, 547);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Add New  Supplier";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(6, 492);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 52);
            this.button1.TabIndex = 17;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox10.InitialImage")));
            this.pictureBox10.Location = new System.Drawing.Point(691, 33);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(38, 41);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 23;
            this.pictureBox10.TabStop = false;
            // 
            // SearchMain
            // 
            this.SearchMain.Location = new System.Drawing.Point(127, 33);
            this.SearchMain.Multiline = true;
            this.SearchMain.Name = "SearchMain";
            this.SearchMain.Size = new System.Drawing.Size(602, 41);
            this.SearchMain.TabIndex = 22;
            this.SearchMain.TextChanged += new System.EventHandler(this.SearchMain_TextChanged);
            // 
            // datagradInform
            // 
            this.datagradInform.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagradInform.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagradInform.Location = new System.Drawing.Point(10, 80);
            this.datagradInform.Name = "datagradInform";
            this.datagradInform.RowHeadersWidth = 51;
            this.datagradInform.RowTemplate.Height = 29;
            this.datagradInform.Size = new System.Drawing.Size(910, 406);
            this.datagradInform.TabIndex = 21;
            this.datagradInform.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.datagradInform_CellMouseClick);
            // 
            // ADDPRODUCTFORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1481, 732);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ADDPRODUCTFORM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add new Product";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productPic)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagradInform)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private TextBox Price;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox Amount;
        private TextBox description;
        private Button Addproduct;
        private PictureBox productPic;
        private Button back;
        private Button ClearProInof;
        private TextBox Productdescription;
        private Button MainForm;
        private GroupBox groupBox2;
        private DataGridView datagradInform;
        private Label no;
        private TextBox SupplierID;
        private PictureBox pictureBox10;
        private TextBox SearchMain;
        private Label label5;
        private Button button1;
        private ComboBox LoadCategories;
        private Label label6;
        private TextBox AddCategory;
        private Label label4;
        private Button button2;
        private Button BtAddCategory;
    }
}