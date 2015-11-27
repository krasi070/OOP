using System;

namespace _02.WorkingWithAbstraction.Characters
{
    public class Warrior : Character
    {
        public Warrior(int health, int mana, int damage)
            : base(300, 0, 120)
        {
 
        }

        public override void Attack(Character other)
        {
            other.Health -= this.Damage;
        }
    }
}
