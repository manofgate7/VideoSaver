using Npgsql;
using System.Data;
using System.Data.SqlClient;
using VideoSaver.Data;
using VideoSaver.Data.Interfaces;
using VideoSaver.Services;
using VideoSaver.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Read the connection string from appsettings.
string? dbConnectionString = builder.Configuration["DbConnection"];

// Inject IDbConnection, with implementation from SqlConnection class.
builder.Services.AddTransient<IDbConnection>((sp) => new NpgsqlConnection(dbConnectionString));
builder.Services.AddScoped<IDatabase, Database>();
builder.Services.AddScoped<IVideoService, VideoService>();

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
