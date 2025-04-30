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
			//SqlMapper.AddTypeHandler(new DapperSqlDateOnlyTypeHandler());


			return _dbConnection.Query<Video>(SqlStatements.GetAllVideos).ToList();
		}
	}
}
