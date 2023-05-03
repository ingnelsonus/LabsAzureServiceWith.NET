using CosmosDB;
using Microsoft.Azure.Cosmos;

string cosmosEndpointUri = "https://faneusnosqllab01.documents.azure.com:443/";
string cosmosDBKey = "CZzMa5AiWuhldlCc3gpFhyoc0es4vHSTCqTd5IJPrWnOjMdYmr2zH5G6u8AG4OmQhpj6qioGuJyWACDbPe2ONQ==";
string databaseName = "appdb";
string containerName = "Orders";

/// <summary>
/// Create dataBase on CosmosDB
/// </summary>
//await CreateDataBase("appdb");


/// <summary>
/// Create Container on CosmosDB
/// </summary>
//await CreateContainer("appdb","Orders","/category");


/// <summary>
/// Add Items in a container
/// </summary>
/// 

await AddItem("01","Laptop",100);
await AddItem("02", "Mobile", 100);
await AddItem("03", "Desktop", 100);
await AddItem("04", "Laptop", 100);


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

async Task AddItem(string orderId,string category,int quantity)
{
    CosmosClient cosmosClient = new CosmosClient(cosmosEndpointUri, cosmosDBKey);

    Database database = cosmosClient.GetDatabase(databaseName);
    Container container = database.GetContainer(containerName);

    Order order = new Order()
    {
        id =Guid.NewGuid().ToString(),
        orderId = orderId,
        category = category,
        quantity = quantity
    };

    var response =await container.CreateItemAsync<Order>(order,new PartitionKey(category));
    Console.WriteLine("Added item with orderID: " + orderId);

}
