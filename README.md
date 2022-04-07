# TwilioVideoCallback

To run this sample:

- Run the ASP.NET Core project: `dotnet run --project RoomStatusCallback`
- Use ngrok to expose your ASP.NET Core project: `ngrok http [YOUR_PROJECT_HTTPS_URL]`
- Run the console project to create a room (which will trigger a status callback): `dotnet run --project CreateRoom`
- When asked, provide the ngrok HTTPS forwarding URL with the desired path:
  - For MVC: `[NGROK_HTTPS_URL]/Room/Status`
  - For Minimal API: `[NGROK_HTTPS_URL]/minimal/room/status`

This sample was created to answer the following StackOverflow question: https://stackoverflow.com/questions/71780343/what-is-the-return-type-in-twilio-when-it-is-recieved-from-status-callback/71786461#71786461
