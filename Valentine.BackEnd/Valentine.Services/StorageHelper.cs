using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Auth;
using Microsoft.WindowsAzure.Storage.Blob;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static Valentine.Util.Constants;

namespace Valentine.Services
{
    public class StorageHelper
    {
        private const string cloudStorageAccountConnectionString = "DefaultEndpointsProtocol=https;AccountName=valentine;AccountKey=vIoW8lcoxcMzyEkssFQAxvFmiwxQoy34YA+B6VjclXaT1QBXG+/knnmh+UeCsqYeAPQrQl48k9Um13X0Ri9ZHQ==;EndpointSuffix=core.windows.net";
        public static string GetSasToken(string containerType)
        {
            if (!ContainerType.ContainerTypes.Contains(containerType))
            {
                return "";
            }

            CloudStorageAccount account = CloudStorageAccount.Parse(cloudStorageAccountConnectionString);
            CloudBlobClient client = account.CreateCloudBlobClient();
            CloudBlobContainer container = client.GetContainerReference(containerType);
            container.CreateIfNotExistsAsync();

            SharedAccessBlobPolicy policy = new SharedAccessBlobPolicy()
            {
                Permissions = SharedAccessBlobPermissions.Read | SharedAccessBlobPermissions.Write,
                SharedAccessStartTime = DateTime.UtcNow.AddMinutes(StorageSettings.StartTime),
                SharedAccessExpiryTime = DateTime.UtcNow.AddMinutes(StorageSettings.ExpiryTime)
            };

            string sharedAccessSignature = container.GetSharedAccessSignature(policy);
            string containerWithSasUri = string.Format("{0}{1}", container.Uri, sharedAccessSignature);

            return sharedAccessSignature.Substring(1);
        }

        private static CloudBlobContainer GetContainer(string container)
        {
            try
            {
                var sasToken = GetSasToken(container);
                string storageAccountName = StorageSettings.StorageAccount;
                StorageCredentials credentials = new StorageCredentials(sasToken);

                CloudStorageAccount account = new CloudStorageAccount(credentials, storageAccountName, null, true);

                var client = account.CreateCloudBlobClient();

                // Gets a reference to the images container
                var cloudBlobContainer = client.GetContainerReference(container);
                return cloudBlobContainer;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static string UploadAsync(string container, string name, byte[] image)
        {
            try
            {
                var cloudBlobContainer = GetContainer(container);
                // Uploads the image the blob storage
                var imageBlob = cloudBlobContainer.GetBlockBlobReference(name);
                imageBlob.UploadFromByteArrayAsync(image, 0, image.Length);
                imageBlob.SetPropertiesAsync();

                return name;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}