using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Rev1D5
{
    public partial class Rev1d5 : System.Web.UI.Page
    {
        protected Label Label6;
        protected TextBox TextBox1;
        protected Button Button1;
        protected Label Label2;
        protected Label Label3;
        protected Label Label4;
        protected Label Label5;

        protected void Page_Load(object sender, EventArgs e)
        {
            CreateControls();
        }
        private void CreateControls()
        {
            Label6 = new Label { Text = "Enter a number: " };
            TextBox1 = new TextBox { ID = "TextBox1" };
            TextBox1.Attributes.Add("style", "margin-left: 12px;"); // Correct way to set style

            Button1 = new Button { Text = "Submit", ID = "Button1" };
            Button1.Click += new EventHandler(Button1_Click);

            Label2 = new Label { Text = "Reverse No: " };
            Label3 = new Label { ID = "Label3", Text = "0" };
            Label4 = new Label { Text = "Sum of No: " };
            Label5 = new Label { ID = "Label5", Text = "0" };

            // Add controls to the form
            form1.Controls.Add(Label6);
            form1.Controls.Add(TextBox1);
            form1.Controls.Add(Button1);
            form1.Controls.Add(new LiteralControl("<br /><br />")); // Add spacing
            form1.Controls.Add(Label2);
            form1.Controls.Add(Label3);
            form1.Controls.Add(new LiteralControl("&nbsp;&nbsp;&nbsp;")); // Add spacing
            form1.Controls.Add(Label4);
            form1.Controls.Add(Label5);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int a;

            // Validate input
            if (int.TryParse(TextBox1.Text, out a))
            {
                int b = a, tem = 0;
                int sum = 0, rev = 0;

                while (b != 0)
                {
                    tem = b % 10;
                    rev = rev * 10 + tem;
                    b /= 10;
                    sum += tem;
                }

                // Update labels with results
                Label3.Text = rev.ToString();
                Label5.Text = sum.ToString();
            }
            else
            {
                // Handle invalid input gracefully
                Label3.Text = "Invalid input";
                Label5.Text = "0";
            }
        }
    }
}

#console
namespace ConsoleApp
{
    public class NumberProcessor
    {
        public (int, int) ProcessNumber(int n)
        {
            int b = n, t = 0, s = 0, r = 0;
            while (b != 0)
            {
                t = b % 10;
                r = r * 10 + t;
                b /= 10;
                s += t;
            }
            return (r, s);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Enter a number:");
            if (int.TryParse(System.Console.ReadLine(), out int n))
            {
                NumberProcessor p = new NumberProcessor();
                var (r, s) = p.ProcessNumber(n);
                System.Console.WriteLine($"Reversed: {r}\nSum: {s}");
            }
            else
                System.Console.WriteLine("Invalid input.");
            System.Console.ReadKey();
        }
    }
}
