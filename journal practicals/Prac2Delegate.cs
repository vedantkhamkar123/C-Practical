using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pract2Delegate
{
    public delegate int MathOperation(int a, int b);
    public partial class Pract2Delegate : System.Web.UI.Page
    {
        protected Label lblTitle;
        protected Label lblNum1;
        protected TextBox txtNum1;
        protected Label lblNum2;
        protected TextBox txtNum2;
        protected Button btnCalculate;
        protected Label lblResultAdd;
        protected Label lblResultSubtract;
        protected void Page_Load(object sender, EventArgs e)
        {
             // Title Label
            lblTitle = new Label();
            lblTitle.Text = "Delegate Demo";
            lblTitle.BorderStyle = BorderStyle.Groove;
            this.form1.Controls.Add(lblTitle);

            this.form1.Controls.Add(new Literal { Text = "<br /><br />" });

            // Number 1 Label
            lblNum1 = new Label();
            lblNum1.Text = "Enter the Number 1: ";
            this.form1.Controls.Add(lblNum1);

            // TextBox 1
            txtNum1 = new TextBox();
            txtNum1.ID = "txtNum1";
            this.form1.Controls.Add(txtNum1);

            this.form1.Controls.Add(new Literal { Text = "<br /><br />" });

            // Number 2 Label
            lblNum2 = new Label();
            lblNum2.Text = "Enter the Number 2: ";
            this.form1.Controls.Add(lblNum2);

            // TextBox 2
            txtNum2 = new TextBox();
            txtNum2.ID = "txtNum2";
            this.form1.Controls.Add(txtNum2);

            this.form1.Controls.Add(new Literal { Text = "<br /><br />" });

            // Button for Delegate Demo
            btnCalculate = new Button();
            btnCalculate.Text = "Delegate Demo";
            btnCalculate.Click += new EventHandler(Button1_Click);
            this.form1.Controls.Add(btnCalculate);

            this.form1.Controls.Add(new Literal { Text = "<br /><br />" });

            // Result Labels
            lblResultAdd = new Label();
            lblResultAdd.ID = "lblResultAdd";
            this.form1.Controls.Add(lblResultAdd);

            this.form1.Controls.Add(new Literal { Text = "<br /><br />" });

            lblResultSubtract = new Label();
            lblResultSubtract.ID = "lblResultSubtract";
            this.form1.Controls.Add(lblResultSubtract);
        }
        // Delegate Methods
        int Add(int a, int b)
        {
            return a + b;
        }

        int Subtract(int a, int b)
        {
            return a - b;
        }

        // Button click event handler
        protected void Button1_Click(object sender, EventArgs e)
        {
            // Parse the input values from the TextBoxes
            int x = Convert.ToInt32(txtNum1.Text);
            int y = Convert.ToInt32(txtNum2.Text);

            // Delegate operations
            MathOperation add = new MathOperation(Add);
            MathOperation subtract = new MathOperation(Subtract);

            // Display the results in the dynamically created Labels
            lblResultAdd.Text = "Addition Result: " + add(x, y).ToString();
            lblResultSubtract.Text = "Subtraction Result: " + subtract(x, y).ToString();
        }
    }
}
