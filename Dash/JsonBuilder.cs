using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dash
{
  public class JsonBuilder
  {
    public JObject ChartConfig { get; set; }
    public JArray Data { get; set; }

    public JsonBuilder(string type)
    {
      Data = new JArray();

      switch (type)
      {
        case "pie":
          ChartConfig = JObject.Parse("{\"chart\":{\"caption\":\"Departments of employees\",\"bgcolor\":\"FFFFFF\",\"showvalues\":\"1\",\"showpercentvalues\":\"1\",\"showborder\":\"0\",\"showplotborder\":\"0\",\"showlegend\":\"1\",\"legendborder\":\"0\",\"legendposition\":\"bottom\",\"enablesmartlabels\":\"1\",\"use3dlighting\":\"0\",\"showshadow\":\"0\",\"legendbgcolor\":\"#CCCCCC\",\"legendbgalpha\":\"20\",\"legendborderalpha\":\"0\",\"legendshadow\":\"0\",\"legendnumcolumns\":\"3\",\"palettecolors\":\"#f8bd19,#e44a00,#008ee4,#33bdda,#6baa01,#583e78\"}}");
          break;
        case "pie3d":
          ChartConfig = JObject.Parse("{\"chart\":{\"caption\":\"Departments of employees\",\"subcaption\":\"\",\"startingangle\":\"120\",\"showlabels\":\"0\",\"showlegend\":\"1\",\"enablemultislicing\":\"0\",\"slicingdistance\":\"15\",\"showpercentvalues\":\"1\",\"showpercentintooltip\":\"0\",\"plottooltext\":\"Department : $label\",\"Total\":null,\"visit\":\"$datavalue\\\",\",\"theme\":\"fint\"} }");
          break;
        case "bar":
          break;
        default:
          break;
      }
    }

    public void AddData(string lbl, string val)
    {
      Data.Add(JObject.FromObject(new { label = lbl, value = val }));
    }

    public JObject GetJson()
    {
      ChartConfig.Add("data", Data);

      return ChartConfig;
    }
  }
}