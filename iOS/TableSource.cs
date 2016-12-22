using System;
using Foundation;
using UIKit;

namespace KaraIOS.iOS
{
	public class TableSource:UITableViewSource
	{
		string[] items;
		string CellIdentifier = "Table Cell";

		public TableSource(string[] items)
		{
			this.items = items;
		}

		public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
		{

			/*var cell = tableView.DequeueReusableCell(CellIdentifier) as CustomCell;
			if (cell == null)
				cell = new CustomCell(CellIdentifier);
			cell.UpdateCell(items[indexPath.Row].Heading
					, items[indexPath.Row].SubHeading
					, UIImage.FromFile("Images/" + items[indexPath.Row].ImageName));
			return cell;*/
			var cell = tableView.DequeueReusableCell(CellIdentifier);

			if (cell == null)
				cell = new UITableViewCell(UITableViewCellStyle.Default,CellIdentifier);
			cell.TextLabel.Text = items[indexPath.Row];
			cell.Accessory = UITableViewCellAccessory.DetailDisclosureButton;

			tableView.SeparatorColor = UIColor.Blue;
			//tableView.SeparatorStyle = UITableViewCellSeparatorStyle.DoubleLineEtched;

			//tableView.SeparatorEffect =
			//	UIBlurEffect.FromStyle(UIBlurEffectStyle.Dark);
			return cell;

		}

		public override nint RowsInSection(UITableView tableview, nint section)
		{
			return items.Length;
		}

		public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
		{
			new UIAlertView("Row selected",items[indexPath.Row].ToString(), null, "Confirm").Show();
			tableView.DeselectRow(indexPath, true);
		}
	}
}
