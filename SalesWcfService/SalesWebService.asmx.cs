using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.Script.Services;
using System.Web.Services;

namespace SalesWcfService
{
  /// <summary>
  /// Summary description for SalesWebService
  /// </summary>
  [WebService(Namespace = "http://tempuri.org/")]
  [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
  [System.ComponentModel.ToolboxItem(false)]
  // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
  // [System.Web.Script.Services.ScriptService]
  public class SalesWebService : System.Web.Services.WebService
  {

    [WebMethod]
    public string getSalesData()
    {

      Random rnd = new Random();
      var json = new JObject();
      json.Add("AB", rnd.Next(50000, 80000));
      json.Add("BC", rnd.Next(80000, 150000));
      json.Add("MB", rnd.Next(80000, 150000));
      json.Add("NB", rnd.Next(10000, 50000));
      json.Add("NL", rnd.Next(10000, 50000));
      json.Add("NT", rnd.Next(10000, 50000));
      json.Add("NS", rnd.Next(10000, 50000));
      json.Add("NU", rnd.Next(10000, 50000));
      json.Add("ON", rnd.Next(80000, 150000));
      json.Add("PE", rnd.Next(10000, 50000));
      json.Add("QC", rnd.Next(50000, 100000));
      json.Add("SK", rnd.Next(10000, 50000));
      json.Add("YT", rnd.Next(10000, 50000));

      return json.ToString();

    }
  }
}
