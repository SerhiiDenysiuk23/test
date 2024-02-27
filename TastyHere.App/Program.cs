using TastyHere.Business.Services;

var builder = WebApplication.CreateBuilder(args);

var connStr = builder.Configuration.GetConnectionString("MSSQL");

AppSettingsService.AddDbContext(builder.Services, connStr);

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
