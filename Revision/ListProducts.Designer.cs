namespace Revision
{
    partial class ListProducts
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.productImage = new System.Windows.Forms.PictureBox();
            this.Amount = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productImage)).BeginInit();
            this.SuspendLayout();
            // 
            // productImage
            // 
            this.productImage.Location = new System.Drawing.Point(14, 3);
            this.productImage.Name = "productImage";
            this.productImage.Size = new System.Drawing.Size(110, 120);
            this.productImage.TabIndex = 0;
            this.productImage.TabStop = false;
            // 
            // Amount
            // 
            this.Amount.AutoSize = true;
            this.Amount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Amount.Location = new System.Drawing.Point(152, 79);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(75, 20);
            this.Amount.TabIndex = 2;
            this.Amount.Text = "Amount :";
            this.Amount.MouseEnter += new System.EventHandler(this.ListProducts_MouseEnter);
            this.Amount.MouseHover += new System.EventHandler(this.ListProducts_MouseHover);
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Price.Location = new System.Drawing.Point(291, 79);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(51, 20);
            this.Price.TabIndex = 3;
            this.Price.Text = "Price :";
            this.Price.MouseEnter += new System.EventHandler(this.ListProducts_MouseEnter);
            this.Price.MouseHover += new System.EventHandler(this.ListProducts_MouseHover);
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Description.Location = new System.Drawing.Point(140, 17);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(0, 20);
            this.Description.TabIndex = 4;
            // 
            // ListProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.Description);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.Amount);
            this.Controls.Add(this.productImage);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "ListProducts";
            this.Size = new System.Drawing.Size(413, 135);
            this.MouseEnter += new System.EventHandler(this.ListProducts_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.ListProducts_MouseLeave);
            this.MouseHover += new System.EventHandler(this.ListProducts_MouseHover);
            ((System.ComponentModel.ISupportInitialize)(this.productImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox productImage;
        private Label Amount;
        private Label Price;
        private Label Description;
    }
}
