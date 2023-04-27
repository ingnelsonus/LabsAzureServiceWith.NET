using Azure;
using Azure.Data.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BlobApp
{
    public class TableStorageExample
    {
        string connectionString = "DefaultEndpointsProtocol=https;AccountName=appstoragelab1793;AccountKey=bcpS2tbd1n7jNwCXuwemYVwEgO0OB8WRMQvNd+Webo/IxNRoMmw8pDqsLlMz40Hx2zGjRkvUtdeJ+AStvm+eYw==;EndpointSuffix=core.windows.net";
        string tableName = "Orders";

        public void TestTableStorage()
        {
            //AddEntity("06","Laptop",80);
            //QueryEntity("Laptop");
            DeleteEntity("Mobile", "05");

        }

        private void AddEntity(string orderId,string category,int quantity)
        {
            TableClient tableClient = new TableClient(connectionString, tableName);

            TableEntity keyValuePairs = new TableEntity(orderId, category)
            {
                {"quantity",quantity }
            };

            tableClient.AddEntity(keyValuePairs);
            Console.WriteLine($"Added Entity with order ID {orderId}");
        }

        private void QueryEntity(string category)
        {
            TableClient tableClient = new TableClient(connectionString, tableName);

            Pageable<TableEntity> result = tableClient.Query<TableEntity>(e=>e.RowKey==category);
            foreach(TableEntity tableEntity in result)
            {
                Console.WriteLine("Order Id = "+tableEntity.PartitionKey);
            }
        }

        private void DeleteEntity(string category,string orderId)
        {
            TableClient tableClient = new TableClient(connectionString, tableName);
            tableClient.DeleteEntity(category, orderId);
            Console.WriteLine("The Entity is Deleted");
        }



    }
}
