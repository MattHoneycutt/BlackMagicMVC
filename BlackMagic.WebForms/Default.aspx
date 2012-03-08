<%@ Page Title="Home Page" Language="vb" MasterPageFile="~/Site.Master" AutoEventWireup="false"
    CodeBehind="Default.aspx.vb" Inherits="BlackMagic.WebForms._Default" %>
<%@ Import namespace="BlackMagic.Mvc.Controllers" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        Welcome to ASP.NET!
    </h2>
    <p>
        To learn more about ASP.NET visit <a href="http://www.asp.net" title="ASP.NET Website">www.asp.net</a>.
    </p>
    <p>
        You can also find <a href="http://go.microsoft.com/fwlink/?LinkID=152368&amp;clcid=0x409"
            title="MSDN ASP.NET Docs">documentation on ASP.NET at MSDN</a>.
    </p>
	
	<p>Click <%=Me.BlackMagicMVC().ActionLink(Of HomeController)(Function(c) c.Index(), "here for MVC!") %></p>
	
	<h2>And now... a partial view!</h2>
	<%=Me.BlackMagicMVC().Partial("HomepageWidget") %>
	
	<h2>Finally... render action!</h2>
	<%=Me.BlackMagicMVC().RenderAction(Of HomeController)(Function(c) c.SayHello()) %>
</asp:Content>
