using System.IO;
using System.Threading.Tasks;
using Azure.Storage.Blobs;
using Microsoft.Extensions.Configuration;

namespace WebApplication1.Services
{
    public class BlobStorageService
    {

        private readonly string _connectionString;
        private readonly string _containerName;

        public BlobStorageService(IConfiguration configuration)
        {
            _connectionString = configuration["AzureBlobStorage:ConnectionString"];
            _containerName = configuration["AzureBlobStorage:ContainerName"];
        }

        public async Task<string> UploadImageAsync(Stream fileStream, string fileName)
        {
            var blobServiceClient = new  BlobServiceClient(_connectionString);
            var containerClient = blobServiceClient.GetBlobContainerClient(_containerName);
            var blobClient = containerClient.GetBlobClient(fileName);

            //await blobClient.UploadAsync();

            return blobClient.Uri.ToString();
        }
    }
}
