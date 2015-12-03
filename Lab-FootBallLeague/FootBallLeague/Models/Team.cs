namespace FootBallLeague.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Team
    {
        private string name;
        private string nickname;
        private DateTime dateOfFounding;
        private List<Player> players;

        private const int MinimumAllowedDateOfFounding = 1850;

        public Team(string name, string nickname, DateTime dateOfFounding)
        {
            this.Name = name;
            this.Nickname = nickname;
            this.DateOfFounding = dateOfFounding;
            this.players = new List<Player>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 5)
                {
                    throw new ArgumentOutOfRangeException("Team name cannot be less than 5 characters long");
                }

                this.name = value;
            }
        }

        public string Nickname
        {
            get
            {
                return this.nickname;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 5)
                {
                    throw new ArgumentOutOfRangeException("Team nickname cannot be less than 5 characters long");
                }

                this.nickname = value;
            }
        }

        public DateTime DateOfFounding
        {
            get
            {
                return this.dateOfFounding;
            }

            set
            {
                if (value.Year < MinimumAllowedDateOfFounding)
                {
                    throw new ArgumentOutOfRangeException("Date of founding cannot be before " + MinimumAllowedDateOfFounding);
                }

                this.dateOfFounding = value;
            }
        }

        public IEnumerable<Player> Players 
        {
            get { return this.players; }
        }

        public void AddPlayer(Player player)
        {
            if (CheckIfPlayerExists(player))
            {
                throw new InvalidOperationException("Player already exists in this team");    
            }

            this.players.Add(player);
        }

        public override string ToString()
        {
            return string.Format("Team: {0}({1})\nPlayers in {0}: {2}",
                this.Name, this.Nickname, GetPlayerNames());
        }

        private bool CheckIfPlayerExists(Player player)
        {
            return this.players.Any(p => p.FirstName == player.FirstName &&
                p.LastName == player.LastName);
        }

        private string GetPlayerNames()
        {
            string playerNames = this.players[0].FirstName + " " + this.players[0].LastName;

            for (int i = 1; i < this.players.Count; i++)
            {
                playerNames += ", " + this.players[i].FirstName + " " + this.players[i].LastName;
            }

            return playerNames;
        }
    }
}
