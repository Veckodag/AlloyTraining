using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace AlloyTraining.Models.Blocks
{
    [ContentType(DisplayName = "ListingBlock", GUID = "1cf2a685-ad2b-42a3-b122-6649065635cb", Description = "")]
    public class ListingBlock : BlockData
    {
        [Display(GroupName = SystemTabNames.Content, Order = 100)]
        public virtual string Heading { get; set; }
        [Display(GroupName = SystemTabNames.Content, Order = 200)]
        public virtual PageReference RootPage { get; set; }
    }
}