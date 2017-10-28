using System;
using System.Collections.Generic;
using System.Text;
using Adapter.Adapted;

namespace Adapter.Adapter
{
    public class XmlFileConnector : Connector
    {
        public override void GetData()
        {
            var xmlfileLoader = new XmlFileLoader();
            xmlfileLoader.LoadXML();
        }
    }
}
