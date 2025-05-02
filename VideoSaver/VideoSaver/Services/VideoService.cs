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

		public Video SaveVideo(Video video)
		{
			Video? videoByName = GetVideoByName(video);
			video.VideoId = videoByName?.VideoId ?? 0;

			if (video.VideoId == 0)
			{
				video = _database.InsertVideo(video);
			}
			else
			{
				video = _database.UpdateVideo(video);
			}
			return video;
		}

		internal Video? GetVideoByName(Video video)
		{
			List<Video> videos = GetAllVideos();
			return videos.FirstOrDefault(v => v.VideoName == video.VideoName);
		}
	}
}
