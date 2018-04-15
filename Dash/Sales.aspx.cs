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

  public partial class Sales : System.Web.UI.Page
  {
    public List<int> SumArray = new List<int>();

    protected void Page_Load(object sender, EventArgs e)
    {
      string username = (string)(Session["auth"]);
      if (string.IsNullOrEmpty(username))
      {
        Response.Redirect("Login.aspx");
      }

      SumArray.Clear();

      JObject[] jsonArray = new JObject[5];

      for (int i = 0; i < 5; i++)
      {
        WSHelper ws = new WSHelper();

        jsonArray[i] = JObject.Parse(ws.FetchSalesData());

        SumArray.Add(SalesTotalSum.Sum(jsonArray[i]));
      }

      SalesByProvince sbp = new SalesByProvince(ref jsonArray);

      DrawSalesTotalSumWithLineChart();
      DrawSalesByProvinceWithBarChart(sbp);
    }

    public void DrawSalesByProvinceWithBarChart(SalesByProvince sbp)
    {
      JsonBuilder jb = new JsonBuilder("barGreen");

      string[] keys = { "AB", "BC", "MB", "NB", "NL", "NT", "NS", "NU", "ON", "PE", "QC", "SK", "YT" };

      foreach(string key in keys)
      {
        jb.AddData(key, sbp.SalesDict[key].ToString());
      }

      Chart barChart = new Chart();

      // Setting chart id
      barChart.SetChartParameter(Chart.ChartParameter.chartId, "salesBar");

      // Setting chart type to Column 3D chart
      barChart.SetChartParameter(Chart.ChartParameter.chartType, "bar2D");

      // Setting chart width to 600px
      barChart.SetChartParameter(Chart.ChartParameter.chartWidth, "600");

      // Setting chart height to 350px
      barChart.SetChartParameter(Chart.ChartParameter.chartHeight, "450");

      // Setting chart data as JSON String (Uncomment below line  
      barChart.SetData(jb.GetJson().ToString(), Chart.DataFormat.json);
      _literSalesChart2.Text = barChart.Render();

    }

    public void DrawSalesTotalSumWithLineChart()
    {
      JsonBuilder jb = new JsonBuilder("line");
      string[] month = { "Jan", "Feb", "Mar", "Apr", "May" };
      int count = 0;

      foreach(string key in month)
      {
        jb.AddData(key, SumArray[count].ToString());
        count++;
      }

      Chart lineChart = new Chart();

      // Setting chart id
      lineChart.SetChartParameter(Chart.ChartParameter.chartId, "salesLine");

      // Setting chart type to Column 3D chart
      lineChart.SetChartParameter(Chart.ChartParameter.chartType, "line");

      // Setting chart width to 600px
      lineChart.SetChartParameter(Chart.ChartParameter.chartWidth, "600");

      // Setting chart height to 350px
      lineChart.SetChartParameter(Chart.ChartParameter.chartHeight, "450");

      // Setting chart data as JSON String (Uncomment below line  
      lineChart.SetData(jb.GetJson().ToString(), Chart.DataFormat.json);
      _literSalesChart.Text = lineChart.Render();
    }
  }
}