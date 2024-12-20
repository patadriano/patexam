<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PatExam._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <section class="row" aria-labelledby="aspnetTitle">
            <h1 id="aspnetTitle">ASP.NET</h1>
            <p class="lead">ASP.NET is a free web framework for building great Web sites and Web applications using HTML, CSS, and JavaScript.</p>
            <p><a href="http://www.asp.net" class="btn btn-primary btn-md">Learn more &raquo;</a></p>
        </section>

        <div class="row">
            <asp:UpdatePanel runat="server" ID="UpdatePanel2"  UpdateMode="Conditional" ChildrenAsTriggers="true" >
                <ContentTemplate>
                    <br>
                    <asp:DropDownList runat="server" ID="DropDownList1"></asp:DropDownList>
                    <asp:Label ID="Label2" Text="DepartmentName" runat="server" />
                    <asp:TextBox runat="server" ID="txtDeptName" />
                     <br>
                    <asp:Label ID="Labell" Text="DepartmentHead" runat="server" />
                    <asp:TextBox runat="server" ID="txtDeptHead" />
                    <br>
                    <asp:Button ID="Buttono" Text="Add Dept" runat="server" OnClick="btnAddDept_Click" />
                </ContentTemplate>
            </asp:UpdatePanel>


            <asp:UpdatePanel runat="server" ID="updTeam" UpdateMode="Conditional" ChildrenAsTriggers="true">
                <ContentTemplate>
                    <asp:DropDownList runat="server" ID="ddlTeam"></asp:DropDownList>
                    <asp:Label ID="lblTeamName" Text="TeamName" runat="server" />
                    <asp:TextBox runat="server" ID="txtTeamName" />
                    <asp:Label ID="lblTeamLead" Text="Name of Team Lead" runat="server" />
                    <asp:TextBox runat="server" ID="txtTeamLead" />
                    <asp:Label ID="Label1" Text="Department Name" runat="server" />
                    <asp:TextBox runat="server" ID="txtDeptNameTeam" />
                    <asp:Button ID="btnAddTeam" Text="Add Team" runat="server" OnClick="btnAddTeam_Click" />
                </ContentTemplate>
            </asp:UpdatePanel>
            
            <asp:UpdatePanel runat="server" ID="UpdatePanel1"  UpdateMode="Conditional" ChildrenAsTriggers="true" >
                <ContentTemplate>
                   <br>
                    <asp:Label ID="Label4" Text="Employee Name" runat="server" />
                    <asp:TextBox runat="server" ID="txtName" />
                    <asp:Button ID="Button1" Text="Add Member" runat="server" OnClick="btnAddMember_Click" />
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
    </main>

</asp:Content>
