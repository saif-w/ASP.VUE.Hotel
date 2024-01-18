using Hotel.App.Data.Entity;
using Hotel.Repositorys.Interfaces;
using Hotel.Repositorys.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


//SqlServer Connection
builder.Services.AddDbContext<HotelDbContext>(o =>
o.UseSqlServer(builder.Configuration.GetConnectionString("ConnectionHotel")));

//Interface AND Repository Connection
builder.Services.AddScoped<IRoomTypeRepository, RoomTypeRepository>();
builder.Services.AddScoped<IOtherTypeRepostry, OtherTypeRepostry>();
builder.Services.AddScoped<IRoomStatusRepostry, RoomStatusRepostry>();
builder.Services.AddScoped<IRoomRepotory, RoomRepotory>();
builder.Services.AddScoped<IResvationRepository, ResvationRepository>();
builder.Services.AddScoped<IGuestRepostiory, GuestRepostiory>();
builder.Services.AddScoped<IPaymentRepostiory, PaymentRepostiory>();


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
