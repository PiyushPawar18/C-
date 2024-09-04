
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace practical1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        Label lbl1,lbl2,lbl3,lbl4,lbl5,lbl6;
        TextBox tbx1, tbx2;
        Button btn1, btn2, btn3, btn4;
        Literal ltr;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            lbl1 = new Label();
            lbl1.Text = "Number 1 =";
            this.form1.Controls.Add(lbl1);
           
            tbx1 = new TextBox();
            this.form1.Controls.Add(tbx1);
            ltr = new Literal();
            ltr.Text = "</br>";
            this.form1.Controls.Add(ltr);

            lbl2 = new Label();
            lbl2.Text = "Number 2 =";
            this.form1.Controls.Add(lbl2);
            tbx2 = new TextBox();
            this.form1.Controls.Add(tbx2);
            ltr = new Literal();
            ltr.Text = "</br>";
            this.form1.Controls.Add(ltr);

            btn1 = new Button();
            btn1.Text = "Add";
            btn1.Click += btn1_click;
            this.form1.Controls.Add(btn1);

            btn2 = new Button();
            btn2.Text = "Subtract";
            btn2.Click += btn2_click;
            this.form1.Controls.Add(btn2);

            btn3 = new Button();
            btn3.Text = "Multiply";
            btn3.Click += btn3_click;
            this.form1.Controls.Add(btn3);

            btn4 = new Button();
            btn4.Text = "Divide";
            btn4.Click += btn4_click;
            this.form1.Controls.Add(btn4);
            ltr = new Literal();
            ltr.Text = "</br>";
            this.form1.Controls.Add(ltr);

            lbl3 = new Label();
            this.form1.Controls.Add(lbl3);
            ltr = new Literal();
            ltr.Text = "</br>";
            this.form1.Controls.Add(ltr);

            lbl4 = new Label();
            this.form1.Controls.Add(lbl4);
            ltr = new Literal();
            ltr.Text = "</br>";
            this.form1.Controls.Add(ltr);

            lbl5 = new Label();
            this.form1.Controls.Add(lbl5);
            ltr = new Literal();
            ltr.Text = "</br>";
            this.form1.Controls.Add(ltr);

            lbl6 = new Label();
            this.form1.Controls.Add(lbl6);
            ltr = new Literal();
            ltr.Text = "</br>";
            this.form1.Controls.Add(ltr);
        }

        protected void btn1_click(object sender, EventArgs e)
        {
            int a, b;
            a = int.Parse(tbx1.Text);
            b = int.Parse(tbx2.Text);

            int res = a + b;
            lbl3.Text = "Addition=" + res;
        }

        protected void btn2_click(object sender, EventArgs e)
        {
            int a, b;
            a = int.Parse(tbx1.Text);
            b = int.Parse(tbx2.Text);

            int res = a - b;
            lbl4.Text = "subtraction=" + res;
        }

        protected void btn3_click(object sender, EventArgs e)
        {
            int a, b;
            a = int.Parse(tbx1.Text);
            b = int.Parse(tbx2.Text);

            int res = a * b;
            lbl5.Text = "Multiplication=" + res;
        }

        protected void btn4_click(object sender, EventArgs e)
        {
            int a, b;
            a = int.Parse(tbx1.Text);
            b = int.Parse(tbx2.Text);

            int res = a / b;
            lbl6.Text = "Division=" + res;
        }


    }
}
       
 
