namespace FootBallLeague.Models
{
    using System;

    public class Match
    {
        private Team homeTeam;
        private Team awayTeam;

        public Match(Team homeTeam, Team awayTeam, Score score, int id)
        {
            this.HomeTeam = homeTeam;
            this.AwayTeam = awayTeam;
            this.Score = score;
            this.ID = id;
        }

        public Team HomeTeam
        {
            get
            {
                return this.homeTeam;
            }

            set
            {
                this.homeTeam = value;
            }
        }

        public Team AwayTeam
        {
            get
            {
                return this.awayTeam;
            }

            set
            {
                if (value.Name == this.HomeTeam.Name)
                {
                    throw new ArgumentException("Home team and away team cannot be the same");
                }

                this.awayTeam = value;
            }
        }

        public Score Score { get; set; }

        public int ID { get; set; }

        public Team GetWinner()
        {
            if (this.IsDraw())
            {
                return null;
            }

            return this.Score.AwayTeamGoals > this.Score.HomeTeamGoals 
                ? this.AwayTeam 
                : this.HomeTeam;
        }

        public override string ToString()
        {
            return string.Format("Match: {0}\n{1}(Home Team) vs {2}(Away Team)\nScore: {3} - {4}",
                this.ID, this.homeTeam.Name, this.AwayTeam.Name, this.Score.HomeTeamGoals, this.Score.AwayTeamGoals);
        }

        private bool IsDraw()
        {
            return this.Score.HomeTeamGoals == this.Score.AwayTeamGoals;
        }
    }
}
