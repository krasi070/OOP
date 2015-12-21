namespace Blobs.Interfaces
{
    public interface IAttacker
    {
        int Damage { get; set; }

        IAttack AttackType { get; }

        void Attack(IBlob other);
    }
}
