#pragma checksum "C:\jafariyan\lkbcore\WebApplication\WebApplication\Views\BatteryToCars\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f49b3bdc5c306224c5fe78dda52f3dfddf2a2a7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BatteryToCars_Index), @"mvc.1.0.view", @"/Views/BatteryToCars/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/BatteryToCars/Index.cshtml", typeof(AspNetCore.Views_BatteryToCars_Index))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\jafariyan\lkbcore\WebApplication\WebApplication\Views\_ViewImports.cshtml"
using WebApplication;

#line default
#line hidden
#line 2 "C:\jafariyan\lkbcore\WebApplication\WebApplication\Views\_ViewImports.cshtml"
using WebApplication.Models;

#line default
#line hidden
#line 1 "C:\jafariyan\lkbcore\WebApplication\WebApplication\Views\BatteryToCars\Index.cshtml"
using WebApplication.abbas_lkb;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f49b3bdc5c306224c5fe78dda52f3dfddf2a2a7", @"/Views/BatteryToCars/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa0ef8da47a84ffb33e8bc853509aa4fa5703a26", @"/Views/_ViewImports.cshtml")]
    public class Views_BatteryToCars_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<WebApplication.abbas_lkb.TblCar>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(79, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\jafariyan\lkbcore\WebApplication\WebApplication\Views\BatteryToCars\Index.cshtml"
  
    ViewBag.Title = "title";
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(143, 282, true);
            WriteLiteral(@"
<style>
  .bat{
    border: 1px #1b6d85 solid;
    padding: 1px;
    margin: 2px;
    }
    
    .bat:hover{
      background-color: #c97fce;
      }
      
      .x{
         border: 1px #1b6d85 solid;
 
      }
</style>


<table class=""table table-bordered"">
");
            EndContext();
            BeginContext(617, 13, true);
            WriteLiteral("    <tbody>\r\n");
            EndContext();
#line 37 "C:\jafariyan\lkbcore\WebApplication\WebApplication\Views\BatteryToCars\Index.cshtml"
      
        List<TblCategory> cats = ViewBag.cats;
        var count = cats.Count / 10 + 1;
        if (cats.Count == 10)
        {
            count = 1;
        }
    

#line default
#line hidden
            BeginContext(812, 4, true);
            WriteLiteral("    ");
            EndContext();
#line 45 "C:\jafariyan\lkbcore\WebApplication\WebApplication\Views\BatteryToCars\Index.cshtml"
     for (int i = 0; i < count; i++)
    {

#line default
#line hidden
            BeginContext(857, 14, true);
            WriteLiteral("        <tr>\r\n");
            EndContext();
#line 48 "C:\jafariyan\lkbcore\WebApplication\WebApplication\Views\BatteryToCars\Index.cshtml"
             for (int j = i * 10; j < i * 10 + 10; j++)
            {
                if (j >= cats.Count)
                {
                    break;
                }
                var m = cats[j];

#line default
#line hidden
            BeginContext(1081, 23, true);
            WriteLiteral("                <td >\r\n");
            EndContext();
#line 56 "C:\jafariyan\lkbcore\WebApplication\WebApplication\Views\BatteryToCars\Index.cshtml"
                     if (ViewBag.catId ==m.Id)
                    {

#line default
#line hidden
            BeginContext(1175, 47, true);
            WriteLiteral("                        <a class=\"btn btn-info\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1222, "\"", 1269, 1);
#line 58 "C:\jafariyan\lkbcore\WebApplication\WebApplication\Views\BatteryToCars\Index.cshtml"
WriteAttributeValue("", 1229, Url.Action("Index", new {catId = m.Id}), 1229, 40, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1270, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1272, 6, false);
#line 58 "C:\jafariyan\lkbcore\WebApplication\WebApplication\Views\BatteryToCars\Index.cshtml"
                                                                                           Write(m.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1278, 6, true);
            WriteLiteral("</a>\r\n");
            EndContext();
#line 59 "C:\jafariyan\lkbcore\WebApplication\WebApplication\Views\BatteryToCars\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(1356, 50, true);
            WriteLiteral("                        <a class=\"btn btn-primary\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1406, "\"", 1453, 1);
#line 62 "C:\jafariyan\lkbcore\WebApplication\WebApplication\Views\BatteryToCars\Index.cshtml"
WriteAttributeValue("", 1413, Url.Action("Index", new {catId = m.Id}), 1413, 40, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1454, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1456, 6, false);
#line 62 "C:\jafariyan\lkbcore\WebApplication\WebApplication\Views\BatteryToCars\Index.cshtml"
                                                                                              Write(m.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1462, 6, true);
            WriteLiteral("</a>\r\n");
            EndContext();
#line 63 "C:\jafariyan\lkbcore\WebApplication\WebApplication\Views\BatteryToCars\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(1491, 23, true);
            WriteLiteral("                </td>\r\n");
            EndContext();
#line 65 "C:\jafariyan\lkbcore\WebApplication\WebApplication\Views\BatteryToCars\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(1529, 15, true);
            WriteLiteral("        </tr>\r\n");
            EndContext();
#line 67 "C:\jafariyan\lkbcore\WebApplication\WebApplication\Views\BatteryToCars\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(1551, 279, true);
            WriteLiteral(@"

    </tbody>
</table>

<table class=""table table-bordered"">
    <thead>
    <tr>
        <th scope=""col"">#</th>
        <th scope=""col"">نام ماشین</th>
        <th scope=""col"">انتخاب</th>
        <th scope=""col"">انتخاب شده</th>
    </tr>
    </thead>
    <tbody>
");
            EndContext();
            BeginContext(1845, 4, true);
            WriteLiteral("    ");
            EndContext();
#line 85 "C:\jafariyan\lkbcore\WebApplication\WebApplication\Views\BatteryToCars\Index.cshtml"
     foreach (var m in Model)
    {

#line default
#line hidden
            BeginContext(1883, 41, true);
            WriteLiteral("        <tr>\r\n            <th scope=\"row\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1924, "\"", 1946, 2);
            WriteAttributeValue("", 1929, "car_in_page_", 1929, 12, true);
#line 88 "C:\jafariyan\lkbcore\WebApplication\WebApplication\Views\BatteryToCars\Index.cshtml"
WriteAttributeValue("", 1941, m.Id, 1941, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1947, 19, true);
            WriteLiteral(">\r\n                ");
            EndContext();
            BeginContext(1967, 4, false);
#line 89 "C:\jafariyan\lkbcore\WebApplication\WebApplication\Views\BatteryToCars\Index.cshtml"
           Write(m.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1971, 37, true);
            WriteLiteral("\r\n            </th>\r\n            <td>");
            EndContext();
            BeginContext(2009, 6, false);
#line 91 "C:\jafariyan\lkbcore\WebApplication\WebApplication\Views\BatteryToCars\Index.cshtml"
           Write(m.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2015, 2, true);
            WriteLiteral(" (");
            EndContext();
            BeginContext(2018, 10, false);
#line 91 "C:\jafariyan\lkbcore\WebApplication\WebApplication\Views\BatteryToCars\Index.cshtml"
                    Write(m.Cat.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2028, 51, true);
            WriteLiteral(")</td>\r\n            <td>\r\n\r\n                <button");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2079, "\"", 2120, 5);
            WriteAttributeValue("", 2089, "onModalOpen(\'.b_", 2089, 16, true);
#line 94 "C:\jafariyan\lkbcore\WebApplication\WebApplication\Views\BatteryToCars\Index.cshtml"
WriteAttributeValue("", 2105, m.Id, 2105, 5, false);

#line default
#line hidden
            WriteAttributeValue("", 2110, "\',\'", 2110, 3, true);
#line 94 "C:\jafariyan\lkbcore\WebApplication\WebApplication\Views\BatteryToCars\Index.cshtml"
WriteAttributeValue("", 2113, m.Id, 2113, 5, false);

#line default
#line hidden
            WriteAttributeValue("", 2118, "\')", 2118, 2, true);
            EndWriteAttribute();
            BeginContext(2121, 207, true);
            WriteLiteral("\r\n\r\n                        class=\"btn btn-info\" data-toggle=\"modal\" data-target=\"#myModal\">\r\n                    +\r\n                </button>\r\n\r\n\r\n            </td>\r\n            <td style=\"display: flex\">\r\n");
            EndContext();
#line 103 "C:\jafariyan\lkbcore\WebApplication\WebApplication\Views\BatteryToCars\Index.cshtml"
                 foreach (var bat in m.TblItemCar)
                {
                    if (bat.Item.CatId == ViewBag.catId)
                    {

#line default
#line hidden
            BeginContext(2480, 81, true);
            WriteLiteral("                        <span class=\"bat \">\r\n\r\n                            <input");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 2561, "\"", 2576, 2);
            WriteAttributeValue("", 2569, "b_", 2569, 2, true);
#line 109 "C:\jafariyan\lkbcore\WebApplication\WebApplication\Views\BatteryToCars\Index.cshtml"
WriteAttributeValue("", 2571, m.Id, 2571, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2577, 14, true);
            WriteLiteral(" type=\"hidden\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2591, "\"", 2610, 1);
#line 109 "C:\jafariyan\lkbcore\WebApplication\WebApplication\Views\BatteryToCars\Index.cshtml"
WriteAttributeValue("", 2599, bat.ItemId, 2599, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2611, 36, true);
            WriteLiteral("/>\r\n\r\n\r\n                            ");
            EndContext();
            BeginContext(2648, 13, false);
#line 112 "C:\jafariyan\lkbcore\WebApplication\WebApplication\Views\BatteryToCars\Index.cshtml"
                       Write(bat.Item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2661, 27, true);
            WriteLiteral(" <a style=\"cursor: pointer\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2688, "\"", 2741, 5);
            WriteAttributeValue("", 2698, "removeItem(this,\'", 2698, 17, true);
#line 112 "C:\jafariyan\lkbcore\WebApplication\WebApplication\Views\BatteryToCars\Index.cshtml"
WriteAttributeValue("", 2715, bat.CarId, 2715, 10, false);

#line default
#line hidden
            WriteAttributeValue("", 2725, "\',\'", 2725, 3, true);
#line 112 "C:\jafariyan\lkbcore\WebApplication\WebApplication\Views\BatteryToCars\Index.cshtml"
WriteAttributeValue("", 2728, bat.ItemId, 2728, 11, false);

#line default
#line hidden
            WriteAttributeValue("", 2739, "\')", 2739, 2, true);
            EndWriteAttribute();
            BeginContext(2742, 51, true);
            WriteLiteral(" class=\"x\">x</a>\r\n                        </span>\r\n");
            EndContext();
#line 114 "C:\jafariyan\lkbcore\WebApplication\WebApplication\Views\BatteryToCars\Index.cshtml"
                    }
                }

#line default
#line hidden
            BeginContext(2835, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 119 "C:\jafariyan\lkbcore\WebApplication\WebApplication\Views\BatteryToCars\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(2878, 515, true);
            WriteLiteral(@"
    </tbody>
</table>


<!-- Modal -->
<div id=""myModal"" class=""modal fade "" role=""dialog"">
    <div class=""modal-dialog"">

        <!-- Modal content-->
        <div class=""modal-content"">
            <div class=""modal-header"">
                <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
                <h4 class=""modal-title"">Modal Header</h4>
            </div>
            <div class=""modal-body"">

                <div >
                    <div class=""row"">
");
            EndContext();
#line 139 "C:\jafariyan\lkbcore\WebApplication\WebApplication\Views\BatteryToCars\Index.cshtml"
                         using (Html.BeginForm("addItem", "BatteryToCars"
                            , FormMethod.Post))
                        {

#line default
#line hidden
            BeginContext(3544, 174, true);
            WriteLiteral("                            <input name=\"CarId\" id=\"CarId\" type=\"hidden\"/>\r\n                            <input name=\"ItemCategoryTypeId\" id=\"ItemCategoryTypeId\" type=\"hidden\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3718, "\"", 3740, 1);
#line 143 "C:\jafariyan\lkbcore\WebApplication\WebApplication\Views\BatteryToCars\Index.cshtml"
WriteAttributeValue("", 3726, ViewBag.catId, 3726, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3741, 147, true);
            WriteLiteral("/>\r\n                            <input name=\"backToCarItemUrl\" id=\"backToCarItemUrl\"\r\n                                   type=\"hidden\" value=\"\"/>\r\n");
            EndContext();
#line 146 "C:\jafariyan\lkbcore\WebApplication\WebApplication\Views\BatteryToCars\Index.cshtml"

                            List<TblItem> bats = ViewBag.bats;
                            foreach (var item in bats)
                            {

#line default
#line hidden
            BeginContext(4041, 36, true);
            WriteLiteral("                                <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 4077, "\"", 4132, 4);
            WriteAttributeValue("", 4085, "col-md-3", 4085, 8, true);
            WriteAttributeValue(" ", 4093, "item_to_select", 4094, 15, true);
            WriteAttributeValue(" ", 4108, "item_to_select_", 4109, 16, true);
#line 150 "C:\jafariyan\lkbcore\WebApplication\WebApplication\Views\BatteryToCars\Index.cshtml"
WriteAttributeValue("", 4124, item.Id, 4124, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4133, 132, true);
            WriteLiteral(">\r\n                                    <button type=\"button\" class=\" item_to_select_button btn btn-info \" onclick=\"selectBat(this)\">");
            EndContext();
            BeginContext(4266, 9, false);
#line 151 "C:\jafariyan\lkbcore\WebApplication\WebApplication\Views\BatteryToCars\Index.cshtml"
                                                                                                                            Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(4275, 94, true);
            WriteLiteral("</button>\r\n                                    <input class=\"item \" name=\"Items[]\" type=\"text\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 4369, "\"", 4385, 1);
#line 152 "C:\jafariyan\lkbcore\WebApplication\WebApplication\Views\BatteryToCars\Index.cshtml"
WriteAttributeValue("", 4377, item.Id, 4377, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4386, 150, true);
            WriteLiteral(" disabled=\"disabled\"\r\n                                           readonly=\"readonly\" style=\"display: none\"/>\r\n                                </div>\r\n");
            EndContext();
#line 155 "C:\jafariyan\lkbcore\WebApplication\WebApplication\Views\BatteryToCars\Index.cshtml"
                            }


#line default
#line hidden
            BeginContext(4569, 52, true);
            WriteLiteral("                            <input type=\"submit\"/>\r\n");
            EndContext();
#line 158 "C:\jafariyan\lkbcore\WebApplication\WebApplication\Views\BatteryToCars\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(4648, 58, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n\r\n\r\n");
            EndContext();
            BeginContext(5458, 1584, true);
            WriteLiteral(@"
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-default"" data-dismiss=""modal"">Close</button>
            </div>
        </div>

    </div>
</div>

<script>

function onModalOpen(selector,carid) {
    $('#CarId').val(carid);
    $('#backToCarItemUrl').val('#car_in_page_'+carid);
    
    
    
          $('.item_to_select').show();
          var buttons= $('.item_to_select_button');
        buttons .removeClass('btn-success');
          buttons.addClass('btn-info');
  
    $(selector).each(function(){// id of ul
      var val = $(this).val();
      
      console.log('.item_to_select_'+val);
    
        $('.item_to_select_'+val).hide();
    
    })
}

function selectBat(el) {
  if($(el).next().attr('disabled')){
          {
   $(el).removeClass('btn-info');
              $(el).addClass('btn-success');
              $(el).next().removeAttr('disabled');
          }
    }else{
  $(el).removeClass('btn-success");
            WriteLiteral(@"');
                      $(el).addClass('btn-info');
                $(el).next().attr('disabled','disabled');
    }
}

function removeItem(el,carid,itemid) {
  
    
    $.ajax({
    url:'/BatteryToCars/removeItem',
    data:{carId :carid,itemId:itemid},
    method:'post',
    fail:function(e) {
      
         console.error('fail',e);
 },
    error:function(e) {
       console.error('error',e);
    },
    success:function(s) {
      console.log('success');
         $(el).parent().hide();
  }
    })
    
    
}
</script>

");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(7059, 55, true);
                WriteLiteral("\r\n    <script>\r\n\r\n$(document).ready(function() {\r\n  $(\"");
                EndContext();
                BeginContext(7115, 28, false);
#line 255 "C:\jafariyan\lkbcore\WebApplication\WebApplication\Views\BatteryToCars\Index.cshtml"
Write(TempData["backToCarItemUrl"]);

#line default
#line hidden
                EndContext();
                BeginContext(7143, 52, true);
                WriteLiteral("\").parent().css(\"backgroundColor\",\"#9fff00\");\r\n   \r\n");
                EndContext();
#line 257 "C:\jafariyan\lkbcore\WebApplication\WebApplication\Views\BatteryToCars\Index.cshtml"
 if (TempData["backToCarItemUrl"] != null)
    {
   
    

#line default
#line hidden
                BeginContext(7261, 32, true);
                WriteLiteral("\r\n         window.scrollTo(0,$(\"");
                EndContext();
                BeginContext(7294, 28, false);
#line 261 "C:\jafariyan\lkbcore\WebApplication\WebApplication\Views\BatteryToCars\Index.cshtml"
                         Write(TempData["backToCarItemUrl"]);

#line default
#line hidden
                EndContext();
                BeginContext(7322, 510, true);
                WriteLiteral(@""").offset().top-150);
         
      /*   $(""TempData[""backToCarItemUrl""]"").parent().parent().animate({
                        backgroundColor    : ""white""
                    }, 3000);*/
         /*
           $(""TempData[""backToCarItemUrl""]"").animate({backgroundColor: ""white""},1000);
           $(""TempData[""backToCarItemUrl""]"").parent().animate({backgroundColor: ""white""},1000);
           $(""TempData[""backToCarItemUrl""]"").parent().parent().animate({backgroundColor: ""white""},1000);
*/
       ");
                EndContext();
#line 271 "C:\jafariyan\lkbcore\WebApplication\WebApplication\Views\BatteryToCars\Index.cshtml"
              

}

#line default
#line hidden
                BeginContext(7846, 28, true);
                WriteLiteral("\r\n})\r\n       </script>\r\n\r\n\r\n");
                EndContext();
            }
            );
            BeginContext(7877, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<WebApplication.abbas_lkb.TblCar>> Html { get; private set; }
    }
}
#pragma warning restore 1591