<%@ Page Language="C#" MasterPageFile="~/DefaultMaster.master" AutoEventWireup="true" CodeFile="Lab2.aspx.cs" Inherits="Lab2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitlePlaceHolder" Runat="Server">
    Lab 2 - Currency Converter Part 2
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
        <input type = "submit" value = "Show Graph" id = "ShowGraph" runat = "server" onserverclick="ShowGraph_ServerClick"/>
        <input type = "submit" value = "Redirect" id = "Redirect" runat = "server" onserverclick="Redirect_ServerClick"/>
        <br/> <br/>
        <img id="Graph" src="" alt="Currency Graph" runat="server"/>
        <p style="font-weight: bold" id="Result" runat="server"></p>
    </div>   
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="FooterPlaceHolder" Runat="Server">
    <div class="footer">Logan Brooke | Lab 2 | CSCD 379</div>
</asp:Content>