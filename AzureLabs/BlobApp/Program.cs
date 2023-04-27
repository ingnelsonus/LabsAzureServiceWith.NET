using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using BlobApp;

string connectionString = "DefaultEndpointsProtocol=https;AccountName=appstoragelab1793;AccountKey=bcpS2tbd1n7jNwCXuwemYVwEgO0OB8WRMQvNd+Webo/IxNRoMmw8pDqsLlMz40Hx2zGjRkvUtdeJ+AStvm+eYw==;EndpointSuffix=core.windows.net";
string containerName = "script";
string blobName = "ScriptLab1.sql";
string filepath = @"C:\\Users\faneu\\OneDrive\\Escritorio\\ScriptLab1.txt";


/// <summary>
/// 1. Use this for create a container
/// </summary>
//BlobServiceClient blobServiceClient = new BlobServiceClient(connectionString);
//var result = await blobServiceClient.CreateBlobContainerAsync(containerName, PublicAccessType.Blob);


/// <summary>
/// 2. Use this to upload file in a container
/// </summary>
//BlobContainerClient blobServiceClient = new BlobContainerClient(connectionString, containerName);
//var blobClient = blobServiceClient.GetBlobClient(blobName);
//var result = await blobClient.UploadAsync(filepath, true);
//Console.WriteLine("Uploaded the blob successfully");

/// <summary>
/// 3. Use interate in each file.
/// </summary>
//BlobContainerClient blobContainerClient = new BlobContainerClient(connectionString, containerName);
//await foreach(BlobItem item in blobContainerClient.GetBlobsAsync())
//{
//    Console.WriteLine(item.Name);
//}

/// <summary>
/// 4. DownLoad file from the storage account.
/// </summary>
//BlobClient blobClient = new BlobClient(connectionString, containerName, blobName);
//var resultdownLoad = await blobClient.DownloadToAsync(filepath);
//Console.WriteLine("The blob was downLoad successfully.");


/// <summary>
/// 5. Set and Get metaData to a Blob.
/// </summary>
//await SetMetaData();
//await GetMetadata();

//async Task SetMetaData()
//{
//    string connectionString = "DefaultEndpointsProtocol=https;AccountName=appstoragelab1793;AccountKey=bcpS2tbd1n7jNwCXuwemYVwEgO0OB8WRMQvNd+Webo/IxNRoMmw8pDqsLlMz40Hx2zGjRkvUtdeJ+AStvm+eYw==;EndpointSuffix=core.windows.net";
//    string containerName = "script";
//    string blobName = "ScriptLab1.sql";
//    BlobClient blobClient = new BlobClient(connectionString,containerName,blobName);

//    IDictionary<string, string> metadata = new Dictionary<string, string>();
//    metadata.Add("Department", "Logistic");
//    metadata.Add("Application", "App#1");
//    var result = await blobClient.SetMetadataAsync(metadata);

//    Console.WriteLine($"metaData setting correctly");

//}

//async Task GetMetadata()
//{
//    string connectionString = "DefaultEndpointsProtocol=https;AccountName=appstoragelab1793;AccountKey=bcpS2tbd1n7jNwCXuwemYVwEgO0OB8WRMQvNd+Webo/IxNRoMmw8pDqsLlMz40Hx2zGjRkvUtdeJ+AStvm+eYw==;EndpointSuffix=core.windows.net";
//    string containerName = "script";
//    string blobName = "ScriptLab1.sql";
//    BlobClient blobClient = new BlobClient(connectionString, containerName, blobName);
//    BlobProperties blobProperties = await blobClient.GetPropertiesAsync();

//    foreach(var metaValue in blobProperties.Metadata)
//    {
//        Console.WriteLine($"Key: {metaValue.Key}. Value: {metaValue.Value}");
//    }
//} 


/// <summary>
/// 6. Table Storage
/// </summary>
/// 
TableStorageExample tableStorageExample = new TableStorageExample();
tableStorageExample.TestTableStorage();