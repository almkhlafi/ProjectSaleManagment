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
//using MySql.Data.MySqlClient;


using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Revision
{
    public partial class MainForm : Form
    {

string Path = "Data Source=ABDULRAHMAN\\SQLEXPRESS;Initial Catalog=SaleManagementSystem;Integrated Security=True";
       // string Path = "server=localhost;uid=root;pwd=root;database=storandsalesmanagementsystem";
        SqlConnection con;
        SqlCommand cmd;
        List<Product_control> products;
        List<ListProducts> productlist;
        int count = 0;
   
      //  MySqlDataAdapter adpt;
       // MySqlConnection con;
       // MySqlCommand cmd;
        public MainForm()
        {
            InitializeComponent();
            con = new SqlConnection(Path);
            SubscribeToProductClickedEvents();
        }

        private void SubscribeToProductClickedEvents()
        {
            foreach (Product_control productControl in flowLayoutPanel1.Controls.OfType<Product_control>())
            {
                productControl.ProductClicked += ProductControl_ProductClicked;
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
                LoadProduct("Pr_GetAllProducts", ProductControl_ProductClicked);


                // ListProduct("Pr_GetAllProducts");
            }
            else MessageBox.Show("All Data was loaded");
        }

        private void Addproduct_Click(object sender, EventArgs e)
        {
            ADDPRODUCTFORM form2 = new ADDPRODUCTFORM();
            form2.Show();
            this.Dispose();
        }

        //--------------------Search----------------------

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
                        SqlCommand cmd = new SqlCommand("SELECT Product_Pic, Price, Product_Description, Quantity FROM ProductInventory WHERE Product_Description LIKE '%' + @SearchText + '%'", con);
                        cmd.Parameters.AddWithValue("@SearchText", searchText);

                        SqlDataReader reader = cmd.ExecuteReader();

                        List<ListProducts> filteredProducts = new List<ListProducts>();

                        while (reader.Read())
                        {
                            byte[] imageData = (byte[])reader["Product_Pic"];
                            Image image = GetImageFromByteArray(imageData);
                            string price = reader["Price"].ToString();
                            string description = reader["Product_Description"].ToString();

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
                        ClearProducts(flowLayoutPanel2);
                       // ListProduct("Pr_GetAllProducts");
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
                        SqlCommand cmd = new SqlCommand("SELECT Product_Pic, Price, Product_Description, Quantity FROM ProductInventory WHERE Product_Description LIKE '%' + @SearchText + '%'", con);
                        cmd.Parameters.AddWithValue("@SearchText", searchText);

                        SqlDataReader reader = cmd.ExecuteReader();

                        List<Product_control> filteredProducts = new List<Product_control>();

                        while (reader.Read())
                        {
                            byte[] imageData = (byte[])reader["Product_Pic"];
                            Image image = GetImageFromByteArray(imageData);
                            string amount = reader["Quantity"].ToString();
                            string price = reader["Price"].ToString();
                            string description = reader["Product_Description"].ToString();

                            Product_control product = new Product_control()
                            {
                                productimage = image,
                                price = price,
                                amount = amount,
                                description = description
                            };

                            filteredProducts.Add(product);
                        }

                        reader.Close();

                        // Clear previous products from the flowLayoutPanel1
                        flowLayoutPanel1.Controls.Clear();

                        foreach (Product_control product in filteredProducts)
                        {
                            flowLayoutPanel1.Controls.Add(product);
                        }
                    }
                    else
                    {
                        // If the search text is empty, display all products
                        ClearProducts(flowLayoutPanel1);


                        LoadProduct("Pr_GetAllProducts", ProductControl_ProductClicked);


                    }

                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //--------------------Clear Code----------------------

        private void ClearProducts(Control container)
        {
            // Clear all child controls from the container
            foreach (Control control in container.Controls)
            {
                control.Dispose();
            }

            container.Controls.Clear();
        }

        //--------------------CalculateTotalPrice----------------------

        private float CalculateTotalPrice()
        {
            float totalPrice = 0;

            foreach (ListProducts listProduct in flowLayoutPanel2.Controls)
            {
                if (float.TryParse(listProduct.price, out float productPrice) && int.TryParse(listProduct.amount, out int productQuantity))
                {
                    totalPrice += productPrice * productQuantity;
                }
                else
                {
                    // Parsing failed for price or quantity, handle the error
                    // For example, display an error message or log the error
                    // You can also choose to skip the product or take alternative action
                    MessageBox.Show($"Invalid price or quantity for product: {listProduct.description}");
                }
            }
           Total.Text = totalPrice.ToString()+"";
            return totalPrice;
        }

        //--------------------List Categories Products----------------------
        /* public void LoadProduct(string passProcedure)
         {
             products = new List<Product_control>();

             using (SqlConnection con = new SqlConnection(Path))
             {
                 con.Open();
                 SqlCommand cmd = new SqlCommand(passProcedure, con);
                 cmd.CommandType = CommandType.StoredProcedure;
                 SqlDataReader reader = cmd.ExecuteReader();

                 while (reader.Read())
                 {
                     byte[] imageData = (byte[])reader["Product_Pic"];
                     Image image = GetImageFromByteArray(imageData);
                     string price = reader["Price"].ToString();
                     string amount = reader["Quantity"].ToString();
                     string description = reader["Product_Description"].ToString();

                     Product_control product = new Product_control()
                     {
                         productimage = image,
                         price = price,
                         amount = amount,
                         description = description,

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

             float totalPrice = CalculateTotalPrice();
             // Now you can use the totalPrice variable as needed, such as displaying it on the UI
             Total.Text = totalPrice.ToString();
         }
         public void ListProduct(string passProcedure)
         {
             productlist = new List<ListProducts>();

             using (SqlConnection con = new SqlConnection(Path))
             {
                 con.Open();
                 SqlCommand cmd = new SqlCommand(passProcedure, con);
                 cmd.CommandType = CommandType.StoredProcedure;
                 SqlDataReader reader = cmd.ExecuteReader();

                 while (reader.Read())
                 {
                     byte[] imageData = (byte[])reader["Product_Pic"];
                     Image image = GetImageFromByteArray(imageData);
                     string price = reader["Price"].ToString();
                     string amount = reader["Quantity"].ToString();
                     string description = reader["Product_Description"].ToString();

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

             float totalPrice = CalculateTotalPrice();
             // Now you can use the totalPrice variable as needed, such as displaying it on the UI
             Total.Text = totalPrice.ToString();

         }*/

       

        public void ListProduct(string passProcedure, Action<Product_control> productClickHandler)
{
    products = new List<Product_control>();

    using (SqlConnection con = new SqlConnection(Path))
    {
        con.Open();
        SqlCommand cmd = new SqlCommand(passProcedure, con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlDataReader reader = cmd.ExecuteReader();

        while (reader.Read())
        {
            byte[] imageData = (byte[])reader["Product_Pic"];
            Image image = GetImageFromByteArray(imageData);
            string price = reader["Price"].ToString();
            string amount = reader["Quantity"].ToString();
            string description = reader["Product_Description"].ToString();

            Product_control product = new Product_control()
            {
                productimage = image,
                price = price,
                amount = amount,
                description = description,
            };

            // Add click event handler to the product control
            product.Click += (sender, e) => productClickHandler.Invoke(product);

            products.Add(product);
        }

        con.Close();
    }

    flowLayoutPanel1.Controls.Clear(); // Clear existing controls

    foreach (Product_control product in products)
    {
        flowLayoutPanel1.Controls.Add(product);
    }

    // Calculate the total price by summing the prices of all products in flowLayoutPanel2
    float totalPrice = CalculateTotalPrice();
    // Display the total price
    Total.Text = totalPrice.ToString();
}

        public void LoadProduct(string passProcedure, EventHandler<ProductClickedEventArgs> productClickedHandler)
        {
            products = new List<Product_control>();

            using (SqlConnection con = new SqlConnection(Path))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(passProcedure, con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    byte[] imageData = (byte[])reader["Product_Pic"];
                    Image image = GetImageFromByteArray(imageData);
                    string price = reader["Price"].ToString();
                    string amount = reader["Quantity"].ToString();
                    string description = reader["Product_Description"].ToString();

                    Product_control product = new Product_control()
                    {
                        productimage = image,
                        price = price,
                        amount = amount,
                        description = description,
                    };

                    // Attach the event handler for the ProductClicked event
                    product.ProductClicked += productClickedHandler;

                    products.Add(product);
                }

                con.Close();
            }

            flowLayoutPanel1.Controls.Clear(); // Clear existing controls

            foreach (Product_control product in products)
            {
                flowLayoutPanel1.Controls.Add(product);
            }

      
        }

        private void HandleProductClick(Product_control product)
        {
            bool productExists = false;

            // Check if a control with the same description already exists in flowLayoutPanel2
            foreach (ListProducts existingProduct in flowLayoutPanel2.Controls)
            {
                if (existingProduct.description == product.description)
                {
                    // Update the price and quantity of the existing control
                    int existingAmount;
                    float existingPrice;

                    if (int.TryParse(existingProduct.amount, out existingAmount) && float.TryParse(existingProduct.price, out existingPrice))
                    {
                        int newAmount;
                        float newPrice;

                        if (int.TryParse(product.amount, out newAmount) && float.TryParse(product.price, out newPrice))
                        {
                            // Update the quantity and price
                            existingProduct.amount = (existingAmount + newAmount).ToString();
                            existingProduct.price = (existingPrice + (newPrice * newAmount)).ToString("0.00");
                        }
                        else
                        {
                            // Parsing failed for new amount or price, handle the error
                            // For example, display an error message or log the error
                            // You can also choose to skip the update or take alternative action
                            MessageBox.Show("Invalid amount or price for the new product.");
                        }
                    }
                    else
                    {
                        // Parsing failed for existing amount or price, handle the error
                        // For example, display an error message or log the error
                        // You can also choose to skip the update or take alternative action
                        MessageBox.Show("Invalid amount or price for the existing product.");
                    }

                    productExists = true;
                    break;
                }
            }
            // Calculate the total price by summing the prices of all products in flowLayoutPanel2
            float totalPrice = CalculateTotalPrice();
            // Display the total price
            Total.Text = totalPrice.ToString();
            // If the product does not exist, create a new instance of ListProducts and add it to flowLayoutPanel2
            if (!productExists)
            {
                // Create a new instance of ListProducts and populate it with the details from Product_control
                ListProducts listProduct = new ListProducts()
                {
                    productimage = product.productimage,
                    amount = product.amount,
                    description = product.description
                };

                float productPrice;
                int productAmount;

                if (float.TryParse(product.price, out productPrice) && int.TryParse(product.amount, out productAmount))
                {
                    listProduct.price = (productPrice * productAmount).ToString("0.00");
                }
                else
                {
                    // Parsing failed for product price or amount, handle the error
                    // For example, display an error message or log the error
                    // You can also choose to skip the update or take alternative action
                    MessageBox.Show("Invalid price or amount for the new product.");
                }

                flowLayoutPanel2.Controls.Add(listProduct);
            }


         
        }






        private void ProductControl_ProductClicked(object sender, ProductClickedEventArgs e)
        {
            string description = e.Description;
            // Do something with the product information
            MessageBox.Show($"This Product Is Add: {description}");

            // Find the corresponding Product_control in flowLayoutPanel1
            Product_control product = flowLayoutPanel1.Controls.OfType<Product_control>()
                                                    .FirstOrDefault(p => p.description == description);
            if (product != null)
            {
                // Call the combined function to handle the product click
                HandleProductClick(product);
            }
        }

        
        
        
        
        //_________________________________________________________________________
        public List<Product_control> GetProductsByCategory(string category, EventHandler<ProductClickedEventArgs> productClickedHandler)
        {
            List<Product_control> categoryProducts = new List<Product_control>();

            using (SqlConnection con = new SqlConnection(Path))
            {
                con.Open();

                string viewName = $"{category}View";
                string sqlQuery = $"SELECT [Product_Pic], [Price], [Product_Description], [Quantity] FROM {viewName}";

                SqlCommand cmd = new SqlCommand(sqlQuery, con);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    byte[] imageData = (byte[])reader["Product_Pic"];
                    Image image = GetImageFromByteArray(imageData);
                    string price = reader["Price"].ToString();
                    string description = reader["Product_Description"].ToString();
                    string quantity = reader["Quantity"].ToString();

                    Product_control product = new Product_control()
                    {
                        productimage = image,
                        price = price,
                        amount = quantity,
                        description = description
                    };

                    // Attach the event handler for the ProductClicked event
                    product.ProductClicked += productClickedHandler;
                    categoryProducts.Add(product);

                }
                flowLayoutPanel1.Controls.Clear();

                foreach (Product_control products in categoryProducts)
                {
                    flowLayoutPanel1.Controls.Add(products);
                }

                    reader.Close();
            }

            return categoryProducts;
        }

        /*public void LoadProductsCategories(string passProcedureCatregories)
        {
            products = new List<Product_control>();

            using (SqlConnection con = new SqlConnection(Path))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(passProcedureCatregories, con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    byte[] imageData = (byte[])reader["Product_Pic"];
                    Image image = GetImageFromByteArray(imageData);
                    string price = reader["Price"].ToString();
                    string amount = reader["Quantity"].ToString();
                    string description = reader["Product_Description"].ToString();

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

            float totalPrice = CalculateTotalPrice();
            // Now you can use the totalPrice variable as needed, such as displaying it on the UI
            Total.Text = totalPrice.ToString();
        }*/

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            List<Product_control> clothesProducts = GetProductsByCategory("Clothes", ProductControl_ProductClicked);
          

        }

        private void ElectronicsCategory_Click(object sender, EventArgs e)
        {


            List<Product_control> electronicsProducts = GetProductsByCategory("Electronics", ProductControl_ProductClicked);
        }

        private void ShoesCategory_Click(object sender, EventArgs e)
        {
            List<Product_control> shoesProducts = GetProductsByCategory("Shoes", ProductControl_ProductClicked);
        }

        private void CarCategory_Click(object sender, EventArgs e)
        {

            List<Product_control> carsProducts = GetProductsByCategory("Cars", ProductControl_ProductClicked);


        }

        private void allProducts_Click(object sender, EventArgs e)
        {

            ClearProducts(flowLayoutPanel1);
            // Call the LoadProduct function with the click event handler
            LoadProduct("Pr_GetAllProducts", ProductControl_ProductClicked);


        }


    }
}




