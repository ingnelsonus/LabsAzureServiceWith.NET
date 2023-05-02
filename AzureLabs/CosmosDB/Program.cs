using Microsoft.Azure.Cosmos;

string cosmosEndpointUri = "https://faneusnosqllab01.documents.azure.com:443/";
string cosmosDBKey = "CZzMa5AiWuhldlCc3gpFhyoc0es4vHSTCqTd5IJPrWnOjMdYmr2zH5G6u8AG4OmQhpj6qioGuJyWACDbPe2ONQ==";

//await CreateDataBase("appdb");
await CreateContainer("appdb","Orders","/category");

async Task CreateDataBase(string databaseName)
{
    CosmosClient cosmosClient = new CosmosClient(cosmosEndpointUri, cosmosDBKey);

    var dbcreateResult =await cosmosClient.CreateDatabaseAsync(databaseName);
    Console.WriteLine("Database created");
}

async Task CreateContainer(string databaseName, string containerName,string partitionKey)
{
    CosmosClient cosmosClient = new CosmosClient(cosmosEndpointUri, cosmosDBKey);

    Database database = cosmosClient.GetDatabase(databaseName);
    var result = await database.CreateContainerAsync(containerName, partitionKey);
    Console.WriteLine($"Container {containerName} created on db {databaseName}");
}