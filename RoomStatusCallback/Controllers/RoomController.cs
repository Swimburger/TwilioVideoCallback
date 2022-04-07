using Microsoft.AspNetCore.Mvc;
using RoomStatusCallback.Models;

namespace RoomStatusCallback.Controllers;

public class RoomController : Controller
{
	private readonly ILogger<RoomController> logger;

	public RoomController(ILogger<RoomController> logger)
	{
		this.logger = logger;
	}

	public ActionResult Status(RoomStatusRequest statusRequest)
	{
		logger.LogInformation(@"Room created
Name: {RoomName}
Sid: {RoomSid}
Status: {RoomStatus}
Type: {RoomType}",
			statusRequest.RoomName,
			statusRequest.RoomSid,
			statusRequest.RoomStatus,
			statusRequest.RoomType
		);
		return Ok();
	}
	
// this works as well
// 	public ActionResult Status(
// 		string roomName,
// 		string roomSid,
// 		string roomStatus,
// 		string roomType
// 	)
// 	{
// 		logger.LogInformation(@"Room created
// Name: {RoomName}
// Sid: {RoomSid}
// Status: {RoomStatus}
// Type: {RoomType}",
// 			roomName,
// 			roomSid,
// 			roomStatus,
// 			roomType
// 		);
// 		return Ok();
// 	}
}