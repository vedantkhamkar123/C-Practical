using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prac1A1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(TextBox1.Text);
            int b = int.Parse(TextBox2.Text);
            int c = int.Parse(TextBox3.Text);
            int d = int.Parse(TextBox4.Text);

           
            int product = a* b* c*d ;
            Label2.Text = "product of 4 int no is := " + product;
        }
    }
}

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Prac1A1.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Enter a 4 int No:="></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" style="margin-left: 11px" 
            Width="69px"></asp:TextBox>
        <asp:TextBox ID="TextBox2" runat="server" style="margin-left: 11px" 
            Width="71px"></asp:TextBox>
        <asp:TextBox ID="TextBox3" runat="server" style="margin-left: 11px" 
            Width="69px"></asp:TextBox>
        <asp:TextBox ID="TextBox4" runat="server" style="margin-left: 11px" 
            Width="71px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Button" />
        <br />
        <br />
    
    </div>
    <asp:Label ID="Label2" runat="server" Text="Ans"></asp:Label>
    </form>
</body>
</html>
