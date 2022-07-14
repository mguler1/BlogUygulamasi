using BlogUygulaması.Web.ApiServices.Interfaces;
using BlogUygulaması.Web.Enums;
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
        public BlogImageType BlogImageType { get; set; } = BlogImageType.BlogHome;
        public override async  Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
          var blog=await _imageApiService.GetBlogImageByIdAsync(Id);
            string html=string.Empty;
            if (BlogImageType== BlogImageType.BlogHome)
            {
                html = $"<img src='{blog}'class='card - img - top'/>";
            }
            else
            {
                html = $"<img src='{blog}'class='card - img -fluid rounded'/>";
            }
            output.Content.SetHtmlContent(html);
        }
    }
}
