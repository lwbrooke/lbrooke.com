<%@ Page Language="C#" MasterPageFile="~/DefaultMaster.master" AutoEventWireup="true" CodeFile="Lab4Part2.aspx.cs" Inherits="Lab4Part2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitlePlaceHolder" Runat="Server">
    Lab 4 - AJAX Part 2
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ArticlePlaceHolder" Runat="Server">           
    <div>
        <asp:ScriptManager ID="ScriptManager1" runat="server" />
        <asp:UpdatePanel runat="server" id="UpdatePanel" updatemode="Conditional" class="updatePanel">
            <Triggers>
                <asp:AsyncPostBackTrigger controlid="UpdateButton2" eventname="Click" />
            </Triggers>
            <ContentTemplate>
                <asp:Label runat="server" id="DateTimeLabel1" />
                <br />
                <asp:Button runat="server" id="UpdateButton1" onclick="UpdateButton_Click" text="Update" />
            </ContentTemplate>
        </asp:UpdatePanel>
        <br />
        <asp:UpdatePanel runat="server" id="UpdatePanel1" updatemode="Conditional" class="updatePanel">
            <ContentTemplate>
                <asp:Label runat="server" id="DateTimeLabel2" />
                <br />
                <asp:Button runat="server" id="UpdateButton2" onclick="UpdateButton_Click" text="Update" />
            </ContentTemplate>
        </asp:UpdatePanel>
    </div> 
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="FooterPlaceHolder" Runat="Server">
    <div class="footer">Logan Brooke | Lab 4 | CSCD 379</div>
</asp:Content>