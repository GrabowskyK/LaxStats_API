using LaxStats.Models;
using LaxStats.Models.MatchStats;
using LaxStats_API.Database;
using LaxStats_API.ViewModel;
using Microsoft.EntityFrameworkCore;

namespace LaxStats_API.Services.GameServ
{
    public class GameService : IGameService
    {
        private readonly DatabaseContext databaseContext;

        public GameService(DatabaseContext _databaseContext)
        {
            databaseContext = _databaseContext;
        }

        public void AddGame(Game game)
        {
            databaseContext.Games.Add(game);
            databaseContext.SaveChanges();
        }

        public IEnumerable<Game> GetGames() => databaseContext.Games
            .Include(g => g.League);

        public IEnumerable<Game> GetGamesByLeagueId(int leagueId) => databaseContext.Games
            .Where(g => g.LeagueId == leagueId);

        public void AddStatsToGame(int gameId, Team team)
        {
            FaceOff newFaceOff = new FaceOff(gameId, team.Name);
            databaseContext.FaceOffs.Add(newFaceOff);

            Groundballs newGrandballs = new Groundballs(gameId, team.Name);
            databaseContext.Groundballs.Add(newGrandballs);

            Shots newShots = new Shots(gameId, team.Name);
            databaseContext.Shots.Add(newShots);

            ShotsWide newWideShots = new ShotsWide(gameId, team.Name);
            databaseContext.ShotsWides.Add(newWideShots);

            //foreach(var player in team.PlayerGoalies)
            //{
            //    GoalieSavesAndGoals newGoalieStats = new GoalieSavesAndGoals(gameId, player);
            //    databaseContext.GoalieStats.Add(newGoalieStats);
            //}

            databaseContext.SaveChanges();
        }

        public IEnumerable<Game> GetGameStats(int gameId) => databaseContext.Games
            .Where(g => g.Id == gameId)
            .Include(g => g.HomeTeam)
            .Include(g => g.AwayTeam)
            .Include(g => g.Goals).ThenInclude(goal => goal.Player)
            .Include(g => g.Penalty).ThenInclude(goal => goal.Player)
            .Include(g => g.Timeouts)
            .Include(g => g.FaceOffs)
            .Include(g => g.Shots)
            .Include(g => g.ShotsWides)
            .Include(g => g.Groundballs)
            .Select(g => new Game
            {
                Id = g.Id,
                HomeTeam = g.HomeTeam,
                AwayTeam = g.AwayTeam,
                ScoreHomeTeam = g.ScoreHomeTeam,
                ScoreAwayTeam = g.ScoreAwayTeam,
                Place = g.Place,
                DateTime = g.DateTime,
                IsEnded = g.IsEnded,
                Goals = g.Goals,
                Penalty = g.Penalty,
                Timeouts = g.Timeouts,
                FaceOffs = g.FaceOffs,
                Shots = g.Shots,
                ShotsWides = g.ShotsWides,
                Groundballs = g.Groundballs
            }).ToList();
            //.Select(g => new GameVM
            //{
            //    Id = g.Id,
            //    HomeTeam = new TeamVM { TeamId = g.HomeTeam.Id, Name = g.HomeTeam.Name, ShortName = g.HomeTeam.ShortName},
            //    AwayTeam = new TeamVM { TeamId = g.AwayTeam.Id, Name = g.AwayTeam.Name, ShortName = g.AwayTeam.ShortName},
            //    DateTime = g.DateTime,
            //    ScoreHomeTeam = g.ScoreHomeTeam,
            //    ScoreAwayTeam = g.ScoreAwayTeam,
            //    Place = g.Place,
            //    IsEnded = g.IsEnded,
            //    League = new LeagueVM {LeagueId = g.League.Id, LeagueName = g.League.Name},
            //    Goals = g.Goals,
            //    Penalty = g.Penalty,
            //    Timeouts = g.Timeouts,
            //    FaceOffs = g.FaceOffs,
            //    Shots = g.Shots,
            //    ShotsWides = g.ShotsWides,
            //    Groundballs = g.Groundballs
            //})
    }
}
