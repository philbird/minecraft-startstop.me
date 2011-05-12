<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">

<p>
    <asp:TextBox ID="uxEmailAddress" runat=server></asp:TextBox>
</p>
<p>
    <asp:TextBox ID="uxPassword" runat=server></asp:TextBox>
</p>
    
    
    <p>
    <asp:FileUpload ID="uxUpload" runat=server  />
    
    <asp:Button ID="uxDoUpload" runat=server Text="Upload" 
    onclick="uxDoUpload_Click" />
    </p>
</asp:Content>

