<%@ Page Language="C#" MasterPageFile="~/DefaultMaster.master" AutoEventWireup="true" CodeFile="Lab4.aspx.cs" Inherits="Lab4" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitlePlaceHolder" Runat="Server">
    Lab 4 - AJAX
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ArticlePlaceHolder" Runat="Server">      
    <div>
        <asp:Image ID="imgLavaLamp" runat="server" ImageUrl="~/_images/lab4/lava_lamp.gif" />
        <br />
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server" class="updatePanel">
            <ContentTemplate>
                <asp:Label ID="lblTime" runat="server"></asp:Label>
                <br />
                <asp:Button ID="btnRefreshTime" runat="server" Text="Refresh Time" OnClick="btnRefreshTime_Click" />
            </ContentTemplate>
        </asp:UpdatePanel>
        <br />
        <asp:Button ID="btnPart2" runat="server" Text="To Part 2" OnClick="btnPart2_Click" />
    </div> 
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="FooterPlaceHolder" Runat="Server">
    <div class="footer">Logan Brooke | Lab 4 | CSCD 379</div>
</asp:Content>