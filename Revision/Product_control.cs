using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Revision
{
    public partial class Product_control : UserControl
    {
        public Product_control()
        {
            InitializeComponent();
        }

        public string price
        {
            get=>Price.Text;
            set=> Price.Text=value+" $ ";
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


        private void Product_control_Load(object sender, EventArgs e)
        {

        }
    }
}
