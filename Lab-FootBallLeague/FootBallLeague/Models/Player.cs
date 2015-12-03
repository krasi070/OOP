namespace FootBallLeague.Models
{
    using System;

    public class Player
    {
        private string firstName;
        private string lastName;
        private decimal salary;
        private DateTime dateOfBirth;
        private Team team;

        private const int MinimumAllowedYear = 1980;

        public Player(string firstName, string lastName, decimal salary, DateTime dateOfBirth, Team team)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Salary = salary;
            this.DateOfBirth = dateOfBirth;
            this.Team = team;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 3)
                {
                    throw new ArgumentOutOfRangeException("First name cannot be less than 3 characters long");
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 3)
                {
                    throw new ArgumentOutOfRangeException("Last name cannot be less than 3 characters long");
                }

                this.lastName = value;
            }
        }

        public decimal Salary
        {
            get
            {
                return this.salary;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Salary cannot be negative");
                }

                this.salary = value;
            }
        }

        public DateTime DateOfBirth
        {
            get
            {
                return this.dateOfBirth;
            }

            set
            {
                if (value.Year < MinimumAllowedYear)
                {
                    throw new ArgumentOutOfRangeException("Date of birth cannot be before the year " + MinimumAllowedYear);
                }

                this.dateOfBirth = value;
            }
        }

        public Team Team
        {
            get
            {
                return this.team;
            }

            set
            {
                this.team = value;
            }
        }
    }
}
