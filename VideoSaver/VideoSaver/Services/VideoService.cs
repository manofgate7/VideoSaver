using VideoSaver.Data.Interfaces;
using VideoSaver.Models;
using VideoSaver.Services.Interfaces;

namespace VideoSaver.Services
{
	public class VideoService(IDatabase database) : IVideoService
	{
		private readonly IDatabase _database = database;

		public List<Video> GetAllVideos()
		{
			return _database.GetVideos();
		}

		public Video GetVideoById(int id)
		{
			throw new NotImplementedException();
		}
	}
}
