using System;
using _02.WorkingWithAbstraction.Interfaces;

namespace _02.WorkingWithAbstraction.Characters
{
    public class Priest : Character, IHeal
    {
        public Priest(int health, int mana, int damage)
            : base(125, 200, 100)
        {
 
        }

        public override void Attack(Character other)
        {
            this.Mana -= 100;
            other.Health -= this.Damage;
            this.Health += this.Damage / 10;
        }

        public void Heal(Character other)
        {
            this.Mana -= 100;
            other.Health += 150;
        }
    }
}
