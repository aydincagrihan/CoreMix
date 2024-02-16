using DelegateTestApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DelegateTestApp.RequestCreators
{
    public abstract class BaseRequestCreator
    {
        protected async Task<string> MakeRequest()
        {
            HttpClient client = new HttpClient();
            var msg = new HttpRequestMessage
            {
                Method = GetHttpMethod(),
                RequestUri = new Uri(GetBaseAddress() + GetUrlPath())
            };
            var bodyContent = GetBodyObject();
            if (bodyContent != null)
                msg.Content = new StringContent(JsonConvert.SerializeObject(bodyContent));
            var httpRes = await client.SendAsync(msg);

            httpRes.EnsureSuccessStatusCode();
            var resultContent = httpRes.Content.ReadAsStringAsync().GetAwaiter().GetResult();
            return resultContent;
            //var posts = JsonConvert.DeserializeObject<List<PostModel>>(resultContent);
        }

        //virtual yapmak başka yerlerde kullanırken override etmemizi sağlar
        protected virtual string GetBaseAddress()
        {
            return "";
        }

        protected virtual string GetUrlPath()
        {
            return "";
        }

        protected virtual HttpMethod GetHttpMethod()
        {
            return HttpMethod.Get;
        }

        protected virtual object GetBodyObject()
        {
            return default;
        }
    }
}