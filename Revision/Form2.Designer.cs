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
            this.Category = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
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
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productPic)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Category);
            this.groupBox1.Controls.Add(this.label4);
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
            this.groupBox1.Size = new System.Drawing.Size(500, 482);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add New Product";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Category
            // 
            this.Category.Location = new System.Drawing.Point(231, 137);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(220, 31);
            this.Category.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(231, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Category :";
            // 
            // MainForm
            // 
            this.MainForm.BackColor = System.Drawing.Color.PaleVioletRed;
            this.MainForm.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MainForm.Location = new System.Drawing.Point(17, 392);
            this.MainForm.Name = "MainForm";
            this.MainForm.Size = new System.Drawing.Size(434, 38);
            this.MainForm.TabIndex = 12;
            this.MainForm.Text = "All Product ";
            this.MainForm.UseVisualStyleBackColor = false;
            this.MainForm.Click += new System.EventHandler(this.MainForm_Click);
            // 
            // ClearProInof
            // 
            this.ClearProInof.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClearProInof.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ClearProInof.Location = new System.Drawing.Point(231, 328);
            this.ClearProInof.Name = "ClearProInof";
            this.ClearProInof.Size = new System.Drawing.Size(220, 36);
            this.ClearProInof.TabIndex = 11;
            this.ClearProInof.Text = "Clear";
            this.ClearProInof.UseVisualStyleBackColor = false;
            this.ClearProInof.Click += new System.EventHandler(this.ClearProInof_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.CadetBlue;
            this.back.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.back.Location = new System.Drawing.Point(20, 436);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(431, 38);
            this.back.TabIndex = 10;
            this.back.Text = "Main Form";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // Price
            // 
            this.Price.Location = new System.Drawing.Point(334, 69);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(117, 31);
            this.Price.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(334, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Price :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(231, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Description :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(231, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Amount :";
            // 
            // Amount
            // 
            this.Amount.Location = new System.Drawing.Point(231, 69);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(97, 31);
            this.Amount.TabIndex = 5;
            // 
            // Productdescription
            // 
            this.Productdescription.Location = new System.Drawing.Point(231, 192);
            this.Productdescription.Multiline = true;
            this.Productdescription.Name = "Productdescription";
            this.Productdescription.Size = new System.Drawing.Size(220, 89);
            this.Productdescription.TabIndex = 4;
            // 
            // Addproduct
            // 
            this.Addproduct.BackColor = System.Drawing.Color.Coral;
            this.Addproduct.Location = new System.Drawing.Point(231, 284);
            this.Addproduct.Name = "Addproduct";
            this.Addproduct.Size = new System.Drawing.Size(220, 38);
            this.Addproduct.TabIndex = 3;
            this.Addproduct.Text = "Add Product";
            this.Addproduct.UseVisualStyleBackColor = false;
            this.Addproduct.Click += new System.EventHandler(this.Addproduct_Click);
            // 
            // productPic
            // 
            this.productPic.Image = global::Revision.Properties.Resources._default;
            this.productPic.Location = new System.Drawing.Point(20, 37);
            this.productPic.Name = "productPic";
            this.productPic.Size = new System.Drawing.Size(205, 327);
            this.productPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.productPic.TabIndex = 2;
            this.productPic.TabStop = false;
            this.productPic.Click += new System.EventHandler(this.productPic_Click);
            // 
            // ADDPRODUCTFORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 506);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ADDPRODUCTFORM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add new Product";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productPic)).EndInit();
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
        private Button button1;
        private Button ClearProInof;
        private TextBox Productdescription;
        private Button MainForm;
        private TextBox Category;
        private Label label4;
    }
}