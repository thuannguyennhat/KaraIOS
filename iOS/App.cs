using System;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Threading;
using GalaSoft.MvvmLight.Views;
using KaraIOS.ViewModel;
using UIKit;

namespace KaraIOS.iOS
{
	public static class App
	{
		private static ViewModelLocator locator;
		public static ViewModelLocator Locator
		{
			get
			{
				if (locator==null)
				{
					
					var nav = new NavigationService();
					SimpleIoc.Default.Register<INavigationService>(() => nav);
					//var navController = new UINavigationController(new MainViewController());

					nav.Configure(ViewModelLocator.LoginPageKey, typeof(LoginViewController));
					nav.Configure(ViewModelLocator.MainPageKey, typeof(MainViewController));
					nav.Configure(ViewModelLocator.RegisterPageKey, typeof(RegisterViewController));

					locator = new ViewModelLocator();
				}
				return locator;
			}
		}
	}
}
