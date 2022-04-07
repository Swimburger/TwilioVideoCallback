using Twilio;
using Twilio.Rest.Video.V1;
using HttpMethod = Twilio.Http.HttpMethod;

// make sure to configure your Twilio Account SID and Auth Token as environment variables before running this program
var accountSid = Environment.GetEnvironmentVariable("TwilioAccountSid");
var authToken = Environment.GetEnvironmentVariable("TwilioAuthToken");

TwilioClient.Init(accountSid, authToken);

Console.Write("What is the room status callback URL?");
var roomStatusCallbackUrl = Console.ReadLine();
Console.WriteLine();

await RoomResource.CreateAsync(
	statusCallback: new Uri(roomStatusCallbackUrl), 
	statusCallbackMethod: HttpMethod.Post
);