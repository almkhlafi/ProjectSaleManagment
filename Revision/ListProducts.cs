using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Revision
{
    public partial class ListProducts : UserControl
    {
        public ListProducts()
        {
            InitializeComponent();
        }

        public string price
        {
            get => Price.Text;
            set => Price.Text = value + " $";
        }
        public string amount
        {
            get => Amount.Text;
            set => Amount.Text = value;

        }
        public string description
        {
            get => Description.Text;
            set => Description.Text = value;
        }
        public Image productimage
        {
            get => productImage.BackgroundImage;
            set
            {
                productImage.BackgroundImage = value;
                productImage.BackgroundImageLayout = ImageLayout.Stretch; // Set SizeMode to Stretch
            }
        }

        private void ListProducts_MouseHover(object sender, EventArgs e)
        {

            
        }

        private void ListProducts_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(250, 249, 250);
        }

        private void ListProducts_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }







        //All below code to make the list product has radius 
        private int cornerRadius = 10; // Adjust the corner radius as desired

        public int CornerRadius
        {
            get { return cornerRadius; }
            set { cornerRadius = value; Invalidate(); }
        }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        // Create a GraphicsPath with rounded corners
        GraphicsPath path = new GraphicsPath();
        Rectangle bounds = new Rectangle(0, 0, Width - 1, Height - 1);
        int diameter = 2 * cornerRadius;
        Size size = new Size(diameter, diameter);
        Rectangle arcRect;

        // Top-left corner
        arcRect = new Rectangle(bounds.Location, size);
        path.AddArc(arcRect, 180, 90);

        // Top-right corner
        arcRect.X = bounds.Right - diameter;
        path.AddArc(arcRect, 270, 90);

        // Bottom-right corner
        arcRect.Y = bounds.Bottom - diameter;
        path.AddArc(arcRect, 0, 90);

        // Bottom-left corner
        arcRect.X = bounds.Left;
        path.AddArc(arcRect, 90, 90);

        path.CloseFigure();

        // Set the region of the control to the rounded path
        Region = new Region(path);

        // Draw the control
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
        e.Graphics.FillPath(new SolidBrush(BackColor), path);
        e.Graphics.DrawPath(new Pen(ForeColor), path);
    }

    }
}
