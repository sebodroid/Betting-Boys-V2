using System;
using Microsoft.EntityFrameworkCore;
using Npgsql;
using Betting_Boys_V2.Server;
using Betting_Boys_V2.Server.Repositories;

try
{
    var builder = WebApplication.CreateBuilder(args);

    // Get the connection string
    var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");


    // Register PostgreSQL DbContext
    builder.Services.AddDbContext<AppDbContext>(options =>
        options.UseNpgsql(connectionString));

    //Register the Repository
    builder.Services.AddScoped<PassingRepository>();
    builder.Services.AddScoped<RushingRepository>();
    builder.Services.AddScoped<ReceivingRepository>();
    builder.Services.AddScoped<NflSeasonRepository>();


    // Register controllers
    builder.Services.AddControllers();

    // Allow frontend (React) to talk to backend (CORS)
    builder.Services.AddCors(options =>
    {
        options.AddPolicy("AllowAll", policy =>
            policy.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
    });

    var app = builder.Build();

    app.UseCors("AllowAll");
    app.MapControllers();

    app.Run();
}
catch(Exception e)
{
    DateTime currentTime = DateTime.Now;
    Console.WriteLine($"Error @{currentTime}" + e);
}

