using Microsoft.Azure;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureBlogStorageTest.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Create blobs
            CloudStorageAccount storageAccount = CloudStorageAccount.Parse(CloudConfigurationManager.GetSetting("StorageConnectionString"));
            CloudBlobClient blobClient = storageAccount.CreateCloudBlobClient();
            CloudBlobContainer blobContainer = blobClient.GetContainerReference("documents");

            CloudBlockBlob blockBlob1 = blobContainer.GetBlockBlobReference("blob/doc1");
            byte[] bytes1 = File.ReadAllBytes(@"C:\temp\Attachments\Upload\TMRS_Change_Address.pdf");
            blockBlob1.UploadFromByteArray(bytes1,0,bytes1.Length);


            CloudBlockBlob blockBlob2 = blobContainer.GetBlockBlobReference("blob/doc2");
            byte[] bytes2 = File.ReadAllBytes(@"C:\temp\Attachments\Upload\TMRS_Roth Application.pdf");
            blockBlob2.UploadFromByteArray(bytes2, 0, bytes2.Length);
            */

            /*Download blob
            CloudStorageAccount storageAccount = CloudStorageAccount.Parse(CloudConfigurationManager.GetSetting("StorageConnectionString"));
            CloudBlobClient blobClient = storageAccount.CreateCloudBlobClient();
            CloudBlobContainer blobContainer = blobClient.GetContainerReference("documents");

            CloudBlockBlob blockBlob = blobContainer.GetBlockBlobReference("blob/doc1");
            blockBlob.FetchAttributes();
            long fileByteLength = blockBlob.Properties.Length;
            byte[] bytes = new byte[fileByteLength];
            blockBlob.DownloadToByteArray(bytes, 0);
            File.WriteAllBytes(@"C:\temp\Attachments\Dowload\TMRS_Change_Address.pdf", bytes);
            */

            /*Delete blob
            CloudStorageAccount storageAccount = CloudStorageAccount.Parse(CloudConfigurationManager.GetSetting("StorageConnectionString"));
            CloudBlobClient blobClient = storageAccount.CreateCloudBlobClient();
            CloudBlobContainer blobContainer = blobClient.GetContainerReference("documents");
            CloudBlockBlob blockBlob = blobContainer.GetBlockBlobReference("blob/doc1");
            blockBlob.Delete();
            */
            Console.ReadLine();
        }
    }
}
