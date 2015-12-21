namespace Blobs.Interfaces
{
    public interface IAttackable
    {
        int Health { get; set; }

        bool IsAlive { get; }
    }
}
