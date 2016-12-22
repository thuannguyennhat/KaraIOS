using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace KaraIOS
{
    public class Song
	{
		public string Link
		{
			get;
			set;
		}

		public string Name
		{
			get;
			set;
		}

		public string Image
		{
			get;
			set;
		}

		public Song()
		{
		}

		public Song(string link, string name)
		{
			this.Link = link;
			this.Name = name;
			//this.Image = image;
		}

	}
}
