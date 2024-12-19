using Microsoft.EntityFrameworkCore;
using Webapi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container;

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// Configure Entity Framework and the in-memory database
builder.Services.AddDbContext<HelloDbContext>(options => 
    options.UseInMemoryDatabase("InMemoryDb"));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseStaticFiles();

app.UseHttpsRedirection();

app.UseRouting();
app.UseAuthorization();
app.MapControllers();





app.Run();
