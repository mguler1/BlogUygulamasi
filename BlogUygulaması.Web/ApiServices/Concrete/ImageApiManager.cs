using BlogUygulaması.Web.ApiServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace BlogUygulaması.Web.ApiServices.Concrete
{
    public class ImageApiManager:IImageApiService
    {
        private readonly HttpClient _httpCllient;
        public ImageApiManager(HttpClient httpClient)
        {
            _httpCllient = httpClient;
            _httpCllient.BaseAddress = new Uri("http://localhost:61994/api/images/");
        }
        public async Task<string> GetBlogImageByIdAsync(int id)
        {
         var responseMessage=  await  _httpCllient.GetAsync($"GetBlogImageById/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
              var bytes=await  responseMessage.Content.ReadAsByteArrayAsync();
                return $"data:image/jpeg;base64,{Convert.ToBase64String(bytes)}";
            }
            return null;
        }
    }
}
