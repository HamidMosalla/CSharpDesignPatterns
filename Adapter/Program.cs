using System;
using Adapter.Adapter;
using Adapter.Client;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var tradingdataImporter = new TradingDataImporter();

            Connector databaseConnector = new DatabaseConnector();
            tradingdataImporter.ImportData(databaseConnector);

            Connector xmlfileConnector = new XmlFileConnector();
            tradingdataImporter.ImportData(xmlfileConnector);

            Connector httpstreamConnector = new HttpStreamConnector();
            tradingdataImporter.ImportData(httpstreamConnector);

            Console.ReadKey();
        }
    }
}