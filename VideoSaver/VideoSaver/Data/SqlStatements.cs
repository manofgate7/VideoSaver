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
			
	}
}
