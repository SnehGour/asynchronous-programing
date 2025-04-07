/*
*/

public static class Example02
{
    private static readonly HttpClient _httpClient;
    static Example02()
    {
        _httpClient = new HttpClient();
    }
    public static void example2()
    {

        Console.WriteLine("Example 2 Starts....");
        var responseTask = _httpClient.GetAsync("http://www.linkedinlearning.com");

        // wait for the response
        var response = responseTask.Result;
        Console.WriteLine(response.StatusCode);
        Console.WriteLine("Example 2 Ends....");
    }
}