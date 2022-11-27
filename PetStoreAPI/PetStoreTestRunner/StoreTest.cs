using NUnit.Framework;
using NUnit.Framework.Internal;
using PetStoreAPI.Resources;
using RestSharp;
using System.Net;


namespace PetStoreAPI.PetStoreTestRunner
{
    public class StoreTests
    {
        string baseUrl = "https://petstore.swagger.io/v2/store/";
        StoreRequests body = new StoreRequests { id = 897, petId = 5, quantity = 85, status = "placed", complete = true };
        int id;
        HttpStatusCode statusCode;
        int numericStatusCode;

        [SetUp]
        public void testStarted()
        {
            Console.WriteLine("Test started");
            id = body.id;
        }

        [Test, Order(1)]
        public void addStore()
        {

            RestClient client = new RestClient(baseUrl);
            RestRequest request = new RestRequest("order");
            request.AddJsonBody(body);
            var response = client.Post(request);
            Assert.IsTrue(response.IsSuccessStatusCode);
        }

        [Test, Order(2)]
        public void findStoreById()
        {
            RestClient client = new RestClient(baseUrl);
            RestRequest request = new RestRequest("order/" + id.ToString());
            var response = client.Get(request);
            Assert.IsTrue(response.IsSuccessStatusCode);
        }

        [Test, Order(3)]
        public void deleteStore()
        {

            RestClient client = new RestClient(baseUrl);
            RestRequest request = new RestRequest("order/" + id.ToString());
            var response = client.Delete(request);
            Assert.IsTrue(response.IsSuccessStatusCode);
        }

        [Test, Order(4)]
        public void findInventory()
        {

            RestClient client = new RestClient(baseUrl);
            RestRequest request = new RestRequest("inventory");
            var response = client.Get(request);
            Assert.IsTrue(response.IsSuccessStatusCode);
        }

        [TearDown]
        public void endTest()
        {
            Console.WriteLine("Test completed. Please check your test results.");

        }
    }
}