using System;
using System.Collections.Generic;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace prac3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private static List<string> arrayList = new List<string>();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Ensure the CheckBoxList is empty on first load
                CheckBoxList1.Items.Clear();
            }
        }

        protected void AddButton_Click(object sender, EventArgs e)
        {
            string newItem = TextBox1.Text;
            if (!string.IsNullOrEmpty(newItem))
            {
                // Add item to the arrayList, DropDownList, and CheckBoxList
                arrayList.Add(newItem);
                DropDownList1.Items.Add(newItem);
                CheckBoxList1.Items.Add(newItem);
                Label1.Text = "Added Item: " + newItem;
            }
        }

        protected void RemoveButton_Click(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedItem != null)
            {
                string selectedItem = DropDownList1.SelectedItem.Text;
                arrayList.Remove(selectedItem);
                DropDownList1.Items.Remove(selectedItem);
                CheckBoxList1.Items.Remove(CheckBoxList1.Items.FindByText(selectedItem));
                Label1.Text = "Removed Item: " + selectedItem;
            }
            else
            {
                Label1.Text = "No item selected to remove.";
            }
        }

        protected void CountButton_Click(object sender, EventArgs e)
        {
            // Count items in the ListBox and display the count on Label1
            Label2.Text = "Number of Items in ListBox: " + ListBox1.Items.Count;
        }

        protected void AddToListBoxButton_Click(object sender, EventArgs e)
        {
            foreach (ListItem item in CheckBoxList1.Items)
            {
                if (item.Selected)
                {
                    // Add selected items from CheckBoxList to ListBox
                    if (!ListBox1.Items.Contains(item)) // Prevent duplicate items in ListBox
                    {
                        ListBox1.Items.Add(item.Text);
                    }
                }
            }
        }

        protected void EmptyButton_Click(object sender, EventArgs e)
        {
            // Clear all lists and labels
            arrayList.Clear();
            DropDownList1.Items.Clear();
            CheckBoxList1.Items.Clear();
            ListBox1.Items.Clear();
            Label1.Text = "All items cleared!";
            Label2.Text = "";
        }
    }
}



<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="prac3.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
            <asp:TextBox ID="TextBox1" runat="server" AutoPostBack="True"></asp:TextBox>
            <asp:Button ID="AddButton" runat="server" Text="Add" OnClick="AddButton_Click" /><br /><br />
            
            <asp:Label ID="Label1" runat="server" Text="Display Added Item"></asp:Label><br /><br />
            
            <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
            <asp:Button ID="RemoveButton" runat="server" Text="Remove" OnClick="RemoveButton_Click" /><br /><br />
            
            <asp:CheckBoxList ID="CheckBoxList1" runat="server" AutoPostBack="True">
                <asp:ListItem Text="Item 1"></asp:ListItem>
                <asp:ListItem Text="Item 2"></asp:ListItem>
                <asp:ListItem Text="Item 3"></asp:ListItem>
            </asp:CheckBoxList><br />
            
            <asp:Button ID="AddToListBoxButton" runat="server" Text="Add to ListBox" OnClick="AddToListBoxButton_Click" /><br /><br />
            
            <asp:ListBox ID="ListBox1" runat="server" AutoPostBack="True"></asp:ListBox><br /><br />
            
            <asp:Button ID="CountButton" runat="server" Text="Count" OnClick="CountButton_Click" />&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label2" runat="server"></asp:Label>
            <br /><br />
            
            <asp:Button ID="EmptyButton" runat="server" Text="Empty" OnClick="EmptyButton_Click" /><br /><br />
        </div>
    </form>
</body>
</html>
