using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prac2A1
{
    public partial class Prac2A11 : System.Web.UI.Page
    {
        TextBox textBox1;
        Label label1, label2, label3, label4, label5;
        Button button1;
        protected void Page_Load(object sender, EventArgs e)
        {
            label1 = new Label();
            label1.ID = "Label1";
            label1.Text = "Enter a no:=";

            textBox1 = new TextBox();
            textBox1.ID = "TextBox1";
            textBox1.Style.Add("margin-left", "12px");

            button1 = new Button();
            button1.ID = "Button1";
            button1.Text = "Button";
            button1.Click += new EventHandler(Button1_Click);

            label2 = new Label();
            label2.ID = "Label2";
            label2.Text = "Factorial of series is :=";

            label3 = new Label();
            label3.ID = "Label3";
            label3.Text = "0";

            label4 = new Label();
            label4.ID = "Label4";
            label4.Text = "Factorial of given no is :=";

            label5 = new Label();
            label5.ID = "Label5";
            label5.Text = "0";

            // Add controls to the page
            form1.Controls.Add(label1);
            form1.Controls.Add(textBox1);
            form1.Controls.Add(new LiteralControl("<br /><div>"));
            form1.Controls.Add(button1);
            form1.Controls.Add(new LiteralControl("<br /></div>"));
            form1.Controls.Add(label2);
            form1.Controls.Add(new LiteralControl("&nbsp;&nbsp;&nbsp;"));
            form1.Controls.Add(label3);
            form1.Controls.Add(new LiteralControl("&nbsp;&nbsp;<br />"));
            form1.Controls.Add(label4);
            form1.Controls.Add(new LiteralControl("&nbsp;&nbsp;&nbsp;"));
            form1.Controls.Add(label5);
            form1.Controls.Add(new LiteralControl("&nbsp;&nbsp;"));

            if (!IsPostBack)
            {
                label3.Text = "";
                label5.Text = "";
            }

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            int num;
            if (int.TryParse(textBox1.Text, out num) && num > 0)
            {
                int a = num;
                int tem = 1;
                string result = "";

                for (int i = 0; i < num; i++)
                {
                    tem *= a;
                    result += a;

                    if (a > 1)
                    {
                        result += " * ";
                    }

                    a--;
                }

                label3.Text = result;
                label5.Text = tem.ToString();
            }
            else
            {
                label3.Text = "Please enter a positive integer.";
                label5.Text = "";
            }
        }
    }
}
