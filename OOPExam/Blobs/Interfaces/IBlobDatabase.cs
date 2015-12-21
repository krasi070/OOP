namespace Blobs.Interfaces
{
    using System.Collections.Generic;

    public interface IBlobDatabase
    {
        IList<IBlob> Blobs { get; }

        void AddBlob(IBlob blob);
    }
}
