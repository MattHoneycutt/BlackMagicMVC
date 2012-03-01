using System.Web.Mvc;

namespace BlackMagic.Mvc.WebFormsBridge
{
	//Both pages are required.
	public abstract class RazorBridgeViewPage : RazorBridgeViewPage<dynamic>
	{

	}

	public abstract class RazorBridgeViewPage<T> : WebViewPage<T>
	{
		public string Title
		{
			get { return (string)(Context.Items["RazorBridgeTitle"] ?? string.Empty); }
			set { Context.Items["RazorBridgeTitle"] = value; }
		}
	}
}