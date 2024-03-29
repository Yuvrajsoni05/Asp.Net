using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Drawing;

namespace AJAX_CRUD
{
    public partial class insert : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Documents\test.mdf;Integrated Security=True;Connect Timeout=30;");




        protected void Page_Load(object sender, EventArgs e)
        {
            string name, city, opr , oldname, newname;
            opr = Request.QueryString["opr"].ToString();
            

            if (opr == "insert")
            {
                name = Request.QueryString["nm"].ToString();
                city = Request.QueryString["ct"].ToString();

                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into Test_1 values('" + name.ToString() + "','" + city.ToString() + "')";
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            if (opr == "display")
            {

                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Test_1";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                Response.Write("<table>");

                Response.Write("<tr>");
                Response.Write("<td>"); Response.Write("name"); Response.Write("</td>");
                Response.Write("<td>"); Response.Write("city"); Response.Write("</td>");
                Response.Write("</tr>");


                foreach (DataRow dr in dt.Rows)
                {
                    Response.Write("<tr>");
                    Response.Write("<td>"); Response.Write(dr["name"].ToString()); Response.Write("</td>");
                    Response.Write("<td>"); Response.Write(dr["city"].ToString()); Response.Write("</td>");
                    Response.Write("</tr>");

                }

            }
            if (opr == "delete1")
            {
                name = Request.QueryString["nm"].ToString();
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from Test_1 where name='" + name.ToString() + "' ";
                cmd.ExecuteNonQuery();


                conn.Close();
            }
            if (opr == "update1")
            {
                oldname = Request.QueryString["oldname"].ToString();
                newname = Request.QueryString["newname"].ToString();

                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update Test_1 set name='" + newname.ToString() + "' where name='" + oldname.ToString() + "'";
                cmd.ExecuteNonQuery();


                conn.Close();
            }

        }
    }
}