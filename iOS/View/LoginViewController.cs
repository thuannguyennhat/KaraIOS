using System;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using KaraIOS.ViewModel;
using Microsoft.Practices.ServiceLocation;
using UIKit;

namespace KaraIOS.iOS
{
	public partial class LoginViewController : UIViewController
	{
		public LoginViewController() : base("LoginViewController", null)
		{
		}

		public LoginViewController(string str)
			: base("LoginViewController", null)
		{
		}

		LoginViewModel Vm = Application.Locator.Login;

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.

			Title = "Login";

			CheckLogin();
			AddControls();
		}

		void AddControls()
		{
			btnLogin.TouchUpInside += (sender, e) =>
			{
				string username = txtUsername.Text;
				string password = txtPassword.Text;
				User user = new User(username, password);

				if (!Vm.LoginWithUser(user))
					new UIAlertView("Error", "Username or password is invalid!", null, "Try again!").Show();
			};

			btnLinkToRegister.TouchUpInside += (sender, e) =>
			{
				Vm.Register();
			};
		}

		void CheckLogin()
		{
			var nav = (NavigationService)ServiceLocator.Current.GetInstance<INavigationService>();
			var param = nav.GetAndRemoveParameter(this);
			if (param!=null)
			{
				//just registered
				txtUsername.Text = param.ToString();
			}
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}

