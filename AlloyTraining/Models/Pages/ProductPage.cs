using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using EPiServer.Web;

namespace AlloyTraining.Models.Pages
{
    [ContentType(DisplayName = "ProductPage", GUID = "2e1da572-6ca9-4f5a-aa50-3b8f27f23f37", Description = "This is a product page!")]
    public class ProductPage : StandardPage
    {
        [Display(GroupName = SystemTabNames.Content, Order = 305)]
        [UIHint(UIHint.Textarea)]
        public virtual string UniqueSellingPoints { get; set; }
    }
}