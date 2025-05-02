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

		public Video InsertVideo(Video video)
		{

			_dbConnection.ExecuteAsync(SqlStatements.InsertVideo, video).Wait();
			return video;
		}

		public Video UpdateVideo(Video video)
		{
			_dbConnection.ExecuteAsync(SqlStatements.UpdateVideo, video).Wait();
			return video;
		}
	}
}
