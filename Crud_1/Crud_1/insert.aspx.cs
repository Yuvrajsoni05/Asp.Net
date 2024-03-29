using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Crud_1
{
    public partial class insert : System.Web.UI.Page
    {
        // This method is called when the page is loaded
        protected void Page_Load(object sender, EventArgs e)
        {
            // Check if the page is loaded for the first time
            if (!IsPostBack)
            {
                // If it's the first load, load records into the GridView
                LoadRecord();
            }
        }

        // Establishing a connection to the database
        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\_-_YUVRAJ_-_\\OneDrive\\Documents\\crud.mdf;Integrated Security=True;Connect Timeout=30;");

        // Method to handle insert button click event
        protected void Button1_Click(object sender, EventArgs e)
        {
            // Open the database connection
            conn.Open();
            // Create a SQL command for inserting data into the database
            SqlCommand comm = new SqlCommand("Insert into data values('" + int.Parse(TextBox1.Text) + "','" + TextBox2.Text + "','" + TextBox3.Text + "')", conn);
            // Execute the command
            comm.ExecuteNonQuery();
            // Close the connection
            conn.Close();
            // Show an alert indicating successful data insertion
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert(' data inserted ');", true);
            // Reload records in the GridView
            LoadRecord();
        }

        // Method to load records into the GridView
        void LoadRecord()
        {
            // Create a SQL command to select all records from the database
            SqlCommand comm = new SqlCommand("select * from data ", conn);
            // Create a data adapter to execute the command
            SqlDataAdapter d = new SqlDataAdapter(comm);
            // Create a DataTable to store the retrieved data
            DataTable dt = new DataTable();
            // Fill the DataTable with data from the database
            d.Fill(dt);
            // Bind the DataTable to the GridView for display
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        // Method to handle update button click event
        protected void Button3_Click(object sender, EventArgs e)
        {
            // Open the database connection
            conn.Open();
            // Create a SQL command for updating data in the database
            SqlCommand comm = new SqlCommand("update  data set Name = '" + TextBox2.Text + "',Age = '" + TextBox3.Text + "'where Id = '" + int.Parse(TextBox1.Text) + "' ", conn);
            // Execute the command
            comm.ExecuteNonQuery();
            // Close the connection
            conn.Close();
            // Show an alert indicating successful data update
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert(' data Update ');", true);
            // Reload records in the GridView
            LoadRecord();
        }

        // Method to handle delete button click event
        protected void Button4_Click(object sender, EventArgs e)
        {
            // Open the database connection
            conn.Open();
            // Create a SQL command for deleting data from the database
            SqlCommand comm = new SqlCommand("delete  data where Id = '" + int.Parse(TextBox1.Text) + "' ", conn);
            // Execute the command
            comm.ExecuteNonQuery();
            // Close the connection
            conn.Close();
            // Show an alert indicating successful data deletion
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert(' data Delete ');", true);
            // Reload records in the GridView
            LoadRecord();
        }

        // Method to handle search button click event
        protected void Button2_Click(object sender, EventArgs e)
        {
            // Create a SQL command to select specific records from the database based on the provided ID
            SqlCommand comm = new SqlCommand("select * from data  where Id = '" + int.Parse(TextBox1.Text) + "' ", conn);
            // Create a data adapter to execute the command
            SqlDataAdapter d = new SqlDataAdapter(comm);
            // Create a DataTable to store the retrieved data
            DataTable dt = new DataTable();
            // Fill the DataTable with data from the database
            d.Fill(dt);
            // Bind the DataTable to the GridView for display
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
    }
}
