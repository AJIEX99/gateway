using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace GhostNetwork.Gateway.AzureBlob
{
    public interface IAzureBlobStorage
    {
        Task<(string, int)> CreateBlobAsync(string BlobName, Stream stream);

        Task<(Stream,int)> GetStreamBlobAsync(string BlobName);

        Task<int> DeleteBlobAsync(string BlobName);
    }
}
