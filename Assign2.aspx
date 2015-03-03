<%@ Page Language="C#" MasterPageFile="~/DefaultMaster.master" AutoEventWireup="true" CodeFile="Assign2.aspx.cs" Inherits="Assign2" %>

<asp:Content ID="Content4" ContentPlaceHolderID="TitlePlaceHolder" Runat="Server">
    Assignment 2 - DB interface, cross-page, viewstate
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ArticlePlaceHolder" Runat="Server">
        <asp:Label ID="lblStatus" runat="server" Text="Label"></asp:Label>
        <div><asp:PlaceHolder ID="tablePlaceHolder" runat="server"></asp:PlaceHolder></div>
        <asp:Button runat="server" ID="btnCrossPage" PostBackUrl="Assign2CrossPage.aspx" Text="Cross-Page Postback" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="FooterPlaceHolder" Runat="Server">
    <div class="footer">Logan Brooke | Assignment 2 | CSCD 379</div>
</asp:Content>