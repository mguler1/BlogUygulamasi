using BlogUygulaması.Web.ApiServices.Interfaces;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogUygulaması.Web.TagHelpers
{
    [HtmlTargetElement("getblogimage")]
    public class ImageTagHelper:TagHelper
    {
        private readonly IImageApiService _imageApiService;
        public ImageTagHelper(IImageApiService imageApiService)
        {
            _imageApiService = imageApiService;
        }
        public int Id { get; set; }
        public override async  Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
          var blog=await _imageApiService.GetBlogImageByIdAsync(Id);
            var html = $"<img src='{blog}'class='card - img - top'/>";
            output.Content.SetHtmlContent(html);
        }
    }
}
