using System;
using System.Web;
using Umbraco.Core.Models.PublishedContent;

namespace CarApi.Models
{
    public class CarBrandViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public DateTime FoundationDate { get; set; }
        public string OriginCountry { get; set; }
        public string Description { get; set; }
    }
}