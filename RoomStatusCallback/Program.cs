using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
var app = builder.Build();
if (!app.Environment.IsDevelopment())
    app.UseHsts();
app.UseHttpsRedirection();
app.UseRouting();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapPost("/minimal/room/status", async (HttpRequest request) =>
{
    var form = await request.ReadFormAsync();

    var roomName = form["RoomName"];
    var roomSid = form["RoomSid"];
    var roomStatus = form["RoomStatus"];
    var roomType = form["RoomType"];
    app.Logger.LogInformation(@"Room created
Name: {RoomName}
Sid: {RoomSid}
Status: {RoomStatus}
Type: {RoomType}",
        roomName,
        roomSid,
        roomStatus,
        roomType
    );

    return Results.Ok();
});

app.MapGet("/minimal/room/status", (
    [FromQuery] string roomName,
    [FromQuery] string roomSid,
    [FromQuery] string roomStatus,
    [FromQuery] string roomType
) =>
{
    app.Logger.LogInformation(@"Room created
Name: {RoomName}
Sid: {RoomSid}
Status: {RoomStatus}
Type: {RoomType}",
        roomName,
        roomSid,
        roomStatus,
        roomType
    );

    return Results.Ok();
});

app.Run();
