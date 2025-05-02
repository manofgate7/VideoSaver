using VideoSaver.Models;

namespace VideoSaver.Data.Interfaces
{
	public interface IDatabase
	{
		List<Video> GetVideos();

		Video InsertVideo(Video video);
		Video UpdateVideo(Video video);
	}
}
