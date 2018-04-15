using Dash.EmployeeDataSetTableAdapters;
using FusionCharts.Charts;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Dash
{
  public partial class Salary : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      string username = (string)(Session["auth"]);
      if (string.IsNullOrEmpty(username))
      {
        Response.Redirect("Login.aspx");
      }

      DrawSalaryDistributionWithBarChart();
      DrawTotalSalaryByDepartmentWithBarChart();
    }

    public void DrawTotalSalaryByDepartmentWithBarChart()
    {
      JsonBuilder jb = new JsonBuilder("barRed");

      EmployeeDataSet empdataset = new EmployeeDataSet();
      EmployeeTableAdapter empTableAdapter = new EmployeeTableAdapter();
      empTableAdapter.Fill(empdataset.Employee);

      DataTable distinctDepart = DatasetHelper.SelectDistinct(empdataset.Employee, "Department");
      var map = new Dictionary<string, int>();

      foreach (DataRow dr in distinctDepart.Rows)
      {
        System.Diagnostics.Debug.WriteLine(dr["Department"].ToString());
        map.Add(dr["Department"].ToString(), 0);
      }


      foreach (DataRow dr in empdataset.Employee.Rows)
      {
        int salaryInt = int.Parse(dr["Salary"].ToString());
        string dptmt = dr["Department"].ToString();
        map[dptmt] = map[dptmt] + salaryInt;
      }

      var ordered = map.OrderByDescending(x => x.Value);

      foreach (var pair in ordered)
      {

        jb.AddData(pair.Key, pair.Value.ToString());
      }

      Chart barChart = new Chart();

      // Setting chart id
      barChart.SetChartParameter(Chart.ChartParameter.chartId, "totalSalaryBar");

      // Setting chart type to Column 3D chart
      barChart.SetChartParameter(Chart.ChartParameter.chartType, "bar2D");

      // Setting chart width to 600px
      barChart.SetChartParameter(Chart.ChartParameter.chartWidth, "600");

      // Setting chart height to 350px
      barChart.SetChartParameter(Chart.ChartParameter.chartHeight, "450");

      // Setting chart data as JSON String (Uncomment below line  
      barChart.SetData(jb.GetJson().ToString(), Chart.DataFormat.json);
      _literSalaryChart2.Text = barChart.Render();
      
    }
    public void DrawSalaryDistributionWithBarChart()
    {
      JsonBuilder jb = new JsonBuilder("bar");

      EmployeeDataSet empdataset = new EmployeeDataSet();
      EmployeeTableAdapter empTableAdapter = new EmployeeTableAdapter();
      empTableAdapter.Fill(empdataset.Employee);

      var map = new Dictionary<string, int>();
      foreach (DataRow dr in empdataset.Employee.Rows)
      {
        int salaryInt = int.Parse(dr["Salary"].ToString());
        salaryInt /= 10000;
        string salaryRange = salaryInt.ToString();
        if (map.ContainsKey(salaryRange))
        {
          map[salaryRange] = map[salaryRange] + 1;
        }
        else
        {
          map.Add(salaryRange, 1);
        }
      }

      var ordered = map.OrderByDescending(x => int.Parse(x.Key));

      foreach (var pair in ordered)
      {

        jb.AddData((int.Parse(pair.Key) * 10000).ToString(), pair.Value.ToString());
      }

      Chart barChart = new Chart();

      // Setting chart id
      barChart.SetChartParameter(Chart.ChartParameter.chartId, "myChart2");

      // Setting chart type to Column 3D chart
      barChart.SetChartParameter(Chart.ChartParameter.chartType, "bar2D");

      // Setting chart width to 600px
      barChart.SetChartParameter(Chart.ChartParameter.chartWidth, "600");

      // Setting chart height to 350px
      barChart.SetChartParameter(Chart.ChartParameter.chartHeight, "450");

      // Setting chart data as JSON String (Uncomment below line  
      barChart.SetData(jb.GetJson().ToString(), Chart.DataFormat.json);
      _literSalaryChart.Text = barChart.Render();
    }
  }
}