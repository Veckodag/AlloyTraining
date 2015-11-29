using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace AlloyTraining.Models.Blocks
{
    [ContentType(DisplayName = "EditorialBlock", GUID = "c6fc3f96-db6f-4cad-bf09-0ee2d1ddf719", Description = "")]
    public class EditorialBlock : BlockData
    {
        [Display(GroupName = SystemTabNames.Content, Order = 1)]
        public virtual XhtmlString MainBody { get; set; }
    }
}