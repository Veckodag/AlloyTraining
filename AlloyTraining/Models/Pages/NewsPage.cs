using System;
using System.ComponentModel.DataAnnotations;
using AlloyTraining.Models.Blocks;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace AlloyTraining.Models.Pages
{
    [ContentType(DisplayName = "NewsPage", GUID = "a3a373bf-9e59-471f-9b80-04af7e9b98cc", Description = "")]
    public class NewsPage : StandardPage
    {
        
                [Display(
                    Name = "Name",
                    Description = "A listing of news pages",
                    GroupName = SystemTabNames.Content,
                    Order = 315)]
                public virtual ListingBlock MainListing { get; set; }
         
    }
}