using DelegateTestApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateTestApp.RequestCreators
{
    public class CreatePostRequestCreator : BaseRequestCreator
    {
        public async Task<PostModel> CreatePost(PostModel post)
        {
            var responseContent = await base.MakeRequest();
            return JsonConvert.DeserializeObject<PostModel>(responseContent);
        }

    }
}
