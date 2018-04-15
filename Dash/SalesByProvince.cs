using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dash
{
  public class SalesByProvince
  {
    public Dictionary<string, int> SalesDict { get; set; }

    public SalesByProvince(ref JObject[] json)
    {
      string[] keys = { "AB", "BC", "MB", "NB", "NL", "NT", "NS", "NU", "ON", "PE", "QC", "SK", "YT" };

      SalesDict = new Dictionary<string, int>();
      
      foreach(JObject jObj in json)
      {
        foreach(string key in keys)
        {
          if (SalesDict.ContainsKey(key))
          {
            SalesDict[key] = SalesDict[key] + int.Parse(jObj[key].ToString());
          }
          else
          {
            SalesDict.Add(key, int.Parse(jObj[key].ToString()));
          }
        } 
      }
    }
  }
}