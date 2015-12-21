namespace Blobs.Interfaces
{
    public interface IBehaviorable
    {
        IBehavior BehaviorType { get; }

        void TriggerBehavior();

        bool HasUsedBehavior { get; }

        bool UsedBehaviorThisTurn { get; set; }
    }
}
