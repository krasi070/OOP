namespace Blobs.Models.EventArgs
{
    using Interfaces;

    public class BlobWasKilledEventArgs
    {
        public BlobWasKilledEventArgs(IBlob blob)
        {
            this.Blob = blob;
        }

        public IBlob Blob { get; set; }
    }
}
