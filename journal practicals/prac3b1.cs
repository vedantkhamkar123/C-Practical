#Visual studio code

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prac3B1
{
    public partial class Prac3B11 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = Calendar1.SelectedDate;
            lblMessage.Text = "You selected: " + selectedDate.ToShortDateString();
            ShowAdditionalInfo(selectedDate);
        }
        protected void Calendar1_DayRender(object sender, DayRenderEventArgs e)
        {
            if (e.Day.Date == new DateTime(DateTime.Now.Year, 12, 25)) 
            {
                e.Cell.CssClass = "highlighted-date";
                e.Cell.ToolTip = "Christmas Day!";
            }
        }
        private void ShowAdditionalInfo(DateTime date)
        {
            if (date.Date == new DateTime(DateTime.Now.Year, 12, 25)) 
            {
                pnlAdditionalInfo.Visible = true;
                lblAdditionalInfo.Text = "Merry Christmas! Enjoy the holiday season.";
            }
            else
            {
                pnlAdditionalInfo.Visible = false;
            }
        }
    }
}
#gui
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Prac3B11.aspx.cs" Inherits="Prac3B1.Prac3B11" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Calendar Messages Demo</title>
    <style>
        .highlighted-date {
            background-color: #ffeb3b;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged" OnDayRender="Calendar1_DayRender" />
                <br />
        <asp:Label ID="lblMessage" runat="server" Text="Select a date to see the message." />
            <asp:Panel ID="pnlAdditionalInfo" runat="server" Visible="false">
                <asp:Label ID="lblAdditionalInfo" runat="server" />
            </asp:Panel>
    </div>
    </form>
</body>
</html>

#Console code
using System;

class Program
{
    static void Main(string[] args)
    {
        // Get today's date
        DateTime today = DateTime.Now;

        // Define Christmas (December 25th) for the current year
        DateTime christmas = new DateTime(today.Year, 12, 25);

        // Check if today is Christmas
        if (today.Date == christmas.Date)
        {
            Console.WriteLine("Today is Christmas Day! Merry Christmas!");
        }
        else
        {
            Console.WriteLine("Today is not Christmas. It's " + today.ToString("MMMM dd") + ".");
        }

        // Keep the console window open
        Console.ReadLine();
    }
}
