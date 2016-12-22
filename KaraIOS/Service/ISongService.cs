using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KaraIOS
{
    public interface ISongService
    {
		Task<List<Song>> GetSongs(string keyword);
        Task<List<Song>> GetSongs(string keyword, int itemCount);
    }
}