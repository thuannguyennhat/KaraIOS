using System;
using GalaSoft.MvvmLight.Views;
using UIKit;

namespace KaraIOS.iOS
{
	public partial class RegisterViewController : UIViewController
	{
		public RegisterViewController() : base("RegisterViewController", null)
		{
		}

		RegisterViewModel Vm = Application.Locator.Register;

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.

			Title = "Register";

			btnRegister.TouchUpInside += (sender, e) => { 
				string username = txtUsername.Text;
				string password = txtPassword.Text;
				string passwordConfirm = txtConfirmPassword.Text;

				if (password == passwordConfirm)
				{
					//TODO: 
					//Pass back user to Login
					Vm.RegisterComplete(username);
				}
				else
					new UIAlertView("Error", "Password invalid", null, "Confirm").Show(); 
			};

			btnBackToLogin.TouchUpInside += (sender, e) =>
			{
				Vm.AlreadyHasAccount();
			};
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}

