using Microsoft.AspNet.Mvc.Rendering;
using System.Collections.Generic;

namespace QwiMis.ViewModels.Manage
{
    public class ConfigureTwoFactorViewModel
    {
        public string SelectedProvider { get; set; }

        public ICollection<SelectListItem> Providers { get; set; }
    }
}