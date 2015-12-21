namespace Blobs.Models.Attacks
{
    using Interfaces;

    public abstract class Attack : IAttack
    {
        public abstract void ExecuteAttackCommand(IBlob attacker, IBlob target);
    }
}
