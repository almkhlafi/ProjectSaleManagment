//using MySql.Data.MySqlClient;
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
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Revision
{


    public partial class ADDPRODUCTFORM : Form
    {
        string Path = "Data Source=ABDULRAHMAN\\SQLEXPRESS;Initial Catalog=SaleManagementSystem;Integrated Security=True";
        //string Path = "server=localhost;user=root;pwd=root;database=storandsalesmanagemen";
          SqlConnection con;
           SqlCommand cmd; 
        // as below It can be 
        DataTable dt;
        //Or I can Use  DataTable dt=new DataTable();
       SqlDataAdapter adpt;
        string productDes;
        int proAmount = 0;
        Image img;
        //   SqlConnection con;
        // SqlDataAdapter adpt;
        //  SqlCommand cmd;
      
        public  ADDPRODUCTFORM()
        {
            InitializeComponent();
            con = new SqlConnection(Path);
         
          
        }


        
        public void retrieveDatabase()
        {

            /*
             * SqlDataAdapter()
               @It acts as a bridge between the data source (SQL Server database) and the DataSet or DataTable objects in your application
             1)Filling a DataTable or DataSet with data from the database using the Fill() method.
             2)Updating changes made to a DataTable or DataSet back to the database using the Update method.
            3)Executing SQL commands or stored procedures using the ExecuteNonQuery method.
            4)Retrieving a single value from the database using the ExecuteScalar method.


            *DataSource
            Binding: By setting the DataSource property, you establish a binding between the control and the data source. The control will fetch the data from the source and display it 
*/



            try
            {
                StartPosition = FormStartPosition.CenterScreen;
                dt = new DataTable();
                dt.Columns.Add("Full Name");
                dt.Columns.Add("Phone Number");
                dt.Columns.Add("Email");
                dt.Columns.Add("Address");
                con.Open();
                adpt = new SqlDataAdapter("SELECT *  FROM Providers", con);
                dt = new DataTable();
                adpt.Fill(dt);
                datagradInform.DataSource = dt;
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Data Is not Show !!! Check connection to the server!!!");
            }


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
            insertproducts();
         
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
      

        private void ClearProInof_Click(object sender, EventArgs e)
        {
            clearProductInsertion();


        }

        private void Form2_Load(object sender, EventArgs e)
        {
            clearProductInsertion();
            retrieveDatabase();
            loadCategories();


        }

        private void MainForm_Click(object sender, EventArgs e)
        {
            MainForm Mf= new MainForm();    
            Mf.Show();
            this.Dispose();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Category_TextChanged(object sender, EventArgs e)
        {

        }

        private void Category_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            insertCategory();
            loadCategories();
        }
        //________________Database Insertion deletion and update__

        public void insertproducts()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(Path))
                {
                    con.Open();

                    // Get the CategoryID based on the selected category name
                    SqlCommand getCategoryIDCmd = new SqlCommand("Pr_GetCategoryIDByName", con);
                    getCategoryIDCmd.CommandType = CommandType.StoredProcedure;
                    getCategoryIDCmd.Parameters.AddWithValue("@CategoryName", LoadCategories.SelectedItem.ToString());
                    SqlParameter categoryIdParameter = new SqlParameter("@CategoryID", SqlDbType.Int);
                    categoryIdParameter.Direction = ParameterDirection.Output;
                    getCategoryIDCmd.Parameters.Add(categoryIdParameter);
                    getCategoryIDCmd.ExecuteNonQuery();
                    int CategoryID = Convert.ToInt32(getCategoryIDCmd.Parameters["@CategoryID"].Value);


               

                    // Insert the new product
                    SqlCommand insertProductCmd = new SqlCommand("Pr_insertNewProduct", con);
                    insertProductCmd.CommandType = CommandType.StoredProcedure;
                    insertProductCmd.Parameters.AddWithValue("@p_Picture", getPhoto());
                    insertProductCmd.Parameters.AddWithValue("@p_description", Productdescription.Text);
                    insertProductCmd.Parameters.AddWithValue("@p_price", decimal.Parse(Price.Text.Trim()));
                    insertProductCmd.Parameters.AddWithValue("@p_amount", int.Parse(Amount.Text.Trim()));
                    insertProductCmd.Parameters.AddWithValue("@CategoryID", CategoryID);
                    insertProductCmd.Parameters.AddWithValue("@S_SupplierID", int.Parse(SupplierID.Text.Trim()));
                    insertProductCmd.ExecuteNonQuery();

                    MessageBox.Show("Product added successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void insertCategory()
        {
            try
            {

                if (AddCategory.Text == null)
                {
                    errorMessage("Category Is field is Empty");
                }
                else { 
                //the Pr_InsertNewCategory checkes where the category is been added or not
              
                    using (con = new SqlConnection(Path))
                    {
                        con.Open();
                        cmd = new SqlCommand("Pr_InsertNewCategory", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@CategoryName",this.AddCategory.Text);
                    // Execute the stored procedure
                    cmd.ExecuteNonQuery();
                    con.Close();
                        MessageBox.Show("Category Has Benn Add");
                        AddCategory.Text= "";
                        con.Close();
                }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void loadCategories()
        {
            LoadCategories.Items.Clear();

            using (con = new SqlConnection(Path))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Pr_GetCategoryName", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        LoadCategories.Items.Add(reader["Category_Name"].ToString());
                    }
                }
                else
                {
                    LoadCategories.Items.Add("No categories found");
                }

                reader.Close();
                con.Close();

            }
        }

        //________________Messages And Clear Funtions_____________

        public void errorMessage(string message)
        {
            MessageBox.Show(message);
        }
        public void clearProductInsertion()
        {
            Amount.Text = "0";
            Price.Text = "0$";
            Productdescription.Text = "Enter Product Description....";
            Image defaultBackground = null;

            productPic.BackgroundImage = defaultBackground;

        }

        private void datagradInform_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            SupplierID.Text = datagradInform.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void SearchMain_TextChanged(object sender, EventArgs e)
        {
           
                try
                {
                using (con = new SqlConnection(Path)) { 
                    con.Open();
                    adpt = new SqlDataAdapter("Select * from Providers where name like '%" + SearchMain.Text + "%'", con);
                    dt = new DataTable();
                    adpt.Fill(dt);
                    datagradInform.DataSource = dt;
                    con.Close();
                }
            }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        
    }
  
}
