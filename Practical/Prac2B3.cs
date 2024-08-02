<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Prac2B3.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form2" runat="server">
    <div>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server" Text="Constructor Overloading"></asp:Label>
    </div>
    <br />
    <asp:Label ID="Label4" runat="server" Text="parameterized Constructor"></asp:Label>
    <br />
    <br />
    <asp:Label ID="Label2" runat="server" Text="Enter a 1st no := "></asp:Label>
    <asp:TextBox ID="TextBox1" runat="server" style="margin-left: 36px"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label3" runat="server" Text="Enter a 2nd no := "></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server" style="margin-left: 33px"></asp:TextBox>
    <p>
        <br />
        <asp:Label ID="Label5" runat="server" Text="non-parameterized Constructor"></asp:Label>
        <br />
        <br />
    <asp:Label ID="Label6" runat="server" Text="Enter a 1st no := "></asp:Label>
    <asp:TextBox ID="res" runat="server" style="margin-left: 36px"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label7" runat="server" Text="Enter a 2nd no := "></asp:Label>
        <asp:TextBox ID="TextBox6" runat="server" style="margin-left: 33px"></asp:TextBox>
    </p>
    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Button" />
    <p>
        <asp:TextBox ID="TextBox3" runat="server" Width="283px"></asp:TextBox>
        <asp:TextBox ID="TextBox4" runat="server" Width="344px"></asp:TextBox>
    </p>
    </form>
    <form id="form1" runat="server">
    <div>
    
    </div>
    </form>
</body>
</html>


using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prac2B3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                TextBox3.Text = "5";
                TextBox4.Text = "9";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int userInput1= int.Parse(TextBox1.Text);
            int userInput2 = int.Parse(TextBox2.Text);
            Fun obj1 = new Fun(userInput1, userInput2);
            Fun obj2 = new Fun();
        }

    }

    public partial class Fun : WebForm1
    {
        //int a = int.Parse(TextBox5.Text);
        //int b = int.Parse(TextBox6.Text);
        int a=5,b=9,c;
        public Fun()
        {
            c = a + b;
            
            TextBox3.Text = "non-parameterized function := 5+9 = " + c;
        }
        public Fun(int a, int b)
        {
            c = a + b;
            TextBox4.Text = "parameterized function := " + a + "+" + b + " = " + c;
        }
    }
}
