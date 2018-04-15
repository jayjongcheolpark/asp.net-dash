using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Dash
{
  public class DatasetHelper
  {
    static private bool ColumnEqual(object A, object B)
    {
      // Compares two values to see if they are equal. Also compares DBNULL.Value.           
      if (A == DBNull.Value && B == DBNull.Value) //  both are DBNull.Value
        return true;
      if (A == DBNull.Value || B == DBNull.Value) //  only one is BNull.Value
        return false;
      return (A.Equals(B));  // value type standard comparison
    }
    static public DataTable SelectDistinct(DataTable SourceTable, string FieldName)
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
  }
}