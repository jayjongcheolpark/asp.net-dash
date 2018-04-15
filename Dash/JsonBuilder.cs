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
          ChartConfig = JObject.Parse("{\"chart\":{\"caption\":\"Salary Distribution\",\"subCaption\":\"This year\",\"yAxisName\":\"Number of People\",\"numberPrefix\":\"\",\"paletteColors\":\"#16d3c0\",\"bgColor\":\"#ffffff\",\"showBorder\":\"0\",\"showCanvasBorder\":\"0\",\"usePlotGradientColor\":\"0\",\"plotBorderAlpha\":\"10\",\"placeValuesInside\":\"1\",\"valueFontColor\":\"#ffffff\",\"showAxisLines\":\"1\",\"axisLineAlpha\":\"25\",\"divLineAlpha\":\"10\",\"alignCaptionWithCanvas\":\"0\",\"showAlternateVGridColor\":\"0\",\"captionFontSize\":\"14\",\"subcaptionFontSize\":\"14\",\"subcaptionFontBold\":\"0\",\"toolTipColor\":\"#ffffff\",\"toolTipBorderThickness\":\"0\",\"toolTipBgColor\":\"#000000\",\"toolTipBgAlpha\":\"80\",\"toolTipBorderRadius\":\"2\",\"toolTipPadding\":\"5\"}}");
          break;
        case "barRed":
          ChartConfig = JObject.Parse("{\"chart\":{\"caption\":\"Total salary by department\",\"subCaption\":\"This year\",\"yAxisName\":\"Total amount\",\"numberPrefix\":\"$\",\"paletteColors\":\"#FF6384\",\"bgColor\":\"#ffffff\",\"showBorder\":\"0\",\"showCanvasBorder\":\"0\",\"usePlotGradientColor\":\"0\",\"plotBorderAlpha\":\"10\",\"placeValuesInside\":\"1\",\"valueFontColor\":\"#ffffff\",\"showAxisLines\":\"1\",\"axisLineAlpha\":\"25\",\"divLineAlpha\":\"10\",\"alignCaptionWithCanvas\":\"0\",\"showAlternateVGridColor\":\"0\",\"captionFontSize\":\"14\",\"subcaptionFontSize\":\"14\",\"subcaptionFontBold\":\"0\",\"toolTipColor\":\"#ffffff\",\"toolTipBorderThickness\":\"0\",\"toolTipBgColor\":\"#000000\",\"toolTipBgAlpha\":\"80\",\"toolTipBorderRadius\":\"2\",\"toolTipPadding\":\"5\"}}");
          break;
        case "barYellow":
          ChartConfig = JObject.Parse("{\"chart\":{\"caption\":\"Number of employees by department\",\"subCaption\":\"This year\",\"yAxisName\":\"Number of People\",\"numberPrefix\":\"\",\"paletteColors\":\"#FFBC00\",\"bgColor\":\"#ffffff\",\"showBorder\":\"0\",\"showCanvasBorder\":\"0\",\"usePlotGradientColor\":\"0\",\"plotBorderAlpha\":\"10\",\"placeValuesInside\":\"1\",\"valueFontColor\":\"#ffffff\",\"showAxisLines\":\"1\",\"axisLineAlpha\":\"25\",\"divLineAlpha\":\"10\",\"alignCaptionWithCanvas\":\"0\",\"showAlternateVGridColor\":\"0\",\"captionFontSize\":\"14\",\"subcaptionFontSize\":\"14\",\"subcaptionFontBold\":\"0\",\"toolTipColor\":\"#ffffff\",\"toolTipBorderThickness\":\"0\",\"toolTipBgColor\":\"#000000\",\"toolTipBgAlpha\":\"80\",\"toolTipBorderRadius\":\"2\",\"toolTipPadding\":\"5\"}}");
          break;
        case "barGreen":
          ChartConfig = JObject.Parse("{\"chart\":{\"caption\":\"Sales By Province\",\"subCaption\":\"This year\",\"yAxisName\":\"Sales Revenue\",\"numberPrefix\":\"$\",\"paletteColors\":\"#FFBC00\",\"bgColor\":\"#ffffff\",\"showBorder\":\"0\",\"showCanvasBorder\":\"0\",\"usePlotGradientColor\":\"0\",\"plotBorderAlpha\":\"10\",\"placeValuesInside\":\"1\",\"valueFontColor\":\"#ffffff\",\"showAxisLines\":\"1\",\"axisLineAlpha\":\"25\",\"divLineAlpha\":\"10\",\"alignCaptionWithCanvas\":\"0\",\"showAlternateVGridColor\":\"0\",\"captionFontSize\":\"14\",\"subcaptionFontSize\":\"14\",\"subcaptionFontBold\":\"0\",\"toolTipColor\":\"#ffffff\",\"toolTipBorderThickness\":\"0\",\"toolTipBgColor\":\"#000000\",\"toolTipBgAlpha\":\"80\",\"toolTipBorderRadius\":\"2\",\"toolTipPadding\":\"5\"}}");
          break;
        case "line":
          //ChartConfig = JObject.Parse("{\"chart\":{\"caption\":\"Sales Report\",\"numberprefix\":\"$\",\"bgcolor\":\"FFFFFF\",\"showalternatehgridcolor\":\"0\",\"plotbordercolor\":\"008ee4\",\"plotborderthickness\":\"3\",\"showvalues\":\"0\",\"divlinecolor\":\"CCCCCC\",\"showcanvasborder\":\"0\",\"tooltipbgcolor\":\"00396d\",\"tooltipcolor\":\"FFFFFF\",\"tooltipbordercolor\":\"00396d\",\"numdivlines\":\"2\",\"yaxisvaluespadding\":\"20\",\"anchorbgcolor\":\"008ee4\",\"anchorborderthickness\":\"0\",\"showshadow\":\"0\",\"anchorradius\":\"4\",\"chartrightmargin\":\"25\",\"canvasborderalpha\":\"0\",\"showborder\":\"0\"},\"data\":[{\"label\":\"2009\",\"value\":\"4400000\",\"color\":\"008ee4\",\"stepSkipped\":false,\"appliedSmartLabel\":true},{\"label\":\"2010\",\"value\":\"4800000\",\"color\":\"008ee4\",\"stepSkipped\":false,\"appliedSmartLabel\":true},{\"label\":\"2011\",\"value\":\"5500000\",\"color\":\"008ee4\",\"stepSkipped\":false,\"appliedSmartLabel\":true},{\"label\":\"2012\",\"value\":\"6700000\",\"color\":\"008ee4\",\"anchorradius\":\"7\",\"tooltext\":\"Historical high\",\"stepSkipped\":false,\"appliedSmartLabel\":true},{\"label\":\"2013\",\"value\":\"4200000\",\"color\":\"008ee4\",\"stepSkipped\":false,\"appliedSmartLabel\":true}]}");
          ChartConfig = JObject.Parse("{\"chart\":{\"caption\":\"Sales Report from Jan-May\",\"numberprefix\":\"$\",\"bgcolor\":\"FFFFFF\",\"showalternatehgridcolor\":\"0\",\"plotbordercolor\":\"008ee4\",\"plotborderthickness\":\"3\",\"showvalues\":\"0\",\"divlinecolor\":\"CCCCCC\",\"showcanvasborder\":\"0\",\"tooltipbgcolor\":\"00396d\",\"tooltipcolor\":\"FFFFFF\",\"tooltipbordercolor\":\"00396d\",\"numdivlines\":\"2\",\"yaxisvaluespadding\":\"20\",\"anchorbgcolor\":\"008ee4\",\"anchorborderthickness\":\"0\",\"showshadow\":\"0\",\"anchorradius\":\"4\",\"chartrightmargin\":\"25\",\"canvasborderalpha\":\"0\",\"showborder\":\"0\"}}");
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
    public JObject GetJson2()
    {

      return ChartConfig;
    }
  }
}