using LaxStats_API.Database;
using LaxStats_API.Models;
using LaxStats_API.Services.LeagueServ;
using LaxStats_API.Services.TeamServ;
using LaxStats_API.Services.GameServ;
using Microsoft.EntityFrameworkCore;
using LaxStats_API.Services.PlayerServ;
using LaxStats_API.Services.EventGoalServ;
using LaxStats_API.Services.EventPenaltyServ;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddScoped<ILeagueService, LeagueService>();
builder.Services.AddScoped<ITeamService, TeamService>();
builder.Services.AddScoped<IPlayerService, PlayerService>();
builder.Services.AddScoped<IGameService, GameService>();
builder.Services.AddScoped<IEventGoalService, EventGoalService>();
builder.Services.AddScoped<IEventPenaltyService, EventPenaltyService>();
builder.Services.AddHttpContextAccessor();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<DatabaseContext>(options => options.UseSqlServer("Server = (localdb)\\mysql; Database = LaxStats_v4; Trusted_Connection = True; MultipleActiveResultSets = true"));

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
