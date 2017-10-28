using System;
using System.Collections.Generic;
using System.Text;
using Adapter.Adapted;

namespace Adapter.Adapter
{
    public class HttpStreamConnector : Connector
    {
        public override void GetData()
        {
            var websiteScanner = new WebSiteScanner();
            websiteScanner.Scan();
        }
    }
}
