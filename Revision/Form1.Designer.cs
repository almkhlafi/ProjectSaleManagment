namespace Revision
{
    partial class Main
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
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.fName = new System.Windows.Forms.TextBox();
            this.ADD = new System.Windows.Forms.Button();
            this.datagradInform = new System.Windows.Forms.DataGridView();
            this.UPDATE = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.s = new System.Windows.Forms.Label();
            this.phoneNumber = new System.Windows.Forms.TextBox();
            this.Address = new System.Windows.Forms.TextBox();
            this.btAddProduct = new System.Windows.Forms.Button();
            this.loadproduct = new System.Windows.Forms.Button();
            this.ProviderID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.DELETE = new System.Windows.Forms.Button();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datagradInform)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.BlueViolet;
            label1.Location = new System.Drawing.Point(16, 30);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(244, 35);
            label1.TabIndex = 1;
            label1.Text = "Add New Supplier :";
            // 
            // fName
            // 
            this.fName.Location = new System.Drawing.Point(172, 166);
            this.fName.Multiline = true;
            this.fName.Name = "fName";
            this.fName.Size = new System.Drawing.Size(275, 34);
            this.fName.TabIndex = 11;
            // 
            // ADD
            // 
            this.ADD.BackColor = System.Drawing.Color.LimeGreen;
            this.ADD.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ADD.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ADD.Location = new System.Drawing.Point(11, 491);
            this.ADD.Name = "ADD";
            this.ADD.Size = new System.Drawing.Size(165, 48);
            this.ADD.TabIndex = 19;
            this.ADD.Text = "ADD";
            this.ADD.UseVisualStyleBackColor = false;
            this.ADD.Click += new System.EventHandler(this.bConfirm_Click);
            // 
            // datagradInform
            // 
            this.datagradInform.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagradInform.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.datagradInform.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagradInform.Location = new System.Drawing.Point(660, 0);
            this.datagradInform.Name = "datagradInform";
            this.datagradInform.RowHeadersWidth = 51;
            this.datagradInform.RowTemplate.Height = 29;
            this.datagradInform.Size = new System.Drawing.Size(806, 607);
            this.datagradInform.TabIndex = 20;
            this.datagradInform.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagradInform_CellClick);
            // 
            // UPDATE
            // 
            this.UPDATE.BackColor = System.Drawing.Color.Gray;
            this.UPDATE.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UPDATE.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UPDATE.Location = new System.Drawing.Point(213, 491);
            this.UPDATE.Name = "UPDATE";
            this.UPDATE.Size = new System.Drawing.Size(184, 48);
            this.UPDATE.TabIndex = 26;
            this.UPDATE.Text = "UPDATE";
            this.UPDATE.UseVisualStyleBackColor = false;
            this.UPDATE.Click += new System.EventHandler(this.update_Click);
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.SystemColors.Info;
            this.Search.Location = new System.Drawing.Point(147, 85);
            this.Search.Multiline = true;
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(331, 41);
            this.Search.TabIndex = 29;
            this.Search.TextChanged += new System.EventHandler(this.Search_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(42, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Phone Number:";
            // 
            // s
            // 
            this.s.AutoSize = true;
            this.s.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.s.Location = new System.Drawing.Point(82, 278);
            this.s.Name = "s";
            this.s.Size = new System.Drawing.Size(74, 20);
            this.s.TabIndex = 8;
            this.s.Text = "Address :";
            // 
            // phoneNumber
            // 
            this.phoneNumber.Location = new System.Drawing.Point(168, 223);
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.Size = new System.Drawing.Size(279, 27);
            this.phoneNumber.TabIndex = 17;
            // 
            // Address
            // 
            this.Address.Location = new System.Drawing.Point(172, 275);
            this.Address.Multiline = true;
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(275, 113);
            this.Address.TabIndex = 30;
            // 
            // btAddProduct
            // 
            this.btAddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btAddProduct.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btAddProduct.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btAddProduct.Location = new System.Drawing.Point(212, 563);
            this.btAddProduct.Name = "btAddProduct";
            this.btAddProduct.Size = new System.Drawing.Size(426, 48);
            this.btAddProduct.TabIndex = 31;
            this.btAddProduct.Text = "Product Add";
            this.btAddProduct.UseVisualStyleBackColor = false;
            this.btAddProduct.Click += new System.EventHandler(this.btAddProduct_Click);
            // 
            // loadproduct
            // 
            this.loadproduct.BackColor = System.Drawing.Color.DodgerBlue;
            this.loadproduct.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loadproduct.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loadproduct.Location = new System.Drawing.Point(16, 563);
            this.loadproduct.Name = "loadproduct";
            this.loadproduct.Size = new System.Drawing.Size(173, 48);
            this.loadproduct.TabIndex = 32;
            this.loadproduct.Text = "Main Point";
            this.loadproduct.UseVisualStyleBackColor = false;
            this.loadproduct.Click += new System.EventHandler(this.loadproduct_Click);
            // 
            // ProviderID
            // 
            this.ProviderID.Location = new System.Drawing.Point(503, 163);
            this.ProviderID.Multiline = true;
            this.ProviderID.Name = "ProviderID";
            this.ProviderID.Size = new System.Drawing.Size(78, 34);
            this.ProviderID.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(79, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "First Name :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(459, 169);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 20);
            this.label9.TabIndex = 34;
            this.label9.Text = "ID :";
            // 
            // DELETE
            // 
            this.DELETE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DELETE.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DELETE.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DELETE.Location = new System.Drawing.Point(454, 491);
            this.DELETE.Name = "DELETE";
            this.DELETE.Size = new System.Drawing.Size(184, 48);
            this.DELETE.TabIndex = 27;
            this.DELETE.Text = "DELETE";
            this.DELETE.UseVisualStyleBackColor = false;
            this.DELETE.Click += new System.EventHandler(this.DELETE_Click);
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.SystemColors.Info;
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox10.InitialImage")));
            this.pictureBox10.Location = new System.Drawing.Point(440, 85);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(38, 41);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 35;
            this.pictureBox10.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1470, 615);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ProviderID);
            this.Controls.Add(this.loadproduct);
            this.Controls.Add(this.btAddProduct);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.DELETE);
            this.Controls.Add(this.UPDATE);
            this.Controls.Add(this.datagradInform);
            this.Controls.Add(this.ADD);
            this.Controls.Add(this.phoneNumber);
            this.Controls.Add(this.fName);
            this.Controls.Add(this.s);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(label1);
            this.Name = "Main";
            this.Text = "Revision";
            this.Load += new System.EventHandler(this.Main_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Main_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.datagradInform)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label7;
        private Label s;
        private TextBox fName;
        private TextBox lName;
        private TextBox Password;
        private RadioButton Male;
        private RadioButton Female;
        private TextBox phoneNumber;
        private TextBox Address;
        private Button ADD;
        private DataGridView datagradInform;
        private ComboBox combo;
        private CheckBox gym;
        private CheckBox code;
        private Label country;
        private Label label8;
        private Button UPDATE;
        private TextBox ID;
        private TextBox Search;
        private TextBox textBox1;
        private Button btAddProduct;
        private Button loadproduct;
        private TextBox ProviderID;
        private Label label2;
        private Label label9;
        private Button DELETE;
        private PictureBox pictureBox10;
    }
}