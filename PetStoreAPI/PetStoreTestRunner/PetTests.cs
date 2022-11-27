using NUnit.Framework;
using NUnit.Framework.Internal;
using PetStoreAPI.Resources;
using RestSharp;
using System.Net;

namespace PetStoreAPI.TestRunner
{
    public class PetTests
    {
        string baseUrl = "https://petstore.swagger.io/v2/pet/";
        PetRequests body = new PetRequests { Id = 5, Name = "test", Status = "available" };
        int id;
        HttpStatusCode statusCode;
        int numericStatusCode;

        [SetUp]
        public void testStarted()
        {
            Console.WriteLine("Test started");
            id = body.Id;
        }


        [Test, Order(1)]
        public void addPet()
        {

            RestClient client = new RestClient(baseUrl);
            RestRequest request = new RestRequest();
            request.AddJsonBody(body);
            var response = client.Post(request);
            Assert.IsTrue(response.IsSuccessStatusCode);
            statusCode = response.StatusCode;
            numericStatusCode = (int)statusCode;
            Assert.AreEqual(numericStatusCode, 200);

        }

        [Test, Order(2)]

        public void updatePet()
        {
            RestClient client = new RestClient(baseUrl);
            RestRequest request = new RestRequest();
            body.Name = "Blue Bird";
            request.AddJsonBody(body);
            var response = client.Put(request);
            Assert.IsTrue(response.IsSuccessStatusCode);
            statusCode = response.StatusCode;
            numericStatusCode = (int)statusCode;
            Assert.AreEqual(numericStatusCode, 200);


        }
        [Test, Order(3)]
        public void findPetByStatus()
        {
            RestClient client = new RestClient(baseUrl);
            RestRequest request = new RestRequest("findByStatus?status=available");
            var response = client.Get(request);
            Assert.IsTrue(response.IsSuccessStatusCode);
            statusCode = response.StatusCode;
            numericStatusCode = (int)statusCode;
            Assert.AreEqual(numericStatusCode, 200);

        }

        [Test, Order(4)]
        public void findPetById()
        {
  
            RestClient client = new RestClient(baseUrl);
            RestRequest request = new RestRequest(id.ToString(), Method.Get);
            var response = client.Get(request);
            Assert.IsTrue(response.IsSuccessStatusCode);
            statusCode = response.StatusCode;
            numericStatusCode = (int)statusCode;
            Assert.AreEqual(numericStatusCode, 200);

        }
        [Test, Order(5)]
        public void deletePet()
        {
            RestClient client = new RestClient(baseUrl);
            RestRequest request = new RestRequest(id.ToString(), Method.Delete);
            var response = client.Delete(request);
            Assert.IsTrue(response.IsSuccessStatusCode);
            statusCode = response.StatusCode;
            numericStatusCode = (int)statusCode;
            Assert.AreEqual(numericStatusCode, 200);
        }
        [TearDown]
        public void endTest()
        {
            Console.WriteLine("Test completed. Please check your test results.");

        }
    }
}
