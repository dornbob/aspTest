using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;
using System.Data.SqlClient;


public partial class Index : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        lblInsertSuccess.Visible = false;
        lblTruncateSuccess.Visible = false;
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        using (SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["con"].ConnectionString))
        {
            String sqlQuery = "INSERT INTO person (FirstName,LastName) VALUES (@FirstName,@LastName)";

            using (SqlCommand command = new SqlCommand(sqlQuery, con))
            {
                command.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                command.Parameters.AddWithValue("@LastName", txtLastName.Text);

                con.Open();
                int result = command.ExecuteNonQuery();

                if (result > 0)
                {
                    lblInsertSuccess.Visible = true;
                    txtFirstName.Text = "";
                    txtLastName.Text = "";
                }
            }
        }
    }



    protected void btnTruncate_Click(object sender, EventArgs e)
    {
        using (SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["con"].ConnectionString))
        {
            String sqlQuery = "TRUNCATE TABLE person";

            using (SqlCommand command = new SqlCommand(sqlQuery, con))
            {
                con.Open();
                int result = command.ExecuteNonQuery();

                if (result < 0)
                {
                    lblTruncateSuccess.Visible = true;
                }
            }
        }
    }
}