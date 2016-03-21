<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SaveProducts.aspx.cs" Inherits="CompanyGUI.SaveProducts" %>
<asp:Content ID="Content1" runat="server" contentplaceholderid="MainContent">
    <p>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        NameProduct</p>
    <p>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        Description</p>
    <p>
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        Image</p>
    <p>
        <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="ObjectDataSource1" DataTextField="CategoryId" DataValueField="CategoryId">
        </asp:DropDownList>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="getCategories" TypeName="CompanyService.CompanyService"></asp:ObjectDataSource>
        CategoriId</p>
    <p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
    </p>
</asp:Content>

