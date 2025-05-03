using Dapper;
using System;
using System.Data;
using VideoSaver.Data.Interfaces;
using VideoSaver.Models;

namespace VideoSaver.Data
{
	public class Database : IDatabase
	{
		private readonly IDbConnection _dbConnection;
		public Database(IDbConnection dbConnection)
		{
			_dbConnection = dbConnection;
		}

		public List<Video> GetVideos()
		{
			return _dbConnection.Query<Video>(SqlStatements.GetAllVideos).ToList();
		}

		internal Video GetVideoById(int Id)
		{
			return _dbConnection.QuerySingle<Video>(SqlStatements.GetVideoById, new { VideoId = Id });
		}

		public Video InsertVideo(Video video)
		{

			video.VideoId = _dbConnection.QuerySingle<int>(SqlStatements.InsertVideo, video);
			return GetVideoById(video.VideoId);
		}

		public Video UpdateVideo(Video video)
		{
			_dbConnection.ExecuteAsync(SqlStatements.UpdateVideo, video).Wait();
			return GetVideoById(video.VideoId);
		}
	}
}
