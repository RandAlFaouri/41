
using ASP06.ControllerApi.Services;
using ASP06.MinimalApi.Models.Services;
var builder = WebApplication.CreateBuilder(args);
//DI container service registration
builder.Services.AddControllers();
builder.Services.AddScoped<IBookService, BookService>();

var app = builder.Build();


// requewst pipline
app.MapControllers();
app.Run();
