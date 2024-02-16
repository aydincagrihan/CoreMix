using DelegateTestApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace DelegateTestApp.RequestCreators
{
    public class GetPostRequestCreator
    {
        public List<PostModel> MakeRequest()
        {
            //BaseUrl
            //Path
            //HttpMethod post ?geT?

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://jsonplaceholder.typicode.com");
            var httpRes = client.GetAsync("posts").GetAwaiter().GetResult();
            httpRes.EnsureSuccessStatusCode();
            var resultContent = httpRes.Content.ReadAsStringAsync().GetAwaiter().GetResult();
            var posts = JsonConvert.DeserializeObject<List<PostModel>>(resultContent);
            return posts;
        }
    }
}