<%@ Page Language="C#" MasterPageFile="~/DefaultMaster.master" AutoEventWireup="true" CodeFile="Assign2CrossPage.aspx.cs" Inherits="Assign2CrossPage" %>
<%@ PreviousPageType VirtualPath="~/Assign2.aspx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitlePlaceHolder" Runat="Server">
    Assignment 2 Cross Page- DB interface, cross-page, viewstate
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ArticlePlaceHolder" Runat="Server">   
    <div>
        <h2>This is the Cross-Page Post Back</h2>
        <asp:PlaceHolder ID="tablePlaceHolder" runat="server"></asp:PlaceHolder>
    </div> 
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="FooterPlaceHolder" Runat="Server">
    <div class="footer">Logan Brooke | Assignment 2 | CSCD 379</div>
</asp:Content>