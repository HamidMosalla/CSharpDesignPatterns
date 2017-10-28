using System;
using System.Collections.Generic;
using System.Text;
using Adapter.Adapted;

namespace Adapter.Adapter
{
    public class DatabaseConnector : Connector
    {
        public override void GetData()
        {
            var databaseHelper = new DatabaseHelper();
            databaseHelper.QueryForChanges();
        }
    }
}
