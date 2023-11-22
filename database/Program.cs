using database.context;
using Microsoft.EntityFrameworkCore; 

var builder = WebApplication.CreateBuilder(args);

// Add services to the container. 
builder.Services.AddDbContext<AuthDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DbContext")));

var app = builder.Build();

var service =  app.Services.GetService<AuthDbContext>();

service?.Database.Migrate(); 

app.Run();
 
