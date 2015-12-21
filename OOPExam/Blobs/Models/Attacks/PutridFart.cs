namespace Blobs.Models.Attacks
{
    using Interfaces;

    public class PutridFart : Attack
    {
        public override void ExecuteAttackCommand(IBlob attacker, IBlob target)
        {
            target.Health -= attacker.Damage;
        }
    }
}
