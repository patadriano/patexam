using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using SimpleCRUD.Controllers;

namespace SimpleCRUD
{
    public partial class _Default : Page
    {
        StringBuilder table = new StringBuilder();
        protected void Page_Load(object sender, EventArgs e)
        {
            
           

            if (!Page.IsPostBack)
            {
                display();

            }
        }
        protected void btnAddPerson_Click(object sender, EventArgs e)
        {
            Model person = new Model();
            person.Name = txtName.Text;
            person.Age = Convert.ToInt32(txtAge.Text);

            DefaultController defaultController = new DefaultController();
            defaultController.PersonTable(person);
            display();
            UpdatePanel2.Update();
                  
        }
        public void display()
        {
            //string constring = ConfigurationManager.ConnectionStrings["Test"].ConnectionString;
            //SqlConnection con = new SqlConnection(constring);
            //con.ConnectionString = ConfigurationManager.ConnectionStrings["Test"].ToString();
            //con.Open();
            //SqlCommand cmd = new SqlCommand();
            //cmd.CommandText = "select * from Person";
            //cmd.Connection = con;
            //SqlDataReader rd = cmd.ExecuteReader();
            //table.Append("<table border='1'>");
            //table.Append("<tr><th>Name</th><th>Age</th>");
            //table.Append("</tr>");

            //if (rd.HasRows)
            //{
            //    while (rd.Read())
            //    {
            //        table.Append("<tr>");
            //        table.Append("<td>" + rd[0] + "<td>");
            //        table.Append("<td>" + rd[1] + "<td>");
            //        table.Append("<tr>");
            //    }
            //}
            //table.Append("</table>");
            //PlaceHolder1.Controls.Add(new Literal { Text = table.ToString() });
            //rd.Close();
        }

    }
}