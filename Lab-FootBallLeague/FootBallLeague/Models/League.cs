namespace FootBallLeague.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class League
    {
        private static List<Match> matches = new List<Match>();
        private static List<Team> teams = new List<Team>();

        public static IEnumerable<Match> Matches
        {
            get { return matches; }
        }

        public static IEnumerable<Team> Teams
        {
            get { return teams; }
        }

        public static void AddMatch(Match match)
        {
            if (CheckIfMatchExists(match))
            {
                throw new InvalidOperationException("This match already exists in this league");
            }

            matches.Add(match);
        }

        public static void AddTeam(Team team)
        {
            if (CheckIfTeamExists(team))
            {
                throw new InvalidOperationException("This team is already in this league");
            }

            teams.Add(team);
        }

        private static bool CheckIfMatchExists(Match match)
        {
            return matches.Any(m => m.ID == match.ID);
        }

        private static bool CheckIfTeamExists(Team team)
        {
            return teams.Any(t => t.Name == team.Name);
        }
    }
}
