using Microsoft.EntityFrameworkCore;
using Project_NET.DataAccess;

var builder = WebApplication.CreateBuilder(args);


// Conexion
const string CONNECTIONNAME = "ProjectNetDB";
var connectionString = builder.Configuration.GetConnectionString(CONNECTIONNAME);

// Add context
builder.Services.AddDbContext<ProjectNetDBContext>(options => options.UseSqlServer(connectionString));



// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
