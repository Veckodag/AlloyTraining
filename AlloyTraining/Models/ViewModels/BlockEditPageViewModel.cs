using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AlloyTraining.Models.Pages;
using EPiServer.Core;

namespace AlloyTraining.Models.ViewModels
{
    public class BlockEditPageViewModel : IPageViewModel<SitePageData>
    {
        public SitePageData CurrentPage { get; set; }
        public PreviewBlock PreviewBlock { get; set; }

        public BlockEditPageViewModel(PageData page, IContent content)
        {
            PreviewBlock = new PreviewBlock(page, content);
            CurrentPage = (SitePageData) page;
        }
    }
}