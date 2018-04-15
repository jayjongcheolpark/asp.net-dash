using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dash
{
  public class WSHelper
  {
    SrvRefSales.WSForSalesSoapClient client;

    public WSHelper()
    {
      client = new SrvRefSales.WSForSalesSoapClient("WSForSalesSoap");
    }

    public string FetchSalesData()
    {
      return client.GetSalesData();
    }
  }
}