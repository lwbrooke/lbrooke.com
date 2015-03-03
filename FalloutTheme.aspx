<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FalloutTheme.aspx.cs" Inherits="FalloutTheme" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <title>Fallout Theme - lbrooke.com</title>
        <link href="_css/FalloutStyleSheet.css" type="text/css" rel="stylesheet"/>
    </head>
    <body>
        <form id="form1" runat="server">
            <h1>ROBCO INDUSTRIES UNIFIED OPERATING SYSTEM</h1>
            <h1>COPYRIGHT 2075-2077 ROBCO INDUSTRIES</h1>
            <h1>-Server 1-</h1>
            <h2>Fallout Style Terminal: A CSS & JavaScript Project in ASP.NET<br/> by Logan Brooke</h2>
            <nav>
                <asp:LinkButton ID="lbtnHome" runat="server" OnClick="lbtnHome_Click">Home</asp:LinkButton>
                <h1>CSCD 379</h1>
                <ul>
                    <li>
                        <asp:LinkButton ID="lbtnAssign1" runat="server" OnClick="lbtnAssign1_Click">Assignment 1</asp:LinkButton>
                    </li>
                    <li>
                        <asp:LinkButton ID="lbtnLab1" runat="server" OnClick="lbtnLab1_Click1">Lab 1</asp:LinkButton>
                    </li>
                    <li>
                        <asp:LinkButton ID="lbtnLab2" runat="server" OnClick="lbtnLab2_Click" >Lab 2</asp:LinkButton>
                    </li>
                    <li>
                        <asp:LinkButton ID="lbtnLab3" runat="server" OnClick="lbtnLab3_Click" >Lab 3</asp:LinkButton>
                    </li>
                </ul>
                <h1>Side Projects</h1>
                <ul>
                    <li>
                        <asp:LinkButton ID="lbtnFallout" runat="server" OnClick="lbtnFallout_Click">Fallout Theme</asp:LinkButton>
                    </li>
                </ul>
            </nav>
            <article>
                <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin ac consequat eros. Cras gravida mauris eu justo blandit, a sollicitudin orci vehicula. Duis nec ante eget dolor vestibulum ornare a egestas lectus. Donec pharetra vel enim in volutpat. Morbi purus tellus, ullamcorper sit amet tellus ac, placerat iaculis mi. Pellentesque sapien sapien, dictum id mollis non, maximus eu est. Proin dui neque, finibus id semper non, venenatis eu urna. Mauris aliquet arcu ut euismod vestibulum.</p>
                <p>Maecenas scelerisque nisl a sollicitudin maximus. Fusce maximus, augue vitae cursus mattis, diam felis accumsan mi, et faucibus leo augue et ex. Praesent dictum nisi eros, non faucibus dui semper non. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Fusce vitae sapien faucibus, tincidunt turpis non, cursus nunc. Sed sed sodales leo. Aliquam vestibulum vehicula mauris ut consequat. Vivamus euismod faucibus massa, vel imperdiet nulla tincidunt vitae. Morbi dolor erat, cursus ac faucibus id, pellentesque sit amet ex. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus venenatis odio elit, tempor accumsan mi porta ac.</p>
                <p>Sed consequat diam sed accumsan sollicitudin. Nulla vel justo at nibh fermentum mattis. Quisque fringilla ligula eu erat maximus pellentesque. Nulla molestie justo eget augue porta, consectetur dignissim neque tristique. Phasellus at rhoncus leo, vitae luctus libero. Phasellus finibus ac diam ac elementum. Etiam condimentum leo ac ex hendrerit sodales nec eu mi. Sed eu blandit ante. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec maximus ipsum in maximus molestie. Fusce non lorem at urna hendrerit gravida. Aenean porta vulputate neque vel vulputate.</p>
                <p>Sed lacinia sollicitudin nisl eu dignissim. Curabitur vulputate erat eu tincidunt tempus. Donec eget luctus felis. Maecenas posuere purus ac mauris porttitor, ut hendrerit neque molestie. Ut orci est, blandit sit amet sapien quis, tincidunt pretium odio. Pellentesque augue risus, aliquet a lacinia non, sodales sit amet dui. Aenean in ultrices nisi. Fusce ligula nisi, finibus id fringilla vitae, volutpat eu arcu. Proin placerat, diam non pellentesque elementum, libero ex dapibus mi, sed fermentum quam mauris eu purus. Donec ex dui, interdum id turpis eu, imperdiet pellentesque metus. Morbi nec commodo ipsum, eget feugiat ipsum. Quisque et purus lobortis, laoreet risus quis, accumsan velit. Morbi tincidunt eros ligula, ut auctor nisl consequat commodo. Aenean quis cursus orci, vestibulum rhoncus dolor.</p>
                <p>Donec consectetur id tellus sit amet efficitur. Curabitur in lacus justo. Duis eget malesuada diam. Vivamus ultrices enim at neque interdum malesuada. Praesent id tristique quam, quis imperdiet tellus. Sed aliquet tellus nec nisi lacinia imperdiet. Vestibulum feugiat, orci at accumsan finibus, nulla ipsum cursus diam, ac lacinia sem arcu in dui. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Ut vitae velit scelerisque est rutrum congue. Morbi lacinia posuere nisl vitae convallis. Quisque in purus vel neque pharetra scelerisque. Sed dictum dapibus leo, sed molestie massa gravida molestie. Praesent massa quam, efficitur et viverra quis, feugiat vulputate tortor.</p>
            </article>
            <footer>> <span id="typeText"></span><span id="blinkCursor">█</span></footer>
        </form>
    </body>
    <script src="_javascript/FalloutTheme.js" type="text/javascript"></script>
</html>
