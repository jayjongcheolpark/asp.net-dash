using FusionCharts.Charts;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Dash
{
  public partial class Statics : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      var json = JObject.Parse("{\"chart\":{\"caption\":\"Departments of employees\",\"subcaption\":\"\",\"startingangle\":\"120\",\"showlabels\":\"0\",\"showlegend\":\"1\",\"enablemultislicing\":\"0\",\"slicingdistance\":\"15\",\"showpercentvalues\":\"1\",\"showpercentintooltip\":\"0\",\"plottooltext\":\"Department : $label\",\"Total\":null,\"visit\":\"$datavalue\\\",\",\"theme\":\"fint\"} }");

      var json1 = JObject.FromObject(new { label = "Development", value = "3" });
      var json2 = JObject.FromObject(new { label = "Design", value = "2" });
      var json3 = JObject.FromObject(new { label = "Devops", value = "1" });

      var jarray = new JArray();
      jarray.Add(json1);
      jarray.Add(json2);
      jarray.Add(json3);

      json.Add("data", jarray);

      Chart chart = new Chart("pie3D", "simplechart", "600", "400", "jsonurl", "data.json");
      Chart pieChart = new Chart();

      // Setting chart id
      pieChart.SetChartParameter(Chart.ChartParameter.chartId, "myChart");

      // Setting chart type to Column 3D chart
      pieChart.SetChartParameter(Chart.ChartParameter.chartType, "pie3D");

      // Setting chart width to 600px
      pieChart.SetChartParameter(Chart.ChartParameter.chartWidth, "600");

      // Setting chart height to 350px
      pieChart.SetChartParameter(Chart.ChartParameter.chartHeight, "450");

      // Setting chart data as JSON String (Uncomment below line  
      pieChart.SetData(json.ToString(), Chart.DataFormat.json);
      _literChart.Text = pieChart.Render();

    }
  }
}