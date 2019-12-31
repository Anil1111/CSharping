using System;
using System.Collections.Generic;
using System.Text;

namespace AsyncAwaitTaskAdvanced
{
    class ProgressReportModel
    {
        public int PercentageComplete { get; set; } = 0;
        public List<WebsiteDataModel> SitesDownloaded { get; set; } = new List<WebsiteDataModel>();
    }
}
