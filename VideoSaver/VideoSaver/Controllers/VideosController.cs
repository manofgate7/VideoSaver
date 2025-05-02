using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VideoSaver.Data.Extensions;
using VideoSaver.Models;
using VideoSaver.Services.Interfaces;

namespace VideoSaver.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VideosController(IVideoService videoService) : ControllerBase
    {
        private readonly IVideoService _videoService = videoService;

        [HttpGet]
        public IEnumerable<Video> GetAllVideos()
        {
            return _videoService.GetAllVideos();
        }

        [HttpPost]
		[RequestSizeLimit(100_000_000)]
		public async Task<Video> SaveVideoAsync(string videoName, IFormFile videoFile)
        {
			var bytes = await videoFile.GetBytes();
            return _videoService.SaveVideo(new Video() { VideoName = videoName, VideoBlob = bytes });
        }
	}
}
