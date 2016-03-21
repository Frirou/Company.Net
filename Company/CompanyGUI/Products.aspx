<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Products.aspx.cs" Inherits="CompanyGUI.Products" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <span style="color: #FF0000; font-weight: 700; font-style: italic">List of categories<br />
    </span>
    <asp:DropDownList ID="MinProductsCount" AutoPostBack="true" runat="server">
        <asp:ListItem Value="1"></asp:ListItem>
        <asp:ListItem>2</asp:ListItem>
        <asp:ListItem>3</asp:ListItem>
        <asp:ListItem>22</asp:ListItem>
    </asp:DropDownList>
    <asp:GridView ID="GridView1" SelectMethod="GetCategories" runat="server" AutoGenerateColumns="False" >
        <Columns>
            <asp:BoundField DataField="CategoryId" HeaderText="CategoryId" SortExpression="CategoryId" />
            <asp:BoundField DataField="CategoryName" HeaderText="CategoryName" SortExpression="CategoryName" />
            <asp:BoundField DataField="Description" HeaderText="Description" SortExpression="Description" />
            <asp:BoundField DataField="Products.count" HeaderText="NumberProduct" SortExpression="NumberProduct" />
            <asp:HyperLinkField HeaderText="Select Category" NavigateUrl="~/Products.aspx" Text="Select " DataNavigateUrlFields="CategoryId" DataNavigateUrlFormatString="/Products.aspx?id={0}" />
        </Columns>
    </asp:GridView>
   
    <asp:GridView ID="GridView2" SelectMethod="getProducts" runat="server" AutoGenerateColumns="False" >
        <Columns>
            <asp:BoundField DataField="ProductId" HeaderText="ProductId" SortExpression="ProductId" />
            <asp:BoundField DataField="ProductName" HeaderText="ProductName" SortExpression="ProductName" />
            <asp:BoundField DataField="CategoryId" HeaderText="CategoryId" SortExpression="CategoryId" />
            <asp:BoundField DataField="Description" HeaderText="Description" SortExpression="Description" />
            <asp:BoundField DataField="ImagePath" HeaderText="ImagePath" SortExpression="ImagePath" />
            
        </Columns>
    </asp:GridView>
    
    <%--<asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="getCategories" TypeName="CompanyService.CompanyService" OnSelecting="ObjectDataSource1_Selecting"></asp:ObjectDataSource>--%>
</asp:Content>
