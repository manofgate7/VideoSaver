namespace VideoSaver.Models
{
	public class Video
	{
		public int VideoId { get; set; }
		public required string VideoName { get; set; }
		public required byte[] VideoBlob { get; set; }
		public DateTime EnteredDate { get; set; }
		public DateTime ChangedDate { get; set; }
	}
}
