using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prac3B4
{
    public partial class Prac3B44 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            Calendar1.SelectedDayStyle.BackColor = System.Drawing.Color.Red;
            Calendar1.SelectedDayStyle.ForeColor = System.Drawing.Color.Yellow;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TimeSpan ts = Calendar1.SelectedDate - Calendar2.SelectedDate;
            Label1.Text = ts.TotalDays.ToString();
        }

    }
}
