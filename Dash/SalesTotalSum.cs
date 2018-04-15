using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dash
{
  public class SalesTotalSum
  {
    static public int Sum(JObject json)
    {
      string[] keys = { "AB", "BC", "MB", "NB", "NL", "NT", "NS", "NU", "ON", "PE", "QC", "SK", "YT" };

      int sum = 0;
      foreach(string key in keys)
      {
        sum += int.Parse(json[key].ToString());
      }
      return sum;
    }
  }
}