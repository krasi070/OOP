namespace Blobs.Models.Behaviors
{
    using Interfaces;

    public abstract class Behavior : IBehavior
    {
        public abstract void ExecuteBehavior(IBlob blob);

        public override string ToString()
        {
            string behaviorString = this.GetType().Name + "Behavior";

            return behaviorString;
        }
    }
}
