using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;

string connectionString = "DefaultEndpointsProtocol=https;AccountName=appstoragelab1793;AccountKey=bcpS2tbd1n7jNwCXuwemYVwEgO0OB8WRMQvNd+Webo/IxNRoMmw8pDqsLlMz40Hx2zGjRkvUtdeJ+AStvm+eYw==;EndpointSuffix=core.windows.net";
string containerName = "script";
string blobName = "ScriptLab1.sql";
string filepath = @"C:\\Users\faneu\\OneDrive\\Escritorio\\ScriptLab1.txt";


/// <summary>
/// Use this for create a container
/// </summary>
//BlobServiceClient blobServiceClient = new BlobServiceClient(connectionString);
//var result = await blobServiceClient.CreateBlobContainerAsync(containerName, PublicAccessType.Blob);


/// <summary>
/// Use this to upload file in a container
/// </summary>
//BlobContainerClient blobServiceClient = new BlobContainerClient(connectionString,containerName);
//var blobClient = blobServiceClient.GetBlobClient(blobName);
//var result = await blobClient.UploadAsync(filepath, true);


/// <summary>
/// Use this to upload file in a container
/// </summary>
//BlobContainerClient blobContainerClient = new BlobContainerClient(connectionString, containerName);
//await foreach(BlobItem item in blobContainerClient.GetBlobsAsync())
//{
//    Console.WriteLine(item.Name);
//}


//Console.WriteLine("Uploaded the blob successfully");