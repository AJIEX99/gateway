using System;
using System.Collections.Generic;
using System.IO;
using Azure.Storage.Blobs;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GhostNetwork.Gateway.AzureBlob
{
    class AzureBlobStorage : IAzureBlobStorage
    {

        private BlobContainerClient BlobContainerClient;

        public AzureBlobStorage(string connectionString, string containerName)
        {
            BlobContainerClient = new BlobContainerClient(connectionString, containerName);


        }
        public async Task<(string, int)> CreateBlobAsync(string BlobName, Stream stream)
        {
            if(! await CreateContainer())
            {
                return (default(string), 2);
            }

            BlobClient blob = BlobContainerClient.GetBlobClient(BlobName);

            if(await blob.ExistsAsync())
            {
                return (default(string), 1);
            }

            stream.Position = 0;

            await blob.UploadAsync(stream);

            return (blob.Uri.ToString(), default(int));

        }

        public async Task<int> DeleteBlobAsync(string BlobName)
        {
            if (!await CreateContainer())
            {
                return 2;
            }

            BlobClient blob = BlobContainerClient.GetBlobClient(BlobName);

            if (await blob.ExistsAsync())
            {
                await blob.DeleteAsync();

                return default(int);
            }

            return 3;
        }

        public async Task<(Stream, int)> GetStreamBlobAsync(string BlobName)
        {
            if (!await CreateContainer())
            {
                return (default(Stream), 2);
            }

            BlobClient blob = BlobContainerClient.GetBlobClient(BlobName);

            if (! await blob.ExistsAsync())
            {
                return (default(Stream), 3);
            }

            MemoryStream downloaded = new MemoryStream();

            await blob.DownloadToAsync(downloaded);

            return (downloaded, 2);
        }

        private async Task<bool> CreateContainer()
        {
            try
            {
                await BlobContainerClient.CreateIfNotExistsAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
