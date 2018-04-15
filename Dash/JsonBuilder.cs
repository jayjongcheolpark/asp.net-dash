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
        case "map":
          //ChartConfig = JObject.Parse("{\"chart\":{\"animation\":\"0\",\"showbevel\":\"0\",\"usehovercolor\":\"1\",\"canvasbordercolor\":\"FFFFFF\",\"bordercolor\":\"FFFFFF\",\"showlegend\":\"1\",\"showshadow\":\"0\",\"legendposition\":\"BOTTOM\",\"legendborderalpha\":\"0\",\"legendbordercolor\":\"ffffff\",\"legendallowdrag\":\"0\",\"legendshadow\":\"0\",\"caption\":\"Website Visits for the month of Jan 2014\",\"connectorcolor\":\"000000\",\"fillalpha\":\"80\",\"hovercolor\":\"CCCCCC\",\"showborder\":0},\"colorrange\":{\"minvalue\":\"0\",\"startlabel\":\"Low\",\"endlabel\":\"High\",\"code\":\"e44a00\",\"gradient\":\"1\",\"color\":[{\"maxvalue\":30000,\"displayvalue\":\"Average\",\"code\":\"f8bd19\"},{\"maxvalue\":100000,\"code\":\"6baa01\"}],\"maxvalue\":0},\"data\":[{\"data\":[{\"id\":\"10\",\"value\":\"1109\"},{\"id\":\"11\",\"value\":\"61443\"},{\"id\":\"12\",\"value\":\"46056\"},{\"id\":\"13\",\"value\":\"67751\"},{\"id\":\"14\",\"value\":\"79627\"},{\"id\":\"09\",\"value\":\"30672\"},{\"id\":\"07\",\"value\":\"72168\"},{\"id\":\"02\",\"value\":\"42293\"},{\"id\":\"01\",\"value\":\"36067\"},{\"id\":\"03\",\"value\":\"38417\"},{\"id\":\"08\",\"value\":\"92293\"},{\"id\":\"05\",\"value\":\"92293\"},{\"id\":\"04\",\"value\":\"92293\"}]}]}");
          ChartConfig = JObject.Parse("{\"chart\":{\"animation\":\"0\",\"showbevel\":\"0\",\"usehovercolor\":\"1\",\"canvasbordercolor\":\"FFFFFF\",\"bordercolor\":\"FFFFFF\",\"showlegend\":\"1\",\"showshadow\":\"0\",\"legendposition\":\"BOTTOM\",\"legendborderalpha\":\"0\",\"legendbordercolor\":\"ffffff\",\"legendallowdrag\":\"0\",\"legendshadow\":\"0\",\"caption\":\"Website Visits for the month of Jan 2014\",\"connectorcolor\":\"000000\",\"fillalpha\":\"80\",\"hovercolor\":\"CCCCCC\",\"showborder\":0},\"colorrange\":{\"minvalue\":\"0\",\"startlabel\":\"Low\",\"endlabel\":\"High\",\"code\":\"e44a00\",\"gradient\":\"1\",\"color\":[{\"maxvalue\":30000,\"displayvalue\":\"Average\",\"code\":\"f8bd19\"},{\"maxvalue\":100000,\"code\":\"6baa01\"}],\"maxvalue\":0},\"data\":[{\"data\":[{\"id\":\"HI\",\"value\":\"2194\"},{\"id\":\"DC\",\"value\":\"2377\"},{\"id\":\"MD\",\"value\":\"1355\"},{\"id\":\"DE\",\"value\":\"3946\"},{\"id\":\"RI\",\"value\":\"1414\"},{\"id\":\"WA\",\"value\":\"70036\"},{\"id\":\"OR\",\"value\":\"77514\"},{\"id\":\"CA\",\"value\":\"35292\"},{\"id\":\"AK\",\"value\":\"43952\"},{\"id\":\"ID\",\"value\":\"42887\"},{\"id\":\"NV\",\"value\":\"43948\"},{\"id\":\"AZ\",\"value\":\"50512\"},{\"id\":\"MT\",\"value\":\"61809\"},{\"id\":\"WY\",\"value\":\"59863\"},{\"id\":\"UT\",\"value\":\"39918\"},{\"id\":\"CO\",\"value\":\"47262\"},{\"id\":\"NM\",\"value\":\"74046\"},{\"id\":\"ND\",\"value\":\"46592\"},{\"id\":\"SD\",\"value\":\"75265\"},{\"id\":\"NE\",\"value\":\"46710\"},{\"id\":\"KS\",\"value\":\"47127\"},{\"id\":\"OK\",\"value\":\"60263\"},{\"id\":\"TX\",\"value\":\"58375\"},{\"id\":\"MN\",\"value\":\"68776\"},{\"id\":\"IA\",\"value\":\"40748\"},{\"id\":\"MO\",\"value\":\"67420\"},{\"id\":\"AR\",\"value\":\"38740\"},{\"id\":\"LA\",\"value\":\"65332\"},{\"id\":\"WI\",\"value\":\"65316\"},{\"id\":\"IL\",\"value\":\"71660\"},{\"id\":\"KY\",\"value\":\"58436\"},{\"id\":\"TN\",\"value\":\"36564\"},{\"id\":\"MS\",\"value\":\"47815\"},{\"id\":\"AL\",\"value\":\"64283\"},{\"id\":\"GA\",\"value\":\"40352\"},{\"id\":\"MI\",\"value\":\"46327\"},{\"id\":\"IN\",\"value\":\"30791\"},{\"id\":\"OH\",\"value\":\"57285\"},{\"id\":\"PA\",\"value\":\"56594\"},{\"id\":\"NY\",\"value\":\"70684\"},{\"id\":\"VT\",\"value\":\"78682\"},{\"id\":\"NH\",\"value\":\"35256\"},{\"id\":\"ME\",\"value\":\"63826\"},{\"id\":\"MA\",\"value\":\"52274\"},{\"id\":\"CT\",\"value\":\"42095\"},{\"id\":\"NJ\",\"value\":\"89225\"},{\"id\":\"WV\",\"value\":\"85779\"},{\"id\":\"VA\",\"value\":\"95482\"},{\"id\":\"NC\",\"value\":\"98665\"},{\"id\":\"SC\",\"value\":\"95165\"},{\"id\":\"FL\",\"value\":\"95165\"}]}]}");
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