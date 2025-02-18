#region Manuel Implementation - Controller Based
//var builder = WebApplication.CreateBuilder(args);
//builder.Services.AddControllers();

//var app = builder.Build();

//app.MapControllers();

//app.Run();
#endregion
#region Manuel Implementation - Minimal API Based
//using REPR.Pattern.Example.Manuel_Implementation.Minimal_API_Based.Endpoints;

//var builder = WebApplication.CreateBuilder(args);
//builder.Services.AddMediator(options =>
//{
//    options.ServiceLifetime = ServiceLifetime.Scoped;
//});

//var app = builder.Build();

//app.RegisterMappings();

//app.Run();
#endregion
#region FastEndpoints Implementation
using FastEndpoints;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddFastEndpoints();

var app = builder.Build();

app.UseFastEndpoints();

app.Run();
#endregion
#region ApiEndpoints Implementation
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
var app = builder.Build();

app.MapControllers();

app.Run();
#endregion