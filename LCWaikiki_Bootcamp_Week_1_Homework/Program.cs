using LCWaikiki_Bootcamp_Week_1_Homework.Core;
using LCWaikiki_Bootcamp_Week_1_Homework.Middlewares;
using LCWaikiki_Bootcamp_Week_1_Homework.Repositories;
using LCWaikiki_Bootcamp_Week_1_Homework.Services;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ProductDbContext>(
    options => options.UseInMemoryDatabase("BookStoreDB")
);

builder.Services.AddScoped<IProductRepository, ProductRepository>();

builder.Services.AddMediatR(Assembly.GetExecutingAssembly());

builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());

builder.Services.AddFluentValidationServices();

var app = builder.Build();

// Initialize in memory data generator values
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    InMemoryDataGenerator.Initialize(services);
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseCustomLoggingMiddleware();
app.UseGlobalExceptionMiddleware();


app.MapControllers();

app.Run();
