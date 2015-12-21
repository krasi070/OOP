namespace Blobs.Models
{
    using EventArgs;

    public delegate void BlobToggledBehaviorEventHandler(object sender, BlobToggledBehaviorEventArgs eventArgs);

    public delegate void BlobWasKilledEventHandler(object sender, BlobWasKilledEventArgs eventArgs);
}
