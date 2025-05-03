namespace VideoSaver.Data
{
	public class SqlStatements
	{
		public static string GetAllVideos =>
			"""
			SELECT 
				"VideoId"
				,"videoName"
				,"VideoBlob"
				,"EnteredDate"
				,"ChangedDate"
			FROM public."Video"
			""";
		public static string GetVideoById =>
			"""
				SELECT 
				"VideoId"
				,"videoName"
				,"VideoBlob"
				,"EnteredDate"
				,"ChangedDate"
			FROM public."Video"
			WHERE "VideoId" = @VideoId
			""";

		public static string InsertVideo =>
			"""
			INSERT INTO  public."Video" 
				("videoName"
				,"VideoBlob"
				,"EnteredDate"
				,"ChangedDate")
			VALUES 
			(@VideoName, @VideoBlob, NOW(), NOW())
			RETURNING "VideoId"
			""";

		public static string UpdateVideo =>
			"""
			UPDATE public."Video" 
			SET "videoName" = @VideoName
				,"VideoBlob" = @VideoBlob
				, "ChangedDate" = NOW()
			WHERE
				"VideoId" = @VideoId
			""";
			
	}
}
