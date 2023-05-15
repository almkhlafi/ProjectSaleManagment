using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Revision
{
    public partial class ADDPRODUCTFORM : Form
    {
        string Path = "Data Source=ABDULRAHMAN\\SQLEXPRESS;Initial Catalog=RegistrationInfo;Integrated Security=True";
        SqlConnection con;
        SqlCommand cmd; // as below It can be 
        DataTable dt; //Or I can Use  DataTable dt=new DataTable();
        SqlDataAdapter adpt;
        string productDes;
        int proAmount = 0;
        Image img;
      

        public ADDPRODUCTFORM()
        {
            InitializeComponent();
            con = new SqlConnection(Path);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            Main frm = new Main();
            frm.Show();
            this.Close();

        }

        private void Addproduct_Click(object sender, EventArgs e)
        {
            
            try
            {
                con.Open();
                cmd = new SqlCommand("INSERT INTO ProductInfo (ProductImage, ProductPrice, ProductDescription,Category) VALUES (@ProductImage, @ProductPrice, @ProductDescription,@Category)", con);
                cmd.Parameters.AddWithValue("@ProductImage", getPhoto());
                cmd.Parameters.AddWithValue("@ProductPrice", Price.Text);
                cmd.Parameters.AddWithValue("@Category", Category.Text);
                cmd.Parameters.AddWithValue("@ProductDescription", Productdescription.Text.ToString());
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Product added successfully!");
               // clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //convert Image to Byte array because database does not allows direct image saving unless it's converted to byte
        private byte[] getPhoto()
        {
            using (MemoryStream memoryStream = new MemoryStream())
            {
                productPic.Image.Save(memoryStream, productPic.Image.RawFormat);
                return memoryStream.ToArray();
            }
        }

        private void productPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                productPic.Image = new Bitmap(fileDialog.FileName);
            }
        }
        public void clear()
        {    
            Amount.Text = "0$";
            Price.Text = "0$";
            Productdescription.Text = "Enter Product Description....";
            Image defaultBackground = null;

            productPic.BackgroundImage = defaultBackground;

        }

        private void ClearProInof_Click(object sender, EventArgs e)
        {
           clear();


        }

        private void Form2_Load(object sender, EventArgs e)
        {
            clear();
        }

        private void MainForm_Click(object sender, EventArgs e)
        {
            MainForm Mf= new MainForm();    
            Mf.Show();
            this.Dispose();

        }
    }
}
