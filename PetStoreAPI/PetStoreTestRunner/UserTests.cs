using NUnit.Framework;
using NUnit.Framework.Internal;
using PetStoreAPI.Resources;
using RestSharp;
using System.Net;


namespace PetStoreAPI.PetStoreTestRunner
{
    internal class UserTests
    {


        string baseUrl = "https://petstore.swagger.io/v2/user/";
        UserRequests body = new UserRequests { id = 8795, username = "johnsmith", firstName = "John", lastName = "Smith", email = "john.smith@hotmail.com", password = "1234", phone = "8965446", userStatus = 3 };
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
        public void addUser()
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
        public void findUserByName()
        {
            RestClient client = new RestClient(baseUrl);
            RestRequest request = new RestRequest(body.username);
            var response = client.Get(request);
            Assert.IsTrue(response.IsSuccessStatusCode);
            Console.WriteLine(response.Content);
            statusCode = response.StatusCode;
            numericStatusCode = (int)statusCode;
            Assert.AreEqual(numericStatusCode, 200);

        }
        [Test, Order(3)]
        public void updateUser()
        {
            body.username = "john.smith";
            RestClient client = new RestClient(baseUrl);
            RestRequest request = new RestRequest(body.username);
            request.AddJsonBody(body);
            var response = client.Put(request);
            Assert.IsTrue(response.IsSuccessStatusCode);
            statusCode = response.StatusCode;
            numericStatusCode = (int)statusCode;
            Assert.AreEqual(numericStatusCode, 200);

        }

        [Test, Order(4)]
        public void deleteUser()
        {

            RestClient client = new RestClient(baseUrl);
            RestRequest request = new RestRequest(body.username);
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
