namespace Blobs.Models.Behaviors
{
    using Interfaces;

    public class Aggressive : Behavior
    {
        public override void ExecuteBehavior(IBlob blob)
        {
            blob.Damage *= 2;

            blob.UsedBehaviorThisTurn = true;
        }
    }
}
