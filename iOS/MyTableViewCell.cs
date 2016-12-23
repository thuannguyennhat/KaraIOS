using System;

using Foundation;
using UIKit;

namespace KaraIOS.iOS
{
	public partial class MyTableViewCell : UITableViewCell
	{
		public static readonly NSString Key = new NSString("MyTableViewCell");
		public static readonly UINib Nib;

		static MyTableViewCell()
		{
			Nib = UINib.FromName("MyTableViewCell", NSBundle.MainBundle);
		}

		public MyTableViewCell(string cellID) : base(UITableViewCellStyle.Default, Key)
		{
		}

		protected MyTableViewCell(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public void UpdateCell(string songName, string singer, string imagelink)
		{
			imgPicture.Image = FromUrl(imagelink);
			txtSinger.Text = singer;
			txtSongName.Text = songName;


		}

		static UIImage FromUrl(string uri)
		{
			using (var url = new NSUrl(uri))
			using (var data = NSData.FromUrl(url))
				return UIImage.LoadFromData(data);
		}

	}
}
