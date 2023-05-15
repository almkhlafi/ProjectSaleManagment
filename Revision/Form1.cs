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
        string Path = "Data Source=ABDULRAHMAN\\SQLEXPRESS;Initial Catalog=RegistrationInfo;Integrated Security=True";
        SqlConnection con;
        SqlCommand cmd; // as below It can be 
        DataTable dt; //Or I can Use  DataTable dt=new DataTable();
        SqlDataAdapter adpt;


        string Fname;
        string Lname;
        string ccount;
        string phoneN;
        string address;
        string password;
        string email;
        string gender = "";
        string hobbies = "";

        public Main()
        {
            InitializeComponent();
            con = new SqlConnection(Path);
            DELETE.Enabled = false;
            UPDATE.Enabled = false;
            ADD.Enabled = true;
            
        }

        

        // Rest of your code...

        // Make sure to close the namespace and class appropriately


        private void bConfirm_Click(object sender, EventArgs e)
        {

            insertToDatatbase();

        }

        private void Main_Load(object sender, EventArgs e)
        {
            DELETE.Enabled = false;
            UPDATE.Enabled = false;
            ADD.Enabled = true;
            Search.Text = "Search .........";
            StartPosition = FormStartPosition.CenterScreen;
            dt = new DataTable();
            dt.Columns.Add("Full Name");
            dt.Columns.Add("Email");
            dt.Columns.Add("Passworde");
            dt.Columns.Add("Gender");
            dt.Columns.Add("Phone Number");
            dt.Columns.Add("Address");
            dt.Columns.Add("Hobbies");
            dt.Columns.Add("Country");
            retrieveDatabase();
            combo.Items.Add("Yemen");
            combo.Items.Add("Saudi");
            combo.Items.Add("Qater");
            combo.Items.Add("Egypt");
            combo.Items.Add("Turkey");

        }

        public void insertToDatatbase()
        {

            Fname = fName.Text;
            Lname = lName.Text;
            ccount = country.Text;
            phoneN = phoneNumber.Text;
            address = Address.Text;
            password = Password.Text;
            email = Email.Text;

            
            DataRow dr = dt.NewRow();
            if (string.IsNullOrEmpty(ID.Text)|| string.IsNullOrEmpty(fName.Text) || string.IsNullOrEmpty(lName.Text) || string.IsNullOrEmpty(phoneNumber.Text) ||
            string.IsNullOrEmpty(Address.Text) || (!Male.Checked && !Female.Checked) || string.IsNullOrEmpty(Password.Text) || combo.SelectedIndex == -1)
            {
                MessageBox.Show("Fill the Empty Fields please !!");
            }
            else
            {
                try
                {
                    if (Male.Checked ==
                true)
                    {
                        gender = Male.Text;
                    }
                    else gender = Female.Text;


                    /*
                    //To add the intered values from C# components to the Datagrid directlly 
                    dr[0] = Fname + Lname;
                    dr[1] = email;
                    dr[2] = password;
                    dr[3] = gender;
                    dr[4] = phoneN;
                    dr[5] = address;
                    string Hobies = "";
                    if (code.Checked) { Hobies += "Coding  "; }
                    if (gym.Checked) { Hobies += "GYM  "; }
                    dr[6] = Hobies;

                    dr[7] = combo.GetItemText(combo.SelectedItem);
                    dt.Rows.Add(dr);
                    */
                    //MessageBox.Show("Information are:\n Your Name:" + Fname + Lname + "\n Email: " + email + "\nGender:" + gender + "\nPhone Number: " + phoneN + "Address:" + address);

                    //Insert the values to the databse 
                    con.Open();
                    cmd = new SqlCommand("INSERT INTO Employee (Fullname, Email, Passwords, Gender, PhoneNumber, Address, Hobbies, Country) values ('" + fName.Text + lName.Text + "','" + Email.Text + "','" + Password.Text + "','" + gender + "','" + phoneNumber.Text + "','" + Address.Text + "','" + gym.Text + code.Text + "','" + combo.GetItemText(combo.SelectedItem) + "')", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Your data has been Seved (:");
                    clear();

                }
                catch (Exception e)
                {
                    MessageBox.Show("Error");
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

                adpt = new SqlDataAdapter("SELECT *  FROM Employee", con);
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
        private void datagradInform_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try {
                clear();
                DELETE.Enabled = true;
                UPDATE.Enabled = true;
                ADD.Enabled = false;
            ID.Text= datagradInform.Rows[e.RowIndex].Cells[0].Value.ToString();
            fName.Text = datagradInform.Rows[e.RowIndex].Cells[1].Value.ToString();
            lName.Text = datagradInform.Rows[e.RowIndex].Cells[2].Value.ToString();
            Email.Text = datagradInform.Rows[e.RowIndex].Cells[3].Value.ToString();
            Password.Text = datagradInform.Rows[e.RowIndex].Cells[4].Value.ToString();
            Male.Checked = false;
            Female.Checked = true;
            if (datagradInform.Rows[e.RowIndex].Cells[5].Value.ToString() == "Male")
            {
                Male.Checked = true;
                Female.Checked = false;
            }
            phoneNumber.Text = datagradInform.Rows[e.RowIndex].Cells[6].Value.ToString();
            Address.Text = datagradInform.Rows[e.RowIndex].Cells[7].Value.ToString();
            if (datagradInform.Rows[e.RowIndex].Cells[8].Value.ToString()!="") { code.Checked = true;gym.Checked = true; }
            string selectedCountry = datagradInform.Rows[e.RowIndex].Cells[9].Value.ToString();
            if (combo.Items.Contains(selectedCountry))
            {
                combo.SelectedItem = selectedCountry;
            }
            else
            {
                combo.Items.Insert(0, selectedCountry);
                combo.SelectedIndex = 0;
            }
            }catch(Exception ex) { MessageBox.Show("AN ERROR !!"); }

        }

        private void update_Click(object sender, EventArgs e)
        {


            if (Male.Checked)
            {
                gender = "Male";
                Female.Checked = false;

            }
            else { 
                gender = "Female"; 
                Male.Checked = false;
            
            }
            if (gym.Checked = true) hobbies += "Gym";
            if (code.Checked = true) hobbies += "Coding";



            try { 
            
             //More Secure cinnection to SQL Server
                         cmd = new SqlCommand("UPDATE Employee SET FirstName = @FirstName, SureName = @SureName, Email = @Email, Passwords = @Passwords, Gender = @Gender, PhoneNumber = @PhoneNumber, Address = @Address WHERE EmployeeID = @EmployeeID", con);

                        cmd.Parameters.AddWithValue("@FirstName", fName.Text);
                        cmd.Parameters.AddWithValue("@SureName", lName.Text);
                        cmd.Parameters.AddWithValue("@Email", Email.Text);
                        cmd.Parameters.AddWithValue("@Passwords", Password.Text);
                        cmd.Parameters.AddWithValue("@Gender", gender);
                        cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber.Text);
                        cmd.Parameters.AddWithValue("@Address", Address.Text);
                        cmd.Parameters.AddWithValue("@EmployeeID", ID.Text); 
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
            cmd = new SqlCommand("DELETE FROM Employee where EmployeeID='" + ID.Text+ "'",con);
            if (cmd.ExecuteNonQuery() == 0) MessageBox.Show("OOPS !!"); else MessageBox.Show("DELETED");
            con.Close();
            retrieveDatabase();
                clear();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        public void clear()
        {
            lName.Text= string.Empty;
            fName.Text = string.Empty;
            Email.Text = string.Empty;
            Password.Text = string.Empty;
            Male.Checked= false;
            Female.Checked= false;
            combo.SelectedIndex= -1;
            phoneNumber.Text = string.Empty;
            Address.Text = string.Empty;
            ID.Text = string.Empty;
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
                adpt = new SqlDataAdapter("Select * from Employee where FirstName like '%" + Search.Text + "%'",con);
                dt = new DataTable();
              
                adpt.Fill(dt);
            datagradInform.DataSource= dt;
            con.Close();
             
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btAddProduct_Click(object sender, EventArgs e)
        {
            ADDPRODUCTFORM fm2= new ADDPRODUCTFORM();
            fm2.Show();
            this.Hide();
        }

        private void loadproduct_Click(object sender, EventArgs e)
        {
            MainForm Mf=new MainForm();
            Mf.Show();
            this.Hide();
        }
    }
}