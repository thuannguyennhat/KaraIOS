// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace KaraIOS.iOS
{
	[Register ("MyTableViewCell")]
	partial class MyTableViewCell
	{
		[Outlet]
		UIKit.UIView backgroundCardView { get; set; }

		[Outlet]
		UIKit.UIImageView imgPicture { get; set; }

		[Outlet]
		UIKit.UILabel txtSinger { get; set; }

		[Outlet]
		UIKit.UILabel txtSongName { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (txtSongName != null) {
				txtSongName.Dispose ();
				txtSongName = null;
			}

			if (txtSinger != null) {
				txtSinger.Dispose ();
				txtSinger = null;
			}

			if (imgPicture != null) {
				imgPicture.Dispose ();
				imgPicture = null;
			}

			if (backgroundCardView != null) {
				backgroundCardView.Dispose ();
				backgroundCardView = null;
			}
		}
	}
}
