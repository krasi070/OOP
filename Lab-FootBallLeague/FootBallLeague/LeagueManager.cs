namespace FootBallLeague
{
    using System;
    using System.Linq;
    using Models;

    public static class LeagueManager
    {
        public static void HandleInput(string input)
        {
            var inputArgs = input.Split();
            switch (inputArgs[0])
            {
                case "AddTeam":
                    AddTeam(inputArgs[1], inputArgs[2], DateTime.Parse(inputArgs[3]));
                    break;
                case "AddMatch":
                    AddMatch(inputArgs[1], inputArgs[2], int.Parse(inputArgs[3]),
                        int.Parse(inputArgs[4]), int.Parse(inputArgs[5]));
                    break;
                case "AddPlayerToTeam":
                    AddPlayerToTeam(inputArgs[1], inputArgs[2], Decimal.Parse(inputArgs[3]),
                        DateTime.Parse(inputArgs[4]), inputArgs[5]);
                    break;
                case "ListTeams":
                    ListTeams();
                    break;
                case "ListMatches":
                    ListMatches();
                    break;
                default:
                    Console.WriteLine("[unknown command]");
                    break;
            }
        }

        private static void AddTeam(string name, string nickname, DateTime dateOfFounding)
        {
            if (CheckIfTeamExists(name))
            {
                throw new InvalidOperationException(name + " are already in the league");
            }

            Team team = new Team(name, nickname, dateOfFounding);
            League.AddTeam(team);
            Console.WriteLine("{0} ({1}) were added to the league", team.Name, team.Nickname);
        }

        private static void AddMatch(string homeTeam, string awayTeam, int scoreHT, int scoreAT, int id)
        {
            if (!CheckIfTeamExists(homeTeam) || !CheckIfTeamExists(awayTeam))
            {
                throw new ArgumentException("Team(s) do(es) not exist");   
            }

            if (CheckIfMatchExists(id))
            {
                throw new InvalidOperationException(id + " has already been added to the league");
            }

            Score score = new Score(scoreAT, scoreHT);

            Match match = new Match(GetTeamByName(homeTeam), GetTeamByName(awayTeam), score, id);

            League.AddMatch(match);

            Console.WriteLine("The {0} match was added", match.ID);
        }

        private static void AddPlayerToTeam(string firstName, string lastName, decimal salary, DateTime dateOfBirth, string team)
        {
            Player player = new Player(firstName, lastName, salary, dateOfBirth, GetTeamByName(team));
            GetTeamByName(team).AddPlayer(player);

            Console.WriteLine("{0} {1} was added to {2}", player.FirstName, player.LastName, player.Team.Name);
        }

        private static void ListTeams()
        {
            Console.WriteLine("---------------------------------");

            foreach (var team in League.Teams)
            {
                Console.WriteLine("{0}\n---------------------------------", team.ToString());
            }
        }

        private static void ListMatches()
        {
            Console.WriteLine("---------------------------------");

            foreach (var match in League.Matches)
            {
                Console.WriteLine("{0}\n---------------------------------", match.ToString());
            }
        }

        private static bool CheckIfTeamExists(string name)
        {
            return League.Teams.Any(t => t.Name == name);
        }

        private static bool CheckIfMatchExists(int id)
        {
            return League.Matches.Any(m => m.ID == id);
        }

        private static Team GetTeamByName(string name)
        {
            return League.Teams.Single(t => t.Name == name);
        }
    }
}
