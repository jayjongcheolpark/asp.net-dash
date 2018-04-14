using Dash.EmployeeDataSetTableAdapters;
using FusionCharts.Charts;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
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
      string username = (string)(Session["auth"]);
      if (string.IsNullOrEmpty(username))
      {
        Response.Redirect("Login.aspx");
      }

      DrawDepartmentWithPieChart();
    }
    private bool ColumnEqual(object A, object B)
    {
      // Compares two values to see if they are equal. Also compares DBNULL.Value.           
      if (A == DBNull.Value && B == DBNull.Value) //  both are DBNull.Value
        return true;
      if (A == DBNull.Value || B == DBNull.Value) //  only one is BNull.Value
        return false;
      return (A.Equals(B));  // value type standard comparison
    }
    public DataTable SelectDistinct(DataTable SourceTable, string FieldName)
    {
      // Create a Datatable â€“ datatype same as FieldName
      DataTable dt = new DataTable(SourceTable.TableName);
      dt.Columns.Add(FieldName, SourceTable.Columns[FieldName].DataType);
      // Loop each row & compare each value with one another
      // Add it to datatable if the values are mismatch
      object LastValue = null;
      foreach (DataRow dr in SourceTable.Select("", FieldName))
      {
        if (LastValue == null || !(ColumnEqual(LastValue, dr[FieldName])))
        {
          LastValue = dr[FieldName];
          dt.Rows.Add(new object[] { LastValue });
        }
      }
      return dt;
    }

    public void DrawDepartmentWithPieChart()
    {
      JsonBuilder jb = new JsonBuilder("pie");

      EmployeeDataSet empdataset = new EmployeeDataSet();
      EmployeeTableAdapter empTableAdapter = new EmployeeTableAdapter();
      empTableAdapter.Fill(empdataset.Employee);

      DataTable distinctDepart = SelectDistinct(empdataset.Employee, "Department");
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
      pieChart.SetChartParameter(Chart.ChartParameter.chartId, "myChart");

      // Setting chart type to Column 3D chart
      pieChart.SetChartParameter(Chart.ChartParameter.chartType, "pie2D");

      // Setting chart width to 600px
      pieChart.SetChartParameter(Chart.ChartParameter.chartWidth, "600");

      // Setting chart height to 350px
      pieChart.SetChartParameter(Chart.ChartParameter.chartHeight, "450");

      // Setting chart data as JSON String (Uncomment below line  
      pieChart.SetData(jb.GetJson().ToString(), Chart.DataFormat.json);
      _literChart.Text = pieChart.Render();

    }
  }
}