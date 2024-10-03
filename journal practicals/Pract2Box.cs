using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pract2Box
{
    public partial class Pract2Boxx : System.Web.UI.Page
    {
        protected Label lblInput;
        protected TextBox txtValue;
        protected Button btnSubmit;
        protected Label lblBoxed;
        protected Label lblUnboxed;
        protected void Page_Load(object sender, EventArgs e)
        {
             // Dynamically create Label for input
            lblInput = new Label();
            lblInput.Text = "Enter the Value:";
            this.form1.Controls.Add(lblInput);
            this.form1.Controls.Add(new Literal { Text = "&nbsp;" });

            // Dynamically create TextBox for input
            txtValue = new TextBox();
            txtValue.ID = "txtValue";
            this.form1.Controls.Add(txtValue);
            this.form1.Controls.Add(new Literal { Text = "<br /><br />" });

            // Dynamically create Button
            btnSubmit = new Button();
            btnSubmit.Text = "Print Boxed and Unboxed Value";
            btnSubmit.Click += new EventHandler(Button1_Click);  // Attach event handler
            this.form1.Controls.Add(btnSubmit);
            this.form1.Controls.Add(new Literal { Text = "<br /><br />" });

            // Dynamically create Label for boxed value
            lblBoxed = new Label();
            lblBoxed.ID = "lblBoxed";
            this.form1.Controls.Add(lblBoxed);
            this.form1.Controls.Add(new Literal { Text = "<br /><br />" });

            // Dynamically create Label for unboxed value
            lblUnboxed = new Label();
            lblUnboxed.ID = "lblUnboxed";
            this.form1.Controls.Add(lblUnboxed);

        }
         // Button click event handler
        protected void Button1_Click(object sender, EventArgs e)
        {
            int valueType = Convert.ToInt32(txtValue.Text);

            // Boxing: converting value type to object type
            object boxed = valueType;
            lblBoxed.Text = "Boxed Value: " + boxed;

            // Unboxing: converting object type back to value type
            int unboxed = (int)boxed;
            lblUnboxed.Text = "Unboxed Value: " + unboxed;
        }
    }
}

