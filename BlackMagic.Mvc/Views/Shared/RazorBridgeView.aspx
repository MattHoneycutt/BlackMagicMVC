<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ContentPlaceHolderID="MainContent" runat="server">
	
    <% Html.RenderPartial(ViewData["MvcViewName"].ToString());%>
	
	<script type="text/javascript">
		var title = '<%=Context.Items["RazorBridgeTitle"]%>';

		if (title != "") {
			document.title = "Your App Name - SET FROM MVC! - " + title;
		}
	</script>

</asp:Content>
