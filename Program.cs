using ASP.NET_Core_Authorization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var startup = new Startup(builder.Configuration);
startup.ConfigureServices(builder.Services);

var app = builder.Build();

// Configure the app pipeline
startup.Configure(app, app.Environment);

app.Run();