using Microsoft.EntityFrameworkCore;
using MyLibrary.Contracts;
using MyLibrary.Entities;
using MyLibrary.Models;
using MyLibrary.Repositories;
using MyLibrary.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<MyLibraryContext>(opt =>
    opt.UseInMemoryDatabase("MyLibrary"));

builder.Services.AddTransient<IBookService, BookService>();
builder.Services.AddTransient<IRepository<Book>, BookRepository>(); 
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
