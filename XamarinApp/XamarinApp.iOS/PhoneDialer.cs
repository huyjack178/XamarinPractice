using Foundation;
using UIKit;
using Xamarin.Forms;
using XamarinApp.iOS;

[assembly: Dependency(typeof(PhoneDialer))]

namespace XamarinApp.iOS
{
	public class PhoneDialer : IDialer
	{
		public bool Dial(string number)
		{
			return UIApplication.SharedApplication.OpenUrl(
				new NSUrl("tel:" + number));
		}
	}
}