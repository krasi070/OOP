namespace _03.TheSlum.Characters
{
    using System.Collections.Generic;
    using System.Linq;
    using Interfaces;

    public class Healer : Character, IHeal
    {
        private const int DefaultHealthPoints = 75;
        private const int DefaultDefensePoints = 50;
        private const int DefaultHealingPoints = 60;
        private const int DefaultRange = 6;

        public Healer(string id, int x, int y, Team team)
            : base(id, x, y, DefaultHealthPoints, DefaultDefensePoints, team, DefaultRange)
        {
            this.HealingPoints = DefaultHealingPoints;
        }

        public int HealingPoints { get; set; }

        public override Character GetTarget(IEnumerable<Character> targetsList)
        {
            int indexOfCharacterWithLeastHealth = -1;
            int leastHealth = int.MaxValue;

            for (int i = 0; i < targetsList.ToList().Count; i++)
            {
                if (targetsList.ToList()[i].Team == this.Team && 
                    targetsList.ToList()[i].IsAlive &&
                    !targetsList.ToList()[i].Equals(this) &&
                    targetsList.ToList()[i].HealthPoints < leastHealth)
                {
                    leastHealth = targetsList.ToList()[i].HealthPoints;
                    indexOfCharacterWithLeastHealth = i;
                }
            }

            return indexOfCharacterWithLeastHealth > -1 ?
                targetsList.ToList()[indexOfCharacterWithLeastHealth] :
                null;
        }

        public override void AddToInventory(Item item)
        {
            base.Inventory.Add(item);
            base.ApplyItemEffects(item);
        }

        public override void RemoveFromInventory(Item item)
        {
            base.Inventory.Remove(item);
            base.RemoveItemEffects(item);
        }

        public override string ToString()
        {
            return base.ToString() + string.Format(", Healing: {0}", this.HealingPoints);
        }
    }
}
