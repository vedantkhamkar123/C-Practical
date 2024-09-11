using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prac3B3
{
    public partial class Prac3B33 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Calendar1_DayRender(object sender, DayRenderEventArgs e)
        {
            if(e.Day.Date.Year == 2024 && e.Day.Date.Month== 9 && e.Day.Date.Day == 7 )
            {
                Label l1=new Label();
                l1.Text ="<br>Ganpati";
                e.Cell.Controls.Add(l1);
            }
            if (e.Day.Date.Year == 2024 && e.Day.Date.Month == 9 && e.Day.Date.Day == 17)
            {
                Label l1 = new Label();
                l1.Text = "<br>Ananta Chaturdashi";
                e.Cell.Controls.Add(l1);
            }
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            Calendar1.SelectedDayStyle.BackColor = System.Drawing.Color.Red;
            Calendar1.SelectedDayStyle.ForeColor = System.Drawing.Color.Yellow;
        }
    }
}
