namespace Blobs.Models.EventArgs
{
    using Interfaces;

    public class BlobToggledBehaviorEventArgs
    {
        public BlobToggledBehaviorEventArgs(IBlob blob, IBehavior behavior)
        {
            this.Blob = blob;
            this.Behavior = behavior;
        }

        public IBlob Blob { get; set; }

        public IBehavior Behavior { get; set; }
    }
}
