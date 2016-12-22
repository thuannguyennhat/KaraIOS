using System;
using GalaSoft.MvvmLight.Views;
using KaraIOS.ViewModel;
using UIKit;

namespace KaraIOS.iOS
{
	public partial class MainViewController : UIViewController
	{
		public MainViewController() : base("MainViewController", null)
		{
		}

		MainViewModel Vm = Application.Locator.Main;


		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.
			Title = "Main";
			this.NavigationController.SetNavigationBarHidden(true, true);

			//tableView = new UITableView(View.Bounds); // defaults to Plain style
			string[] tableItems = new string[] { "Vegetables", "Fruits", "Flower Buds", "Legumes", "Bulbs", "Tubers","Vegetables", "Fruits", "Flower Buds", "Legumes", "Bulbs", "Tubers","Vegetables", "Fruits", "Flower Buds", "Legumes", "Bulbs", "Tubers" };
			tableView.Source = new TableSource(tableItems);
			//Add(tableView);
		}


		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}

