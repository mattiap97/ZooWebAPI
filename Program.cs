using Microsoft.EntityFrameworkCore;
using ZooWebAPI.DAL;
using ZooWebAPI.Models;
using ZooWebAPI.Services;
using ZooWebAPI.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IAnimal, AnimalServices>();
builder.Services.AddScoped<IList<Animal>, List<Animal>>();

builder.Services.AddDbContext<ZooDbContext>(option =>
                option.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=ZooWebApi"));



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
