﻿using Bloggie.Web.Models.Domain;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Bloggie.Web.Models.ViewModels
{
    public class AddBlogPostRequest
    {
        public string Heading { get; set; }

        public string PageTittle { get; set; }

        public string Content { get; set; }

        public string ShortDescription { get; set; }

        public string FeaturedImageUrl { get; set; }

        public string UrlHandle { get; set; }

        public DateTime PublishedDate { get; set; }

        public string Author { get; set; }

        public bool Visible { get; set; }

        public IEnumerable<SelectListItem> Tags { get; set; }

        public string SelectedTag { get; set; }
    }
}
