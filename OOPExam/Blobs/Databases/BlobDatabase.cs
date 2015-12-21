namespace Blobs.Databases
{
    using System.Collections.Generic;
    using Interfaces;

    public class BlobDatabase : IBlobDatabase
    {
        private IList<IBlob> blobs = new List<IBlob>();

        public IList<IBlob> Blobs
        {
            get
            {
                return this.blobs;
            }
        }

        public void AddBlob(IBlob blob)
        {
            this.Blobs.Add(blob);
        }
    }
}
