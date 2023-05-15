using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Revision
{
    public partial class MainForm : Form
    {
        string Path = "Data Source=ABDULRAHMAN\\SQLEXPRESS;Initial Catalog=RegistrationInfo;Integrated Security=True";
        SqlConnection con;
        SqlCommand cmd;
        List<Product_control> products;
        List<ListProducts> productlist;
        int count = 0;
        SqlDataAdapter adpt;
        public MainForm()
        {
            InitializeComponent();
            con = new SqlConnection(Path);
        }

        public void LoadProduct()
        {
            products = new List<Product_control>();

            using (SqlConnection con = new SqlConnection(Path))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT ProductImage, ProductPrice, ProductDescription ,Amount FROM ProductInfo", con);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    byte[] imageData = (byte[])reader["ProductImage"];
                    Image image = GetImageFromByteArray(imageData);
                    string price = reader["ProductPrice"].ToString();
                    string amount = reader["Amount"].ToString();
                    string description = reader["ProductDescription"].ToString();

                    Product_control product = new Product_control()
                    {
                        productimage = image,
                        price = price,
                        amount = amount,
                        description = description
                    };
                    products.Add(product);
                    count++;
                }

                con.Close();

            }

            foreach (Product_control product in products)
            {
                flowLayoutPanel1.Controls.Add(product);
            }

        }


        private Image GetImageFromByteArray(byte[] bytes)
        {
            using (MemoryStream memoryStream = new MemoryStream(bytes))
            {
                Image image = Image.FromStream(memoryStream);
                return new Bitmap(image);
                // Create a new Bitmap to ensure the original image is not locked in memory
            }
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            if (count == 0)
            {
                LoadProduct();
                ListProduct();
            }
            else MessageBox.Show("All Data was loaded");
        }

        private void load_Click(object sender, EventArgs e)
        {
            if (count == 0)
                LoadProduct();
            else MessageBox.Show("All Data was loaded");

        }

        private void Addproduct_Click(object sender, EventArgs e)
        {
            ADDPRODUCTFORM form2 = new ADDPRODUCTFORM();
            form2.Show();
            this.Dispose();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {
            LoadProduct();
        }

        public void ListProduct()
        {
            productlist = new List<ListProducts>();

            using (SqlConnection con = new SqlConnection(Path))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT ProductImage, ProductPrice, ProductDescription,Amount FROM ProductInfo", con);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    byte[] imageData = (byte[])reader["ProductImage"];
                    Image image = GetImageFromByteArray(imageData);
                    string price = reader["ProductPrice"].ToString();
                    string amount = reader["Amount"].ToString();
                    string description = reader["ProductDescription"].ToString();

                    ListProducts product = new ListProducts()
                    {
                        productimage = image,
                        price = price,
                        amount = amount,
                        description = description
                    };
                    productlist.Add(product);
                    count++;
                }

                con.Close();

            }
            foreach (ListProducts product in productlist)
            {
                flowLayoutPanel2.Controls.Add(product);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string searchText = SearchList.Text.Trim();

            try
            {
                using (SqlConnection con = new SqlConnection(Path))
                {
                    con.Open();

                    if (!string.IsNullOrEmpty(searchText))
                    {
                        SqlCommand cmd = new SqlCommand("SELECT ProductImage, ProductPrice, ProductDescription, Amount FROM ProductInfo WHERE ProductDescription LIKE '%' + @SearchText + '%'", con);
                        cmd.Parameters.AddWithValue("@SearchText", searchText);

                        SqlDataReader reader = cmd.ExecuteReader();

                        List<ListProducts> filteredProducts = new List<ListProducts>();

                        while (reader.Read())
                        {
                            byte[] imageData = (byte[])reader["ProductImage"];
                            Image image = GetImageFromByteArray(imageData);
                            string price = reader["ProductPrice"].ToString();
                            string description = reader["ProductDescription"].ToString();

                            ListProducts product = new ListProducts()
                            {
                                productimage = image,
                                price = price,
                                description = description
                            };

                            filteredProducts.Add(product);
                        }

                        reader.Close();

                        // Clear previous products from the flowLayoutPanel2
                        flowLayoutPanel2.Controls.Clear();

                        foreach (ListProducts product in filteredProducts)
                        {
                            flowLayoutPanel2.Controls.Add(product);
                        }
                    }
                    else
                    {
                        // If the search text is empty, display all products
                        ListProduct();
                    }

                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
           
                string searchText = SearchMain.Text.Trim();

                try
                {
                    using (SqlConnection con = new SqlConnection(Path))
                    {
                        con.Open();

                        if (!string.IsNullOrEmpty(searchText))
                        {
                            SqlCommand cmd = new SqlCommand("SELECT ProductImage, ProductPrice, ProductDescription, Amount FROM ProductInfo WHERE ProductDescription LIKE '%' + @SearchText + '%'", con);
                            cmd.Parameters.AddWithValue("@SearchText", searchText);

                            SqlDataReader reader = cmd.ExecuteReader();

                            List<Product_control> filteredProducts = new List<Product_control>();

                            while (reader.Read())
                            {
                                byte[] imageData = (byte[])reader["ProductImage"];
                                Image image = GetImageFromByteArray(imageData);
                                string amount = reader["Amount"].ToString();
                                string price = reader["ProductPrice"].ToString();
                                string description = reader["ProductDescription"].ToString();

                            Product_control product = new Product_control()
                                {
                                    productimage = image,
                                    price = price,
                                    amount=amount,
                                    description = description
                                };

                                filteredProducts.Add(product);
                            }

                            reader.Close();

                            // Clear previous products from the flowLayoutPanel2
                            flowLayoutPanel1.Controls.Clear();

                            foreach (Product_control product in filteredProducts)
                            {
                                flowLayoutPanel1.Controls.Add(product);
                            }
                        }
                        else
                        {
                            // If the search text is empty, display all products
                            ListProduct();
                        }

                        con.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
    
    }


