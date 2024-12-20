using Microsoft.Ajax.Utilities;
using PatExam.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static System.Net.Mime.MediaTypeNames;

namespace PatExam
{
	public partial class _Default : Page
	{
		
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!IsPostBack)
			{
				//if (Cache["Team"] == null)
				//{
					
				//	Cache["Team"] = new List<Team>();
				//}

				//ddlTeam.DataSource = (List<Team>)Cache["Team"];
				//ddlTeam.DataTextField = "Name";
				//ddlTeam.DataValueField = "Name";
				//ddlTeam.DataBind();
            }
		}

        protected void btnAddDept_Click(object sender, EventArgs e)
		{
			Department dept = new Department();
			dept.Name = txtDeptName.Text;
			dept.DeptHead = new Employee();
			dept.DeptHead.Name = txtDeptName.Text;

            DefaultController defaultController = new DefaultController();
            defaultController.);

        }

        protected void btnAddTeam_Click(object sender, EventArgs e)
        {


			Team team = new Team();
			Employee teamLead = new Employee();
			
			team.Name = txtTeamName.Text;

            teamLead.Name = txtTeamLead.Text;

            team.TeamLead = teamLead;
			team.NumEmployees = Convert.ToInt32(txtNumEmployees.Text);

            //((List<Team>)Cache["Team"]).Add(team);

            //ddlTeam.DataSource = (List<Team>)Cache["Team"];
            //ddlTeam.DataTextField = "Name";
            //ddlTeam.DataValueField = "Name";
            //ddlTeam.DataBind();
        }
			
			
        protected void btnAddMember_Click(object sender, EventArgs e)
		{
            //TextBox3.Text
            Employee emp = new Employee();
			emp.Name = txtName.Text;
			emp.Address = txtAddress.Text;
            DefaultController defaultController = new DefaultController();
			defaultController.Basic(emp);

			//if (((List<Team>)Cache["Team"])[ddlTeam.SelectedIndex].Employees == null)
			//	((List<Team>)Cache["Team"])[ddlTeam.SelectedIndex].Employees = new List<Employee>();
			//Employee emp = new Employee();
			//emp.Name = TextBox3.Text;
   //         ((List<Team>)Cache["Team"])[ddlTeam.SelectedIndex].Employees.Add(emp);
        }
	}
}