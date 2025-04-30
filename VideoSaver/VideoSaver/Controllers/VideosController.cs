using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
	}
}
