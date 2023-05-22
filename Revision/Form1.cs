using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using Microsoft.IdentityModel.Tokens;

namespace Revision
{
    

    public partial class Main : Form
    {
        public static Main main;
        string Path = "Data Source=ABDULRAHMAN\\SQLEXPRESS;Initial Catalog=SaleManagementSystem;Integrated Security=True";
        SqlConnection con;
        SqlCommand cmd; // as below It can be 
        DataTable dt; //Or I can Use  DataTable dt=new DataTable();
        SqlDataAdapter adpt;
        string Fname;
        string phoneN;
        string address;
        
        public Main()
        {
            InitializeComponent();
            con = new SqlConnection(Path);
        
            DELETE.Enabled = false;
            UPDATE.Enabled = false;
            ADD.Enabled = true;

        }
            

        private void bConfirm_Click(object sender, EventArgs e)
        {

            insertToDatatbase();
          

        }

        private void Main_Load(object sender, EventArgs e)
        {
            providerInformation();
        }
        public void providerInformation()
        {
            DELETE.Enabled = false;
            UPDATE.Enabled = false;
            ADD.Enabled = true;
            Search.Text = "Search .........";
            StartPosition = FormStartPosition.CenterScreen;
            dt = new DataTable();
            dt.Columns.Add("Full Name");
            dt.Columns.Add("Phone Number");
            dt.Columns.Add("Address");
            retrieveDatabase();
        }
        public  void insertToDatatbase()
        {

            Fname = fName.Text;
            phoneN = phoneNumber.Text;
            address = Address.Text;
            DataRow dr = dt.NewRow();
            if ( string.IsNullOrEmpty(fName.Text) ||  string.IsNullOrEmpty(phoneNumber.Text) ||
            string.IsNullOrEmpty(Address.Text))
            {
                MessageBox.Show("Fill the Empty Fields please !!");
            }
            else
            {
                try
                {
                    //Insert the values to the databse 
                    

                    {
                        //Insert the values into the database 

                        con.Open();
                        using (SqlCommand cmd = new SqlCommand("Pr_InsertNewProvider", con))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@FullName", Fname);
                            cmd.Parameters.AddWithValue("@Phone_Number", phoneN);
                            cmd.Parameters.AddWithValue("@Providers_Address", address);

                            cmd.ExecuteNonQuery();
                            con.Close();
                        }
                        MessageBox.Show("Your data has been saved successfully!");
                        clear();

                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Not Added !! \n"+e.Message );
                }
            }
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

                con.Open();
                adpt = new SqlDataAdapter("SELECT *  FROM Providers", con);
                dt = new DataTable();
                adpt.Fill(dt);
                datagradInform.DataSource = dt;
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Data Is not Showen !!! Check connection to the server!!!");
        }

        }

        private void datagradInform_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                clear();
                DELETE.Enabled = true;
                UPDATE.Enabled = true;
                ADD.Enabled = false;
                ProviderID.Text = datagradInform.Rows[e.RowIndex].Cells[0].Value.ToString();
                fName.Text = datagradInform.Rows[e.RowIndex].Cells[1].Value.ToString();
                //Email.Text = datagradInform.Rows[e.RowIndex].Cells[2].Value.ToString();
                phoneNumber.Text = datagradInform.Rows[e.RowIndex].Cells[2].Value.ToString();
                Address.Text = datagradInform.Rows[e.RowIndex].Cells[3].Value.ToString();
            }catch(Exception ex) { MessageBox.Show("AN ERROR !!"); }

        }

        private void update_Click(object sender, EventArgs e)
        {
              try { 
                //More Secure cinnection to SQL Server
                   cmd = new SqlCommand("Pr_UpdateProvider", con);
                   cmd.CommandType = CommandType.StoredProcedure;
                   cmd.Parameters.AddWithValue("@ProviderID", int.Parse(ProviderID.Text));
                   cmd.Parameters.AddWithValue("@Fname", fName.Text);
                           cmd.Parameters.AddWithValue("@phoneN", phoneNumber.Text);
                           cmd.Parameters.AddWithValue("@address", Address.Text);
                           con.Open();
               if (cmd.ExecuteNonQuery() ==0) 
                    MessageBox.Show("Check your values");
               else MessageBox.Show("Updated");
               con.Close();

               retrieveDatabase();
                clear();
               }
               catch(Exception ex) { 
                   MessageBox.Show(ex.Message); 
               }
            

        }

        private void DELETE_Click(object sender, EventArgs e)
        {


            try { 
           

                con.Open();

                SqlCommand cmd = new SqlCommand("Pr_DeleteProvider", con);
                cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ProviderID", int.Parse(ProviderID.Text));
                    if (cmd.ExecuteNonQuery() == 0) MessageBox.Show("OOPS !!"); else MessageBox.Show("DELETED");
                    con.Close();
                    retrieveDatabase();
                    clear();
                
              
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        public void clear()
        {
            fName.Text = string.Empty;
            phoneNumber.Text = string.Empty;
            Address.Text = string.Empty;
            Search.Text = string.Empty;
            
        }

        private void Main_MouseClick(object sender, MouseEventArgs e)
        {
            DELETE.Enabled = false;
            UPDATE.Enabled = false;
            ADD.Enabled = true;
            clear();
        }

        private void Search_TextChanged(object sender, EventArgs e)
        {
            try {
                con.Open();
                adpt = new SqlDataAdapter("Select * from Providers where FullName like '%" + Search.Text + "%'",con);
                dt = new DataTable();
              
                adpt.Fill(dt);
            datagradInform.DataSource= dt;
            con.Close();
             
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btAddProduct_Click(object sender, EventArgs e)
        {
            ADDPRODUCTFORM form2= new ADDPRODUCTFORM();
            form2.Show();
            this.Hide();

        }

        private void loadproduct_Click(object sender, EventArgs e)
        {
            MainForm Mf=new MainForm();
            Mf.Show();
            this.Hide();
        }

        private void Email_TextChanged(object sender, EventArgs e)
        {

        }
    }
}