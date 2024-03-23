using System.Net;
using System.Text.Json;
using NLog;
using RestSharp;
using RestSharp.Authenticators;
using RestSharpApi.Models;

namespace RestSharpApi.Tests;

public class TestRailSimpleTest
{
    private static readonly Logger Logger = LogManager.GetCurrentClassLogger();
    
    private const string BaseRestUri = "https://aqa2504.testrail.io/";
    
    [Test]
    public void SimpleGetTest()
    {
        const string endpoint = "index.php?/api/v2/get_user/1";

        var options = new RestClientOptions(BaseRestUri)
        {
            Authenticator = new HttpBasicAuthenticator("atrostyanko@gmail.com", "Qwertyu_1")
        };
            
        // Setup Rest Client
        var client = new RestClient(options);
        
        // Setup Request
        var request = new RestRequest(endpoint);
        
        // Execute Request
        var response = client.ExecuteGet(request);
        
        Logger.Info(response.Content);
        
        Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
    }
    
    [Test]
    public void AdvancedGetTest()
    {
        const string endpoint = "index.php?/api/v2/get_user/{user_id}";

        var options = new RestClientOptions(BaseRestUri)
        {
            Authenticator = new HttpBasicAuthenticator("atrostyanko@gmail.com", "Qwertyu_1")
        };
            
        // Setup Rest Client
        var client = new RestClient(options);
        
        // Setup Request
        var request = new RestRequest(endpoint)
            .AddUrlSegment("user_id", 1);
        
        // Execute Request
        var response = client.ExecuteGet(request);
        
        Logger.Info(response.Content);
        
        Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
    }

    [Test]
    public void SimplePostTest()
    {
        const string endpoint = "index.php?/api/v2/add_project";

        Dictionary<string, object> json = new Dictionary<string, object>();
        json.Add("name", "WP Project 2");
        json.Add("announcement", "Test project description");
        json.Add("show_announcement", true);
        json.Add("suite_mode", 3);
        
        var options = new RestClientOptions(BaseRestUri)
        {
            Authenticator = new HttpBasicAuthenticator("atrostyanko@gmail.com", "Qwertyu_1")
        };
            
        // Setup Rest Client
        var client = new RestClient(options);
        
        // Setup Request
        Logger.Info(JsonSerializer.Serialize(json));
        var request = new RestRequest(endpoint)
            .AddJsonBody(JsonSerializer.Serialize(json));
        /*
         * Content-Type
         * RestSharp will use the correct content type by default. Avoid adding the Content-Type header manually
         * to your requests unless you are absolutely sure it is required. You can add a custom content type to the body parameter itself.
         */

        // Execute Request
        var response = client.ExecutePost(request);
        
        Logger.Info(response.Content);
        
        Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        
        // Преобразуем тело ответа в объект JSON
        dynamic responseObject = Newtonsoft.Json.JsonConvert.DeserializeObject(response.Content);
        
        // Получаем значение поля "id"
        int id = responseObject!.id;
        
        // Используем значение "id" по своему усмотрению
        Logger.Info($"Значение поля 'id': {id}");
    }

    [Test]
    public void AdvancedPostTest()
    {
        const string endpoint = "index.php?/api/v2/add_project";

        Project expectedProject = new Project
        {
            Name = "WP Project 2",
            Announcement = "Test project description",
            IsShowAnnouncement = true,
            SuiteMode = 2
        };
        
        var options = new RestClientOptions(BaseRestUri)
        {
            Authenticator = new HttpBasicAuthenticator("atrostyanko@gmail.com", "Qwertyu_1")
        };
            
        // Setup Rest Client
        var client = new RestClient(options);
        
        // Setup Request
        var request = new RestRequest(endpoint).AddJsonBody(expectedProject);
        
        // Execute Request
        var response = client.ExecutePost<Project>(request);
        Project actualProject = response.Data;

        Logger.Info(actualProject);
        
        Assert.Multiple(() =>
        {
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
            
            Assert.That(actualProject.Name, Is.EqualTo(expectedProject.Name));
            
            Assert.That(actualProject.Equals(expectedProject));
        });
        
        // Получаем значение поля "id"
        int id = actualProject.Id;
        
        // Используем значение "id" по своему усмотрению
        Logger.Info($"Значение поля 'id': {id}");
    }
}