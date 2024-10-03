using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pract1Floyd
{
    public partial class Pract1Floydd : System.Web.UI.Page
    {
        protected Label lblTitle;
        protected Label lblRows;
        protected TextBox txtRows;
        protected Button btnSubmit;
        protected Label lblResult;
        protected void Page_Load(object sender, EventArgs e)
        {
            // Dynamically creating controls
            lblTitle = new Label();
            lblTitle.Text = "Floyd's Triangle";
            this.form1.Controls.Add(lblTitle);  // Add the label to the form
            
            // Line breaks
            this.form1.Controls.Add(new Literal { Text = "<br /><br />" });

            lblRows = new Label();
            lblRows.Text = "Enter Number of Rows: ";
            this.form1.Controls.Add(lblRows);  // Add the label to the form

            // Create TextBox
            txtRows = new TextBox();
            txtRows.ID = "txtRows";  // ID is important to retain state on postback
            this.form1.Controls.Add(txtRows);  // Add the textbox to the form
            
            // Line breaks
            this.form1.Controls.Add(new Literal { Text = "<br /><br />" });

            // Create Button
            btnSubmit = new Button();
            btnSubmit.Text = "Generate";
            btnSubmit.Click += new EventHandler(Button1_Click);  // Add event handler for button click
            this.form1.Controls.Add(btnSubmit);  // Add the button to the form

            // Line breaks
            this.form1.Controls.Add(new Literal { Text = "<br /><br />" });

            // Create Label for Result
            lblResult = new Label();
            lblResult.ID = "lblResult";
            this.form1.Controls.Add(lblResult);  // Add the result label to the form
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            int numOfRows;
            if (int.TryParse(txtRows.Text, out numOfRows))  // Parse input from TextBox
            {
                int number = 1;
                StringBuilder sb = new StringBuilder();
                for (int i = 1; i <= numOfRows; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        sb.Append(number + " ");
                        number++;
                    }
                    sb.Append("<br />");
                }
                lblResult.Text = sb.ToString();  // Display Floyd's triangle in result label
            }
            else
            {
                lblResult.Text = "Please enter a valid number.";  // Error message for invalid input
            }
        }
    }
}
