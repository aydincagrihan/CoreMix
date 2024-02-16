using DelegateTestApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace DelegateTestApp.RequestCreators
{
    public class GetPostRequestCreator:BaseRequestCreator
    {
        public async Task<List<PostModel>> GetPosts()
        {
            var responseContent = await base.MakeRequest();
            return JsonConvert.DeserializeObject<List<PostModel>>(responseContent);
        }


        protected override string GetBaseAddress()
        {
            return "https://jsonplaceholder.typicode.com/";
        }
        protected override HttpMethod GetHttpMethod()
        {
            return HttpMethod.Get;
        }
        protected override string GetUrlPath()
        {
            return "posts";
        }
    }
}