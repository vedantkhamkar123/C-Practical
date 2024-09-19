using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prac2A2
{
    public partial class Prac2A22 : System.Web.UI.Page
    {
        TextBox textBox1;
        RadioButton radioButton1, radioButton2, radioButton3, radioButton4, radioButton5, radioButton6;
        Button convertButton;
        Label resultLabel;
        protected void Page_Load(object sender, EventArgs e)
        {
            LiteralControl header = new LiteralControl("<h2>Currency Converter</h2>");
            form1.Controls.Add(header);

            // Create and configure TextBox for input
            Label label1 = new Label();
            label1.Text = "Enter Indian Rs: ";
            form1.Controls.Add(label1);

            textBox1 = new TextBox();
            textBox1.ID = "TextBox1";
            textBox1.Style.Add("margin-left", "40px");
            form1.Controls.Add(textBox1);

            form1.Controls.Add(new LiteralControl("<br /><br />"));

            // Create and configure RadioButtons for currency selection
            radioButton1 = new RadioButton();
            radioButton1.ID = "RadioButton1";
            radioButton1.Text = "US (dollar)";
            radioButton1.GroupName = "Currency";
            form1.Controls.Add(radioButton1);
            form1.Controls.Add(new LiteralControl("<br />"));

            radioButton2 = new RadioButton();
            radioButton2.ID = "RadioButton2";
            radioButton2.Text = "Japanese (yen)";
            radioButton2.GroupName = "Currency";
            form1.Controls.Add(radioButton2);
            form1.Controls.Add(new LiteralControl("<br />"));

            radioButton3 = new RadioButton();
            radioButton3.ID = "RadioButton3";
            radioButton3.Text = "China (yuan)";
            radioButton3.GroupName = "Currency";
            form1.Controls.Add(radioButton3);
            form1.Controls.Add(new LiteralControl("<br />"));

            radioButton4 = new RadioButton();
            radioButton4.ID = "RadioButton4";
            radioButton4.Text = "Bangladeshi (Taka)";
            radioButton4.GroupName = "Currency";
            form1.Controls.Add(radioButton4);
            form1.Controls.Add(new LiteralControl("<br />"));

            radioButton5 = new RadioButton();
            radioButton5.ID = "RadioButton5";
            radioButton5.Text = "Pakistan (PKR)";
            radioButton5.GroupName = "Currency";
            form1.Controls.Add(radioButton5);
            form1.Controls.Add(new LiteralControl("<br />"));

            radioButton6 = new RadioButton();
            radioButton6.ID = "RadioButton6";
            radioButton6.Text = "Russia (RUB)";
            radioButton6.GroupName = "Currency";
            form1.Controls.Add(radioButton6);
            form1.Controls.Add(new LiteralControl("<br /><br />"));

            // Create and configure Button for conversion
            convertButton = new Button();
            convertButton.ID = "ConvertButton";
            convertButton.Text = "Convert";
            convertButton.Click += new EventHandler(ConvertButton_Click);
            form1.Controls.Add(convertButton);

            // Create Label for result display
            resultLabel = new Label();
            resultLabel.ID = "ResultLabel";
            resultLabel.Text = "Ans";
            form1.Controls.Add(new LiteralControl("<br /><br />"));
            form1.Controls.Add(resultLabel);
        }
        protected void ConvertButton_Click(object sender, EventArgs e)
        {
            float rs;
            if (float.TryParse(textBox1.Text, out rs))
            {
                float ans = 0.0f;

                // Perform the currency conversion based on the selected RadioButton
                if (radioButton1.Checked)
                {
                    ans = rs / 83.77f;
                    resultLabel.Text = ans + " Dollar";
                }
                else if (radioButton2.Checked)
                {
                    ans = rs / 0.57f;
                    resultLabel.Text = ans + " Yen";
                }
                else if (radioButton3.Checked)
                {
                    ans = rs / 11.70f;
                    resultLabel.Text = ans + " Yuan";
                }
                else if (radioButton4.Checked)
                {
                    ans = rs / 0.72f;
                    resultLabel.Text = ans + " Taka";
                }
                else if (radioButton5.Checked)
                {
                    ans = rs / 0.30f;
                    resultLabel.Text = ans + " PKR";
                }
                else if (radioButton6.Checked)
                {
                    ans = rs / 0.99f;
                    resultLabel.Text = ans + " RUB";
                }
                else
                {
                    resultLabel.Text = "Please select a currency.";
                }
            }
            else
            {
                resultLabel.Text = "Please enter a valid number for INR.";
            }
        }
    }
}
