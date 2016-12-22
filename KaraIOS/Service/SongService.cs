using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using ModernHttpClient;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Threading.Tasks;

namespace KaraIOS
{
	public class SongService : ISongService
	{
		private const string HOST_NAME		= 	"https://karaokecontrol.herokuapp.com/";
		private const string KARAOKE_KEY	= 	"+karaoke";

		public SongService()
		{
		}

		/// <summary>
		/// Get songs from service
		/// </summary>
		/// <returns>List song.</returns>
		/// <param name="keyword">Keyword need to search.</param>
		public async Task<List<Song>> GetSongs(string keyword)
		{
			//Validate
			ValidatedKeyWord(ref keyword);

			var httpClient = new HttpClient(new NativeMessageHandler());
			var response = await httpClient.GetAsync(HOST_NAME + keyword);

			if (response.IsSuccessStatusCode)
			{
				//var content = response.co.ReadAsStringAsync();
				var json = await response.Content.ReadAsStringAsync();
				return RemoveAds(JsonConvert.DeserializeObject<List<Song>>(json));
			}
			return null;
			//Parse JSON to Song

			//List<Song> listSong = new List<Song>();
			//Remove Ads
			//return RemoveAds(listSong);
		}


		/// <summary>
		/// Validateds the key word.
		/// </summary>
		/// <param name="keyword">Keyword.</param>
		private void ValidatedKeyWord(ref string keyword)
		{
			ReplaceVietnamese(ref keyword);

			keyword.Trim();
			keyword.Replace(" ", "+");
			keyword += KARAOKE_KEY;
		}

		/// <summary>
		/// Replaces the vietnamese.
		/// </summary>
		/// <param name="keyword">Keyword.</param>
		void ReplaceVietnamese(ref string keyword)
		{
			string[] signs = new string[] {
				"aAeEoOuUiIdDyY",
				"áàạảãâấầậẩẫăắằặẳẵ",
				"ÁÀẠẢÃÂẤẦẬẨẪĂẮẰẶẲẴ",
				"éèẹẻẽêếềệểễ",
				"ÉÈẸẺẼÊẾỀỆỂỄ",
				"óòọỏõôốồộổỗơớờợởỡ",
				"ÓÒỌỎÕÔỐỒỘỔỖƠỚỜỢỞỠ",
				"úùụủũưứừựửữ",
				"ÚÙỤỦŨƯỨỪỰỬỮ",
				"íìịỉĩ",
				"ÍÌỊỈĨ",
				"đ",
				"Đ",
				"ýỳỵỷỹ",
				"ÝỲỴỶỸ"
   			};
			for (int i = 1; i < signs.Length; i++)
			{
				for (int j = 0; j < signs[i].Length; j++)
				{
					keyword = keyword.Replace(signs[i][j], signs[0][i - 1]);
				}
			}
		}

		/// <summary>
		/// Removes the ads from service
		/// </summary>
		/// <param name="listSong">List song.</param>
		/// <param name="keyword">Keyword.</param>
		private List<Song> RemoveAds(List<Song> listSong)
		{
			listSong.RemoveAll(song => song.Link.StartsWith("h"));
			return listSong;
		}

		public async Task<List<Song>> GetSongs(string keyword, int itemCount)
		{
			List<Song> songs =  await this.GetSongs(keyword);
			//TODO: Remove songs
		  	//songs.RemoveRange(itemCount, songs.Count - itemCount);
			return songs;
		}
	}
}