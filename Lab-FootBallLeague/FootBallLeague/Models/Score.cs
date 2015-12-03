namespace FootBallLeague.Models
{
    using System;

    public class Score
    {
        private int awayTeamGoals;
        private int homeTeamGoals;

        public Score(int awayTeamGoals, int homeTeamGoals)
        {
            this.AwayTeamGoals = awayTeamGoals;
            this.HomeTeamGoals = homeTeamGoals;
        }

        public int AwayTeamGoals
        {
            get
            {
                return this.awayTeamGoals;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Awat team goals cannot be negative");
                }

                this.awayTeamGoals = value;
            }
        }

        public int HomeTeamGoals
        {
            get
            {
                return this.homeTeamGoals;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Home team goals cannot be negative");
                }

                this.homeTeamGoals = value;
            }
        }
    }
}
