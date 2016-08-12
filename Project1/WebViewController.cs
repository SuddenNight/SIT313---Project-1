using Foundation;
using System;
using UIKit;

namespace Project1
{
    public partial class WebViewController : UIViewController
    {
		
        public WebViewController (IntPtr handle) : base (handle)
        {
        }

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.


			webView = new UIWebView (View.Bounds);
			View.AddSubview(webView);
			
			var url = "http://www.deakin.edu.au";
			webView.LoadRequest(new NSUrlRequest(new NSUrl(url)));
			//webView.ScalesPageToFit = true;
			
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
    }
}