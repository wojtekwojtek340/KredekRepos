#pragma checksum "C:\Users\Wojtek\Desktop\Kredek\wojciech_wojtowicz\lab6\WojciechWojtowiczLab6Zadanie\WojciechWojtowiczLab6Zadanie\Views\Home\CheesePage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cb0306284d1a3cab07ec32cea1989572fa2d71ea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_CheesePage), @"mvc.1.0.view", @"/Views/Home/CheesePage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/CheesePage.cshtml", typeof(AspNetCore.Views_Home_CheesePage))]
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
#line 1 "C:\Users\Wojtek\Desktop\Kredek\wojciech_wojtowicz\lab6\WojciechWojtowiczLab6Zadanie\WojciechWojtowiczLab6Zadanie\Views\_ViewImports.cshtml"
using WojciechWojtowiczLab6Zadanie;

#line default
#line hidden
#line 2 "C:\Users\Wojtek\Desktop\Kredek\wojciech_wojtowicz\lab6\WojciechWojtowiczLab6Zadanie\WojciechWojtowiczLab6Zadanie\Views\_ViewImports.cshtml"
using WojciechWojtowiczLab6Zadanie.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb0306284d1a3cab07ec32cea1989572fa2d71ea", @"/Views/Home/CheesePage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42d51497d0ae2c2e2c89190bd13695d92f227a71", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_CheesePage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CheeseViewModels>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Wojtek\Desktop\Kredek\wojciech_wojtowicz\lab6\WojciechWojtowiczLab6Zadanie\WojciechWojtowiczLab6Zadanie\Views\Home\CheesePage.cshtml"
  
    ViewData["Title"] = "CheesePage";

#line default
#line hidden
            BeginContext(77, 28, true);
            WriteLiteral("\r\n<br />\r\n<br />\r\n<br />\r\n\r\n");
            EndContext();
#line 10 "C:\Users\Wojtek\Desktop\Kredek\wojciech_wojtowicz\lab6\WojciechWojtowiczLab6Zadanie\WojciechWojtowiczLab6Zadanie\Views\Home\CheesePage.cshtml"
 foreach (var cheese in Model)
{

#line default
#line hidden
            BeginContext(140, 45, true);
            WriteLiteral("    <div>\r\n        <!--Nazwa-->\r\n        <h2>");
            EndContext();
            BeginContext(186, 11, false);
#line 14 "C:\Users\Wojtek\Desktop\Kredek\wojciech_wojtowicz\lab6\WojciechWojtowiczLab6Zadanie\WojciechWojtowiczLab6Zadanie\Views\Home\CheesePage.cshtml"
       Write(cheese.Name);

#line default
#line hidden
            EndContext();
            BeginContext(197, 40, true);
            WriteLiteral("</h2>\r\n        <!--Cena-->\r\n        <h4>");
            EndContext();
            BeginContext(238, 12, false);
#line 16 "C:\Users\Wojtek\Desktop\Kredek\wojciech_wojtowicz\lab6\WojciechWojtowiczLab6Zadanie\WojciechWojtowiczLab6Zadanie\Views\Home\CheesePage.cshtml"
       Write(cheese.Price);

#line default
#line hidden
            EndContext();
            BeginContext(250, 49, true);
            WriteLiteral(" zł/kg</h4>\r\n        <!--Zdjęcie-->\r\n        <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 299, "\"", 331, 1);
#line 18 "C:\Users\Wojtek\Desktop\Kredek\wojciech_wojtowicz\lab6\WojciechWojtowiczLab6Zadanie\WojciechWojtowiczLab6Zadanie\Views\Home\CheesePage.cshtml"
WriteAttributeValue("", 305, Url.Content(cheese.Photo), 305, 26, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(332, 2, true);
            WriteLiteral(" ,");
            EndContext();
            BeginWriteAttribute("alt", " alt=\"", 334, "\"", 352, 1);
#line 18 "C:\Users\Wojtek\Desktop\Kredek\wojciech_wojtowicz\lab6\WojciechWojtowiczLab6Zadanie\WojciechWojtowiczLab6Zadanie\Views\Home\CheesePage.cshtml"
WriteAttributeValue("", 340, cheese.Name, 340, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(353, 40, true);
            WriteLiteral(" />\r\n        <a class=\"btn btn-default\" ");
            EndContext();
            BeginContext(394, 75, false);
#line 19 "C:\Users\Wojtek\Desktop\Kredek\wojciech_wojtowicz\lab6\WojciechWojtowiczLab6Zadanie\WojciechWojtowiczLab6Zadanie\Views\Home\CheesePage.cshtml"
                              Write(Html.ActionLink("Sprawdź", "GetCheese", "Home", new { name = cheese.Name }));

#line default
#line hidden
            EndContext();
            BeginContext(469, 29, true);
            WriteLiteral(">\r\n        </a>\r\n    </div>\r\n");
            EndContext();
#line 22 "C:\Users\Wojtek\Desktop\Kredek\wojciech_wojtowicz\lab6\WojciechWojtowiczLab6Zadanie\WojciechWojtowiczLab6Zadanie\Views\Home\CheesePage.cshtml"
}

#line default
#line hidden
            BeginContext(501, 74, true);
            WriteLiteral("\r\n<!--Przycisk złozenia zamówienia-->\r\n<hr />\r\n<a class=\"btn btn-default\" ");
            EndContext();
            BeginContext(576, 55, false);
#line 26 "C:\Users\Wojtek\Desktop\Kredek\wojciech_wojtowicz\lab6\WojciechWojtowiczLab6Zadanie\WojciechWojtowiczLab6Zadanie\Views\Home\CheesePage.cshtml"
                      Write(Html.ActionLink("Złóż zamówienie", "BuyCheese", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(631, 9, true);
            WriteLiteral(">\r\n</a>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CheeseViewModels>> Html { get; private set; }
    }
}
#pragma warning restore 1591
