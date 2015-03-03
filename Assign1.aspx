<%@ Page Language="C#" MasterPageFile="~/DefaultMaster.master" AutoEventWireup="true" CodeFile="Assign1.aspx.cs" Inherits="Assign1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitlePlaceHolder" Runat="Server">
    Assignment 1 : Age at Graduation
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ArticlePlaceHolder" Runat="Server">    
    <div>
        <h1 id="lblDate" runat="server"></h1>
        <p id="lblHowOld" runat="server">How old will you be when you graduate?</p>
        <p id="lblInstruction" runat="server">Enter the following Dates</p>

        <div id="birthdayGroup" class="dateGroup">
            <label id="lblBirthday" runat="server">Birth Date</label>
            <ul>
                <li>
                    <label id="lblBMonth" runat="server">Month</label>
                    <input id="txtBMonth" runat="server" type="text" />
                </li>
                <li>
                    <label id="lblBDay" runat="server">Day</label>
                    <input id="txtBDay" runat="server" type="text" />
                </li>
                <li>
                    <label id="lblBYear" runat="server">Year</label>
                    <input id="txtBYear" runat="server" type="text" />
                </li>
            </ul>
        </div>
        
        <div id="gradGroup" class="dateGroup">
            <label id="lblGraduate" runat="server">Graduation Date</label>
            <ul>
                <li>
                    <label id="lblGMonth" runat="server">Month</label>
                    <input id="txtGMonth" runat="server" type="text" />
                </li>
                <li>
                    <label id="lblGDay" runat="server">Day</label>
                    <input id="txtGDay" runat="server" type="text" />
                </li>
                <li>
                    <label id="lblGYear" runat="server">Year</label>
                    <input id="txtGYear" runat="server" type="text" />
                </li>
            </ul>
        </div>

        <asp:Button ID="btnCalcAge" runat="server" Text="Calculate Age" OnClick="btnCalcAge_Click" />
        <p id="lblCalcAge" runat="server"></p>
    </div>
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="FooterPlaceHolder" Runat="Server">
    <div class="footer">Logan Brooke | Assignment 1 | CSCD 379</div>
</asp:Content>