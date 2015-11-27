using System;

namespace _02.WorkingWithAbstraction.Characters
{
    public class Mage : Character
    {
        public Mage(int health, int mana, int damage)
            : base(100, 300, 75)
        {
 
        }

        public override void Attack(Character other)
        {
            this.Mana -= 100;
            other.Health -= 2 * this.Damage;
        }
    }
}
