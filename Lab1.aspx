<%@ Page Language="C#" MasterPageFile="~/DefaultMaster.master" AutoEventWireup="true" CodeFile="Lab1.aspx.cs" Inherits="Lab1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitlePlaceHolder" Runat="Server">
    Lab 1 - Currency Converter
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ArticlePlaceHolder" Runat="Server">   
    <div>
        Convert: &nbsp;
        <input type="text" id="US" runat="server" />
        &nbsp; U.S. dollars to &nbsp;
        <select id="Currency" runat="server" />
        <br />
        <br />
        <input type="submit" value="OK" id="Convert" runat="server" onserverclick="Convert_ServerClick" />
        <p style="font-weight: bold" id="Result" runat="server"></p>
    </div> 
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="FooterPlaceHolder" Runat="Server">
    <div class="footer">Logan Brooke | Lab 1 | CSCD 379</div>
</asp:Content>