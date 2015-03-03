<%@ Page Title="" Language="C#" MasterPageFile="~/DefaultMaster.master" AutoEventWireup="true" CodeFile="Contact.aspx.cs" Inherits="Contact" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitlePlaceHolder" Runat="Server">
    Contact
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ArticlePlaceHolder" Runat="Server">
    <h1>Send me an email</h1>
    <h2>Your email</h2>
    <asp:TextBox ID="txtEmail" runat="server" Columns="60"></asp:TextBox>
    <asp:CustomValidator ID="validatorEmail" runat="server" ErrorMessage="" ControlToValidate="txtEmail" OnServerValidate="validatorEmail_ServerValidate" CssClass="validator" ValidateEmptyText="True" />
    <h2>Subject</h2>
    <asp:TextBox ID="txtSubject" runat="server" Columns="60"></asp:TextBox>
    <asp:CustomValidator runat="server" ID="validatorSubject" ControlToValidate="txtSubject" CssClass="validator" OnServerValidate="validatorSubject_ServerValidate" ValidateEmptyText="True" ErrorMessage=""></asp:CustomValidator>
    <h2>Body</h2>
    <asp:TextBox ID="txtBody" runat="server" Text="" TextMode="MultiLine" Columns="60" Rows="7"></asp:TextBox>
    <asp:CustomValidator runat="server" ID="validatorBody" ControlToValidate="txtBody" CssClass="validator" OnServerValidate="validatorBody_ServerValidate" ValidateEmptyText="True" ErrorMessage=""></asp:CustomValidator>
    <h2><asp:Button ID="Button1" runat="server" Text="Send Message" OnClick="Button1_Click" /><asp:Label ID="lblMessage" runat="server"></asp:Label></h2>
    <h1>or contact me on</h1>
    <ul class="smHook">
        <li><a href="https://www.facebook.com/logan.brooke.3" class="fbicon">Facebook</a></li>
        <li><a href="https://github.com/lwbrooke" class="ghicon">GitHub</a></li>
        <li><a href="https://www.linkedin.com/in/loganwbrooke" class="liicon">LinkedIn</a></li>
    </ul>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="FooterPlaceHolder" Runat="Server">
    <div class="footer">Logan Brooke | Contact</div>
</asp:Content>

