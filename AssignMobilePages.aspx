<%
    @ Page Title="" Language="C#" MasterPageFile="~/DefaultMaster.master" AutoEventWireup="true" CodeFile="AssignMobilePages.aspx.cs" Inherits="AssignMobilePages" Async="true"
%>

<asp:Content ID="Content1" ContentPlaceHolderID="TitlePlaceHolder" Runat="Server">
    Mobile Assignment - Desktop Page
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ArticlePlaceHolder" Runat="Server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <h1>Dice Roller - Desktop Version</h1>
    <asp:Panel ID="DiceRollersPanel" runat="server">
        <asp:UpdatePanel ID="UpdatePaneld4" runat="server" UpdateMode="Conditional">
            <ContentTemplate>
                <asp:Image ID="imgD4" runat="server" />
                <asp:TextBox ID="txtD4" runat="server" Text="1" Columns="3"></asp:TextBox>
                <asp:Label ID="Label1" runat="server" Text="d4"></asp:Label>
                <asp:Button ID="btnD4" runat="server" Text="roll" OnClick="btnRoll_Click" />
                <asp:Label ID="lblD4" runat="server" Text=""></asp:Label>
            </ContentTemplate>
        </asp:UpdatePanel>
        <asp:UpdatePanel ID="UpdatePaneld6" runat="server">
            <ContentTemplate>
                <asp:Image ID="imgD6" runat="server" />
                <asp:TextBox ID="txtD6" runat="server" Text="1" Columns="3"></asp:TextBox>
                <asp:Label ID="Label2" runat="server" Text="d6"></asp:Label>
                <asp:Button ID="btnD6" runat="server" Text="roll" OnClick="btnRoll_Click" />
                <asp:Label ID="lblD6" runat="server" Text=""></asp:Label>
            </ContentTemplate>
        </asp:UpdatePanel>
        <asp:UpdatePanel ID="UpdatePaneld8" runat="server">
            <ContentTemplate>
                <asp:Image ID="imgD8" runat="server" />
                <asp:TextBox ID="txtD8" runat="server" Text="1" Columns="3"></asp:TextBox>
                <asp:Label ID="Label3" runat="server" Text="d8"></asp:Label>
                <asp:Button ID="btnD8" runat="server" Text="roll" OnClick="btnRoll_Click" />
                <asp:Label ID="lblD8" runat="server" Text=""></asp:Label>
            </ContentTemplate>
        </asp:UpdatePanel>
        <asp:UpdatePanel ID="UpdatePaneld10" runat="server">
            <ContentTemplate>
                <asp:Image ID="imgD10" runat="server" />
                <asp:TextBox ID="txtD10" runat="server" Text="1" Columns="3"></asp:TextBox>
                <asp:Label ID="Label5" runat="server" Text="d10"></asp:Label>
                <asp:Button ID="btnD10" runat="server" Text="roll" OnClick="btnRoll_Click" />
                <asp:Label ID="lblD10" runat="server" Text=""></asp:Label>
            </ContentTemplate>
        </asp:UpdatePanel>
        <asp:UpdatePanel ID="UpdatePaneld100" runat="server">
            <ContentTemplate>
                <asp:Image ID="imgD100" runat="server" />
                <asp:TextBox ID="txtD100" runat="server" Text="1" Columns="3"></asp:TextBox>
                <asp:Label ID="Label7" runat="server" Text="d100"></asp:Label>
                <asp:Button ID="btnD100" runat="server" Text="roll" OnClick="btnRoll_Click" />
                <asp:Label ID="lblD100" runat="server" Text=""></asp:Label>
            </ContentTemplate>
        </asp:UpdatePanel>
        <asp:UpdatePanel ID="UpdatePaneld12" runat="server">
            <ContentTemplate>
                <asp:Image ID="imgD12" runat="server" />
                <asp:TextBox ID="txtD12" runat="server" Text="1" Columns="3"></asp:TextBox>
                <asp:Label ID="Label9" runat="server" Text="d12"></asp:Label>
                <asp:Button ID="btnD12" runat="server" Text="roll" OnClick="btnRoll_Click" />
                <asp:Label ID="lblD12" runat="server" Text=""></asp:Label>
            </ContentTemplate>
        </asp:UpdatePanel>
        <asp:UpdatePanel ID="UpdatePaneld20" runat="server">
            <ContentTemplate>
                <asp:Image ID="imgD20" runat="server" />
                <asp:TextBox ID="txtD20" runat="server" Text="1" Columns="3"></asp:TextBox>
                <asp:Label ID="Label11" runat="server" Text="d20"></asp:Label>
                <asp:Button ID="btnD20" runat="server" Text="roll" OnClick="btnRoll_Click" />
                <asp:Label ID="lblD20" runat="server" Text=""></asp:Label>
            </ContentTemplate>
        </asp:UpdatePanel>
    </asp:Panel>
    <asp:UpdatePanel ID="UpdatePanelHistory" runat="server" UpdateMode="Conditional">
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="btnD4" />
            <asp:AsyncPostBackTrigger ControlID="btnD6"/>
            <asp:AsyncPostBackTrigger ControlID="btnD8"/>
            <asp:AsyncPostBackTrigger ControlID="btnD10"/>
            <asp:AsyncPostBackTrigger ControlID="btnD100"/>
            <asp:AsyncPostBackTrigger ControlID="btnD12"/>
            <asp:AsyncPostBackTrigger ControlID="btnD20"/>
        </Triggers>
        <ContentTemplate>
            <asp:TextBox ID="txtHistory" runat="server" Text="" TextMode="MultiLine" Columns="20" Rows="15" Enabled="true"></asp:TextBox>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="FooterPlaceHolder" Runat="Server">
    <div class="footer">Logan Brooke | Assignment Mobile Pages | CSCD 379</div>
</asp:Content>

