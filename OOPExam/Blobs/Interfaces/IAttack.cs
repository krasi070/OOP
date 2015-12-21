namespace Blobs.Interfaces
{
    public interface IAttack
    {
        void ExecuteAttackCommand(IBlob attacker, IBlob target);
    }
}
