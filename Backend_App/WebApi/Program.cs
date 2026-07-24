using Microsoft.EntityFrameworkCore;
using Application.Services;
using DataModel.Repository;
using DataModel.Mapper;
using Domain.Factory.AmericanFootballPlayerFactory;
using Domain.Factory.BaseballPlayerFactory;
using Domain.Factory.BasketballPlayerFactory;
using Domain.Factory.FootballPlayerFactory;
using Domain.Factory.HandballPlayerFactory;
using Domain.Factory.IceHockeyPlayerFactory;
using Domain.Factory.Interface;
using Domain.IRepository;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers().AddJsonOptions(options =>
			{
				options.JsonSerializerOptions.PropertyNameCaseInsensitive = true;
			});

builder.Services.AddDbContext<AbsanteeContext>(opt =>
    //opt.UseInMemoryDatabase("AbsanteeList")
    //opt.UseSqlite("Data Source=AbsanteeDatabase.sqlite")
    opt.UseSqlite(Host.CreateApplicationBuilder().Configuration.GetConnectionString("AbsanteeDatabase"))
);

// Only add JWT authentication if not in test environment
if (builder.Environment.EnvironmentName != "Test")
{
    builder.Services.AddAuthentication("Bearer")
        .AddJwtBearer("Bearer", options =>
        {
            options.Authority = "http://localhost:8080/realms/dev";
            options.RequireHttpsMetadata = false; // local only

            // Accept tokens without an 'aud' for local/dev. Remove or tighten in production.
            options.TokenValidationParameters = new TokenValidationParameters
            {
                ValidateAudience = false
                // If you prefer to validate, set ValidAudience = "angular-client" (and ensure Keycloak issues that audience)
            };
        });
}


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddTransient<IAmericanFootballPlayerRepository, AmericanFootballPlayerRepository>();
builder.Services.AddTransient<IAmericanFootballPlayerFactory, AmericanFootballPlayerFactory>();
builder.Services.AddTransient<AmericanFootballPlayerMapper>();
builder.Services.AddTransient<AmericanFootballPlayerService>();

builder.Services.AddTransient<IBaseballPlayerRepository, BaseballPlayerRepository>();
builder.Services.AddTransient<IBaseballPlayerFactory, BaseballPlayerFactory>();
builder.Services.AddTransient<BaseballPlayerMapper>();
builder.Services.AddTransient<BaseballPlayerService>();

builder.Services.AddTransient<IBasketballPlayerRepository, BasketballPlayerRepository>();
builder.Services.AddTransient<IBasketballPlayerFactory, BasketballPlayerFactory>();
builder.Services.AddTransient<BasketballPlayerMapper>();
builder.Services.AddTransient<BasketballPlayerService>();

builder.Services.AddTransient<IFootballPlayerRepository, FootballPlayerRepository>();
builder.Services.AddTransient<IFootballPlayerFactory, FootballPlayerFactory>();
builder.Services.AddTransient<FootballPlayerMapper>();
builder.Services.AddTransient<FootballPlayerService>();

builder.Services.AddTransient<IHandballPlayerRepository, HandballPlayerRepository>();
builder.Services.AddTransient<IHandballPlayerFactory, HandballPlayerFactory>();
builder.Services.AddTransient<HandballPlayerMapper>();
builder.Services.AddTransient<HandballPlayerService>();

builder.Services.AddTransient<IIceHockeyPlayerRepository, IceHockeyPlayerRepository>();
builder.Services.AddTransient<IIceHockeyPlayerFactory, IceHockeyPlayerFactory>();
builder.Services.AddTransient<IceHockeyPlayerMapper>();
builder.Services.AddTransient<IceHockeyPlayerService>();

// Adicione o serviço de CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowSpecificOrigin",
        policy =>
        {
            policy.WithOrigins("http://localhost:4200")
                .AllowAnyHeader()
                .AllowAnyMethod()
                .AllowCredentials();
        });
});

var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("/ping", () => "pong");


app.UseCors("AllowSpecificOrigin");
app.UseAuthorization();

app.MapControllers();

app.Run();

public partial class Program
{
}