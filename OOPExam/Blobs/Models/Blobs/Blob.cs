namespace Blobs.Models
{
    using Engine;
    using System;
    using Interfaces;
    using Behaviors;
    using EventArgs;

    public class Blob : IBlob
    {
        private readonly int InitialHealth;
        private readonly int InitialDamage;

        public event BlobToggledBehaviorEventHandler BlobToggledBehavior;
        public event BlobWasKilledEventHandler BlobWasKilled;

        private string name;
        private int health;
        private int damage;

        public Blob(string name, int health, int damage, IAttack attackType, IBehavior behaviorType)
        {
            this.Name = name;
            this.Health = health;
            this.InitialHealth = this.Health;
            this.Damage = damage;
            this.InitialDamage = this.Damage;
            this.AttackType = attackType;
            this.BehaviorType = behaviorType;
            this.HasUsedBehavior = false;
        }

        public bool IsAlive
        {
            get
            {
                return this.Health > 0;
            }
        }

        public bool HasUsedBehavior { get; private set; }

        public bool UsedBehaviorThisTurn { get; set; }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Name cannot be contain only whitespaces or be null.");
                }

                this.name = value;
            }
        }

        public int Health
        {
            get
            {
                return this.health;
            }

            set
            {
                if (value <= 0)
                {
                    this.health = 0;
                    if (this.BlobWasKilled != null)
                    {
                        this.BlobWasKilled(this, new BlobWasKilledEventArgs(this));
                    }
                }

                this.health = value;

                if (value <= this.InitialHealth / 2)
                {
                    this.TriggerBehavior();
                }    
            }
        }

        public int Damage
        {
            get
            {
                return this.damage;
            }

            set
            {
                if (value < 0)
                {
                    this.damage = 0;
                }

                if (value >= this.InitialDamage)
                {
                    this.damage = value;
                }
            }
        }

        public IAttack AttackType { get; private set; }

        public IBehavior BehaviorType { get; private set; }

        public void Attack(IBlob blob)
        {
            if (this.IsAlive && blob.IsAlive)
            {
                this.AttackType.ExecuteAttackCommand(this, blob);
            }
        }

        public void TriggerBehavior()
        {
            if (!this.HasUsedBehavior)
            {
                if (this.BlobToggledBehavior != null)
                {
                    this.BlobToggledBehavior(this, new BlobToggledBehaviorEventArgs(this, this.BehaviorType));
                }
                this.BehaviorType.ExecuteBehavior(this);
                this.HasUsedBehavior = true;
            }
        }

        public void Debuff(string property, int amount)
        {
            switch (property)
            {
                case "health":
                    this.Health -= amount;
                    break;
                case "damage":
                    this.Damage -= amount;
                    break;
            }
        }

        public void Update()
        {
            if (this.HasUsedBehavior && !this.UsedBehaviorThisTurn)
            {
                if (this.BehaviorType is Aggressive && this.InitialDamage < this.Damage)
                {
                    this.Debuff("damage", 5);
                }
                else if (this.BehaviorType is Inflated)
                {
                    this.Debuff("health", 10);
                }
            }

            if (this.UsedBehaviorThisTurn)
            {
                this.UsedBehaviorThisTurn = false;
            }
        }

        public override string ToString()
        {
            string blobStatus = string.Empty;

            if (this.IsAlive)
            {
                blobStatus = string.Format("Blob {0}: {1} HP, {2} Damage",
                this.Name, this.Health, this.Damage);
            }
            else
            {
                blobStatus = string.Format("Blob {0} KILLED", this.Name);
            }

            return blobStatus;
        }
    }
}
