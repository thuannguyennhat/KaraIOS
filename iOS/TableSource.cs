using System;
using System.Collections.Generic;
using Foundation;
using KaraIOS.ViewModel;
using UIKit;

namespace KaraIOS.iOS
{
	public class TableSource:UITableViewSource
	{
		List<Song> listSong;

		public void SetList(List<Song> list)
		{
			this.listSong = list;
		}

		string CellIdentifier = "MyTableViewCell";

		public TableSource(List<Song> songs)
		{
			this.listSong = songs;
		}

		public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
		{
			var cell = tableView.DequeueReusableCell(CellIdentifier) as MyTableViewCell;

			if (cell == null)
				cell = new MyTableViewCell(CellIdentifier);

			cell.UpdateCell(listSong[indexPath.Row].Name,
							"Chi dan",
			                listSong[indexPath.Row].Image);
			//tableView.SeparatorStyle = UITableViewCellSeparatorStyle.DoubleLineEtched;

			//tableView.SeparatorEffect =
			//	UIBlurEffect.FromStyle(UIBlurEffectStyle.Dark);
			tableView.RowHeight=111;
			tableView.SeparatorStyle = UITableViewCellSeparatorStyle.None;

			return cell;
		}

		public override nint RowsInSection(UITableView tableview, nint section)
		{
			return listSong==null?0:listSong.Count;
		}

		public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
		{
			//TODO: Navigate to DetailPage
			Vm.NavigateToDetail(listSong[indexPath.Row]);

			//new UIAlertView("Row selected",listSong[indexPath.Row].Name, null, "Confirm").Show();
			tableView.DeselectRow(indexPath, true);
		}

		MainViewModel Vm = Application.Locator.Main;
	}
}
