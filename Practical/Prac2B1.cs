<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Prac2B1.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server" Text="Function Overloading"></asp:Label>
    
    </div>
    <asp:Label ID="Label2" runat="server" Text="Enter a 1st no := "></asp:Label>
    <asp:TextBox ID="TextBox1" runat="server" style="margin-left: 36px"></asp:TextBox>
    <p>
        <asp:Label ID="Label3" runat="server" Text="Enter a 2nd no := "></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server" style="margin-left: 33px"></asp:TextBox>
    </p>
    <asp:Button ID="Button1" runat="server" Text="Button" onclick="Button1_Click" />
    <p>
        <asp:TextBox ID="TextBox3" runat="server" Width="283px"></asp:TextBox>
        <asp:TextBox ID="TextBox4" runat="server" Width="344px"></asp:TextBox>
    </p>
    </form>
</body>
</html>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prac2B1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                TextBox1.Text = "0";
                TextBox2.Text = "0";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int ans1,ans2;
            int userInput1 = int.Parse(TextBox1.Text);
            int userInput2 = int.Parse(TextBox2.Text);

            Fun obj = new Fun();
            ans1 = obj.add();
            TextBox3.Text = "non-parameterized function := " + ans1.ToString();
                
            ans2=obj.add(userInput1, userInput2);
            TextBox4.Text = "parameterized function := " + ans2.ToString();

        }
        class Fun
        {
            int a = 4, b = 5, c;
            public int add()
            {
                c = a + b;
                return c;
            }
            public int add(int a, int b)
            {
                c = a + b;
                return c;
            }
        }
    }
}
