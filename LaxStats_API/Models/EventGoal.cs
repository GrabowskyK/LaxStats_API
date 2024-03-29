﻿namespace LaxStats.Models
{
    public class EventGoal
    {
        public int Id { get; set; }
        public TimeSpan TimeGoal { get; set; } //when during the game
        public int PlayerId { get; set; }
        public Player Player { get; set; } // who
        public int? AssistId { get; set; }
        public Player? Assist { get; set; }
        public int GameId { get; set; }
        public Game Game {  get; set; }

        public EventGoal() { }

        public EventGoal(TimeSpan time, int playerId, int gameId, int? assistId = null)
        {
            TimeGoal = time;
            PlayerId = playerId;
            GameId = gameId;
            AssistId = assistId;
        }
    }
}
