namespace Blobs.Interfaces
{
    using Models;

    public interface IBlob : INameable, IAttacker, IAttackable, IBehaviorable, IDebuffable, IUpdateable
    {
        event BlobToggledBehaviorEventHandler BlobToggledBehavior;

        event BlobWasKilledEventHandler BlobWasKilled;
    }
}
