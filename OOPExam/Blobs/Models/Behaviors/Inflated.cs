namespace Blobs.Models.Behaviors
{
    using Interfaces;

    public class Inflated : Behavior
    {
        public override void ExecuteBehavior(IBlob blob)
        {
            blob.Health += 50;

            blob.UsedBehaviorThisTurn = true;
        }
    }
}
