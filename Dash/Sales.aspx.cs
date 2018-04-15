using FusionCharts.Charts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Dash
{
  public partial class Sales : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      string username = (string)(Session["auth"]);
      if (string.IsNullOrEmpty(username))
      {
        Response.Redirect("Login.aspx");
      }

      WSHelper ws = new WSHelper();

      System.Diagnostics.Debug.WriteLine(ws.FetchSalesData());

      //DrawSalesDataWithMapChart();
    }

    public void DrawSalesDataWithMapChart()
    {
      JsonBuilder jb = new JsonBuilder("map");

      Chart mapChart = new Chart();

      // Setting chart id
      mapChart.SetChartParameter(Chart.ChartParameter.chartId, "salesMap");

      // Setting chart type to Column 3D chart
      mapChart.SetChartParameter(Chart.ChartParameter.chartType, "usa");

      // Setting chart width to 600px
      mapChart.SetChartParameter(Chart.ChartParameter.chartWidth, "600");

      // Setting chart height to 350px
      mapChart.SetChartParameter(Chart.ChartParameter.chartHeight, "450");

      // Setting chart data as JSON String (Uncomment below line  
      mapChart.SetData(jb.GetJson2().ToString(), Chart.DataFormat.json);
      _literSalesChart.Text = mapChart.Render();
    }
  }
}