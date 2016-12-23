using System;

using UIKit;

namespace KaraIOS.iOS
{
	public partial class DetailViewController : UIViewController
	{
		public DetailViewController() : base("DetailViewController", null)
		{
		}

		//Init Viewmodel
		DetailViewModel Vm = Application.Locator.Detail;

		private Song song;
		public DetailViewController(Song song)
		{
			this.song = song;
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			Title = "Detail";

			// Perform any additional setup after loading the view, typically from a nib.
			if (song!=null)
			{
				txtSongLink.Text = song.Name + "/" + song.Link;
			}
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}

