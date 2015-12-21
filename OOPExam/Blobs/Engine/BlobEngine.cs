namespace Blobs.Engine
{
    using System.Reflection;
    using System;
    using System.Linq;
    using Databases;
    using Models;
    using Models.Attacks;
    using Models.Behaviors;
    using Interfaces;
    using Models.EventArgs;

    public class BlobEngine : IEngine
    {
        private const string BehaviorsBase = "Blobs.Models.Behaviors.";
        private const string AttacksBase = "Blobs.Models.Attacks.";
        private const string ReportEventsCommand = "report-events";

        private IUserInterface userInterface;
        private IBlobDatabase database = new BlobDatabase();

        public BlobEngine(IUserInterface userInterface)
        {
            this.userInterface = userInterface;
        }

        public void Run()
        {
            string[] inputArgs = this.userInterface.ReadLine().Split();

            if (inputArgs[0] == ReportEventsCommand)
            {
                this.IsReportEventsFirstCommand = true;
            }
            else
            {
                this.IsReportEventsFirstCommand = false;
            }

            while (true)
            {
                string output = this.ExecuteCommand(inputArgs);

                if (output != null)
                {
                    this.userInterface.Write(output);
                }

                foreach (var blob in this.database.Blobs)
                {
                    blob.Update();
                }

                inputArgs = this.userInterface.ReadLine().Split();
            }
        }

        private bool IsReportEventsFirstCommand { get; set; }

        public void OnBlobToggledBehavior(object sender, BlobToggledBehaviorEventArgs eventArgs)
        {
            this.userInterface.WriteLine("Blob {0} toggled {1}", eventArgs.Blob.Name, eventArgs.Behavior.ToString());
        }

        public void OnBlobWasKilled(object sender, BlobWasKilledEventArgs eventArgs)
        {
            this.userInterface.WriteLine("Blob {0} was killed", eventArgs.Blob.Name);
        }

        private string ExecuteCommand(string[] inputArgs)
        {
            string result = null;

            switch (inputArgs[0])
            {
                case "create":
                    this.ExecuteCreateCommand(inputArgs);
                    break;
                case "attack":
                    this.ExecuteAttackCommand(inputArgs);
                    break;
                case "pass":
                    break;
                case "status":
                    result = this.ExecuteStatusCommand();
                    break;
                case "drop":
                    Environment.Exit(0);
                    break;
            }

            return result;
        }

        private void ExecuteCreateCommand(string[] inputArgs)
        {
            string name = inputArgs[1];
            int health = int.Parse(inputArgs[2]);
            int damage = int.Parse(inputArgs[3]);
            string behavior = inputArgs[4];
            string attack = inputArgs[5];

            var behaviorType = Assembly.GetExecutingAssembly().GetType(BehaviorsBase + behavior);
            IBehavior blobBehavior = Activator.CreateInstance(behaviorType) as IBehavior;

            var attackType = Assembly.GetExecutingAssembly().GetType(AttacksBase + attack);
            IAttack blobAttack = Activator.CreateInstance(attackType) as IAttack;

            IBlob blob = new Blob(name, health, damage, blobAttack, blobBehavior);
            this.database.AddBlob(blob);

            if (this.IsReportEventsFirstCommand)
            {
                blob.BlobWasKilled += this.OnBlobWasKilled;
                blob.BlobToggledBehavior += this.OnBlobToggledBehavior;
            }
        }

        private void ExecuteAttackCommand(string[] inputArgs)
        {
            IBlob attacker = this.GetBlobByName(inputArgs[1]);
            IBlob target = this.GetBlobByName(inputArgs[2]);

            attacker.Attack(target);
        }

        private string ExecuteStatusCommand()
        {
            string status = string.Empty;

            foreach (var blob in this.database.Blobs)
            {
                status += string.Format("{0}{1}", blob.ToString(), Environment.NewLine);
            }

            return status;
        }

        private IBlob GetBlobByName(string name)
        {
            return this.database.Blobs.FirstOrDefault(b => b.Name == name);
        }
    }
}
