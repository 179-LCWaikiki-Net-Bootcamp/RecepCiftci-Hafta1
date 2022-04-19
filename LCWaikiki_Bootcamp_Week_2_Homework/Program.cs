using MediatR;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using LCWaikiki_Bootcamp_Week_2_Homework.Middlewares;
using LCWaikiki_Bootcamp_Week_2_Homework.Core;
using LCWaikiki_Bootcamp_Week_2_Homework.Repositories.BaseRepository;
using LCWaikiki_Bootcamp_Week_2_Homework.DTOs;
using LCWaikiki_Bootcamp_Week_2_Homework.Repositories.FoodRepository;
using LCWaikiki_Bootcamp_Week_2_Homework.Repositories.IngredientRepository;
using LCWaikiki_Bootcamp_Week_2_Homework.DBOperations.Queries.Bases.GetAll;
using LCWaikiki_Bootcamp_Week_2_Homework.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<RestaurantDbContext>(
options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
builder.Services.AddScoped<IFoodRepository, FoodRepository>();
builder.Services.AddScoped<IIngredientRepository, IngredientRepository>();

builder.Services.AddMediatR(Assembly.GetExecutingAssembly());

//builder.Services.AddTransient<
//   IRequestHandler<GetAllQuery<Food, FoodDto>, ResponseDto<IReadOnlyList<FoodDto>>>,
//   GetAllQueryHandler<Food,FoodDto>>();


builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());

var app = builder.Build();

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
