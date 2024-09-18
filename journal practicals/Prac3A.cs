#Console code
// Simulating a simple form interaction
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Instantiate Calendar object and call the method to interact with the user
        Calendar obj = new Calendar();
        obj.Run();
        
        // Keep the console window open
        System.Console.ReadLine();
    }
}

class Calendar
{
    public void Run()
    {
        // Simulate TextBox input for name
        System.Console.WriteLine("Enter Your Name: ");
        string name = System.Console.ReadLine();

        // Simulate DropDownList selection for favorite color
        List<string> colors = new List<string> { "Red", "Green", "Blue" };
        System.Console.WriteLine("Select Your Favorite Color: ");
        for (int i = 0; i < colors.Count; i++)
        {
            System.Console.WriteLine((i + 1) + ". " + colors[i]);
        }

        // Read color selection from user
        int colorChoice = int.Parse(System.Console.ReadLine()) - 1;
        string selectedColor = colors[colorChoice];

        // Simulate Button click to submit
        System.Console.WriteLine("\nSubmit the form by pressing Enter...");
        System.Console.ReadLine();

        // Display the result as if form was submitted
        System.Console.WriteLine("\nForm Submitted!");
        System.Console.WriteLine("Name: " + name);
        System.Console.WriteLine("Favorite Color: " + selectedColor);
    }
}

#Dynamic code
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AutoPostBack
{
    public partial class Auto1 : System.Web.UI.Page
    {
        TextBox txtName;
        Label lblMessage;
        DropDownList ddlColors;
        Label lblColor;
        Button btnSubmit;

        protected void Page_Load(object sender, EventArgs e)
        {
            // Create Label for TextBox
            Label lblTextBox = new Label();
            lblTextBox.Text = "Enter Your Name: ";
            form1.Controls.Add(lblTextBox);

            // Create TextBox dynamically
            txtName = new TextBox();
            txtName.ID = "txtName";
            txtName.AutoPostBack = true;
            txtName.TextChanged += new EventHandler(txtName_TextChanged);
            form1.Controls.Add(txtName);

            // Create Label for message
            lblMessage = new Label();
            lblMessage.ID = "lblMessage";
            form1.Controls.Add(lblMessage);

            // Create DropDownList dynamically
            Label lblDropDown = new Label();
            lblDropDown.Text = "<br /><br />Select Your Favorite Color: ";
            form1.Controls.Add(lblDropDown);

            ddlColors = new DropDownList();
            ddlColors.ID = "ddlColors";
            ddlColors.AutoPostBack = true;
            ddlColors.SelectedIndexChanged += new EventHandler(ddlColors_SelectedIndexChanged);
            ddlColors.Items.Add(new ListItem("Red", "Red"));
            ddlColors.Items.Add(new ListItem("Green", "Green"));
            ddlColors.Items.Add(new ListItem("Blue", "Blue"));
            form1.Controls.Add(ddlColors);

            // Create Label for selected color
            lblColor = new Label();
            lblColor.ID = "lblColor";
            form1.Controls.Add(lblColor);

            // Create Button dynamically
            btnSubmit = new Button();
            btnSubmit.ID = "btnSubmit";
            btnSubmit.Text = "Submit";
            btnSubmit.Click += new EventHandler(btnSubmit_Click);
            form1.Controls.Add(btnSubmit);
        }
        protected void txtName_TextChanged(object sender, EventArgs e)
        {
            lblMessage.Text = "Hello, " + txtName.Text + "!";
        }

        protected void ddlColors_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblColor.Text = "You selected: " + ddlColors.SelectedValue;
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "Form Submitted! Name: " + txtName.Text + ", Favorite Color: " + ddlColors.SelectedValue;
        }
    }
}

