using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prac2A3
{
    public partial class Prac2A33 : System.Web.UI.Page
    {
        TextBox textBoxA, textBoxB, textBoxC;
        Button calculateButton;
        Label resultLabel, rootLabel;
        protected void Page_Load(object sender, EventArgs e)
        {
            LiteralControl header = new LiteralControl("<h2>Quadratic Equation Solver</h2>");
            this.form1.Controls.Add(header);

            // Instruction
            LiteralControl instruction = new LiteralControl("<p>Enter the coefficients of the quadratic equation ax^2 + bx + c = 0:</p>");
            this.form1.Controls.Add(instruction);

            // TextBox for 'a'
            this.form1.Controls.Add(new LiteralControl("<label for='TextBoxA'>&nbsp;a:</label>"));
            textBoxA = new TextBox();
            textBoxA.ID = "TextBoxA";
            this.form1.Controls.Add(textBoxA);
            this.form1.Controls.Add(new LiteralControl("<br />"));

            // TextBox for 'b'
            this.form1.Controls.Add(new LiteralControl("<label for='TextBoxB'>b:</label>"));
            textBoxB = new TextBox();
            textBoxB.ID = "TextBoxB";
            this.form1.Controls.Add(textBoxB);
            this.form1.Controls.Add(new LiteralControl("<br />"));

            // TextBox for 'c'
            this.form1.Controls.Add(new LiteralControl("<label for='TextBoxC'>c:</label>"));
            textBoxC = new TextBox();
            textBoxC.ID = "TextBoxC";
            this.form1.Controls.Add(textBoxC);
            this.form1.Controls.Add(new LiteralControl("<br />"));

            // Calculate Button
            calculateButton = new Button();
            calculateButton.ID = "CalculateButton";
            calculateButton.Text = "Calculate Roots";
            calculateButton.Click += new EventHandler(CalculateRoots);
            this.form1.Controls.Add(calculateButton);
            this.form1.Controls.Add(new LiteralControl("<br />"));

            // Label for displaying results (roots description)
            resultLabel = new Label();
            resultLabel.ID = "Label2";
            resultLabel.Text = "Result";
            this.form1.Controls.Add(resultLabel);
            this.form1.Controls.Add(new LiteralControl("<br />"));

            // Label for displaying root values
            rootLabel = new Label();
            rootLabel.ID = "Label1";
            rootLabel.Text = "Ans";
            this.form1.Controls.Add(rootLabel);
        }
        protected void CalculateRoots(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(textBoxA.Text);
                int b = int.Parse(textBoxB.Text);
                int c = int.Parse(textBoxC.Text);

                double discriminant = b * b - 4 * a * c;
                double x1, x2;

                if (discriminant == 0)
                {
                    resultLabel.Text = "Both roots are real and equal. ";
                    x1 = -b / (2.0 * a);
                    x2 = x1;
                    rootLabel.Text = "Root x1: " + x1 + " Root x2: " + x2;
                }
                else if (discriminant > 0)
                {
                    resultLabel.Text = "Roots are real and unequal. ";
                    x1 = (-b - Math.Sqrt(discriminant)) / (2.0 * a);
                    x2 = (-b + Math.Sqrt(discriminant)) / (2.0 * a);
                    rootLabel.Text = "Root x1: " + x1 + " Root x2: " + x2;
                }
                else
                {
                    resultLabel.Text = "Roots are imaginary. No real solution.";
                    rootLabel.Text = "";
                }
            }
            catch (Exception ex)
            {
                resultLabel.Text = "Error: " + ex.Message;
                rootLabel.Text = "";
            }
        }
    }
}

#console
class QuadraticDemo
{
    public void QuadraticMethod()
    {
        int a,b,c,ans;
        double x1,x2;
        a=int.Parse(System.Console.ReadLine());
        b=int.Parse(System.Console.ReadLine());
        c=int.Parse(System.Console.ReadLine());

        ans=b*b-4*a*c;
        if(ans==0)
        {
            System.Console.WriteLine("both root is real and equal .");
            x1=-b/2*a;
            x2=x1;
            System.Console.WriteLine("Root of x1 is := "+x1+"\nRoot of x2 is := "+x2);
        }
        else if(ans>0)
        {
            System.Console.WriteLine("Root is real and unequal .");
            x1=(-b-System.Math.Sqrt(ans))/2*a;
            x2=(-b+System.Math.Sqrt(ans))/2*a;
            System.Console.WriteLine("Root of x1 is := "+x1+"\nRoot of x2 is := "+x2);
        }
        else
        {
            System.Console.WriteLine("Roots are imaginary ..\nNo Solution.");
        }
        
    }
}
class Quadratic2A3
{
    public static void Main(string[] args)
    {
        QuadraticDemo obj=new QuadraticDemo();
        obj.QuadraticMethod();
    }
}
