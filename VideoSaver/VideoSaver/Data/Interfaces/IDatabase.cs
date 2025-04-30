using VideoSaver.Models;

namespace VideoSaver.Data.Interfaces
{
	public interface IDatabase
	{
		List<Video> GetVideos();
	}
}
