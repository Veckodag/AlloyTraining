﻿using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace AlloyTraining.Models.Pages
{
    [ContentType(DisplayName = "StandardPage", GUID = "00554373-5a6b-4551-a9a5-fac9cb366064", Description = "Alloy Standard Page")]
    public class StandardPage : SitePageData
    {
        
                [CultureSpecific]
                [Display(
                    Name = "Main body",
                    Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
                    GroupName = SystemTabNames.Content,
                    Order = 310)]
                public virtual XhtmlString MainBody { get; set; }
         
    }
}