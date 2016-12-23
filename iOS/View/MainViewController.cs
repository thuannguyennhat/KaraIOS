using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GalaSoft.MvvmLight.Helpers;
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

		//Init Main VM
		MainViewModel Vm = Application.Locator.Main;
		TableSource tbSource;

		//Binding List song
		private List<Song> _listData;

		public List<Song> ListData
		{
			get { return _listData; }
			set
			{
				_listData = value;
				if (_listData.Count != 0)
				{
					tbSource.SetList(ListData);
					tableView.ReloadData();
				}
			}
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.
			Title = "Main";
			this.NavigationItem.SetHidesBackButton(true, true);

			//this.SetBinding(() => Vm.ListData, () => ListData);
			Vm.PropertyChanged += (sender, e) =>
			{
				ListData = Vm.ListData;
			};
			Vm.GetSongs("em+o+dau", 5);

			tableView.RegisterNibForCellReuse(UINib.FromName("MyTableViewCell", null), "MyTableViewCell");
			tbSource = new TableSource(ListData);
			tableView.Source = tbSource;
		}


		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}

