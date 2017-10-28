using System;
using System.Collections.Generic;
using System.Text;
using Adapter.Adapter;

namespace Adapter.Client
{
    class TradingDataImporter
    {
        public void ImportData(Connector connector)
        {
            connector.GetData();
        }
    }
}
