﻿using Dash.EmployeeDataSetTableAdapters;
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
  public partial class Department : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      string username = (string)(Session["auth"]);
      if (string.IsNullOrEmpty(username))
      {
        Response.Redirect("Login.aspx");
      }

      DrawDepartmentWithPieChart();
      DrawNumOfEmployeeByDepartmentWithBarChart();
    }

    public void DrawNumOfEmployeeByDepartmentWithBarChart()
    {
      JsonBuilder jb = new JsonBuilder("barYellow");

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
        string dptmnt = dr["Department"].ToString();
        map[dptmnt] = map[dptmnt] + 1;
      }

      foreach (var pair in map)
      {
        jb.AddData(pair.Key, pair.Value.ToString());
      }

      Chart barChart = new Chart();

      // Setting chart id
      barChart.SetChartParameter(Chart.ChartParameter.chartId, "dptmtBar");

      // Setting chart type to Column 3D chart
      barChart.SetChartParameter(Chart.ChartParameter.chartType, "bar2D");

      // Setting chart width to 600px
      barChart.SetChartParameter(Chart.ChartParameter.chartWidth, "600");

      // Setting chart height to 350px
      barChart.SetChartParameter(Chart.ChartParameter.chartHeight, "450");

      // Setting chart data as JSON String (Uncomment below line  
      barChart.SetData(jb.GetJson().ToString(), Chart.DataFormat.json);
      _literDepartmentChart2.Text = barChart.Render();
      
    }

    public void DrawDepartmentWithPieChart()
    {
      JsonBuilder jb = new JsonBuilder("pie");

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
        string dptmnt = dr["Department"].ToString();
        map[dptmnt] = map[dptmnt] + 1;
      }

      foreach (var pair in map)
      {
        jb.AddData(pair.Key, pair.Value.ToString());
      }

      Chart pieChart = new Chart();

      // Setting chart id
      pieChart.SetChartParameter(Chart.ChartParameter.chartId, "dptmtPie");

      // Setting chart type to Column 3D chart
      pieChart.SetChartParameter(Chart.ChartParameter.chartType, "pie2D");

      // Setting chart width to 600px
      pieChart.SetChartParameter(Chart.ChartParameter.chartWidth, "600");

      // Setting chart height to 350px
      pieChart.SetChartParameter(Chart.ChartParameter.chartHeight, "450");

      // Setting chart data as JSON String (Uncomment below line  
      pieChart.SetData(jb.GetJson().ToString(), Chart.DataFormat.json);
      _literDepartmentChart.Text = pieChart.Render();
    }
  }
}