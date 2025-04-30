using VideoSaver.Models;

namespace VideoSaver.Services.Interfaces
{
	public interface IVideoService
	{
		List<Video> GetAllVideos();
		Video GetVideoById(int id);
	}
}
