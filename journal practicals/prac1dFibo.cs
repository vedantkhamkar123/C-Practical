using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prac1D1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int x=int.Parse(TextBox1.Text);
            int a = 0;
            int b = 1, c;
            Label2.Text = a + " " + b + " ";
            for (int i = 2; i < x; i++)
            {
                c = a + b;
                a = b;
                b = c;
                Label2.Text += c + " ";
            }
        }

    }
    
}

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Prac1D1.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Enter a no := "></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" style="margin-left: 16px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Button" />
        <br />
        <br />
    
    </div>
    <asp:Label ID="Label2" runat="server" Text="Fibonacci Series"></asp:Label>
    </form>
</body>
</html>
