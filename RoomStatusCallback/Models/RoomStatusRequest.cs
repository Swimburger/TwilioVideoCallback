namespace RoomStatusCallback.Models;

public class RoomStatusRequest
{
	public string AccountSid { get; set; }
	public string RoomName { get; set; }
	public string RoomSid { get; set; }
	public string RoomStatus { get; set; }
	public string RoomType { get; set; }
	public string StatusCallbackEvent { get; set; }
	public DateTime Timestamp { get; set; }
}