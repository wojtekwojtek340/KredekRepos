#pragma checksum "C:\Users\Wojtek\Desktop\Kredek\wojciech_wojtowicz\lab6\WojciechWojtowiczLab6Zadanie\WojciechWojtowiczLab6Zadanie\Views\Home\GetMilk.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "af244ccd13ef33b519d3aa0ef1bda31890e29ac2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_GetMilk), @"mvc.1.0.view", @"/Views/Home/GetMilk.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/GetMilk.cshtml", typeof(AspNetCore.Views_Home_GetMilk))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af244ccd13ef33b519d3aa0ef1bda31890e29ac2", @"/Views/Home/GetMilk.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42d51497d0ae2c2e2c89190bd13695d92f227a71", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_GetMilk : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MilkViewModels>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(23, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Wojtek\Desktop\Kredek\wojciech_wojtowicz\lab6\WojciechWojtowiczLab6Zadanie\WojciechWojtowiczLab6Zadanie\Views\Home\GetMilk.cshtml"
  
    ViewData["Title"] = "GetMilk";

#line default
#line hidden
            BeginContext(68, 75, true);
            WriteLiteral("\r\n<h2>GetMilk</h2>\r\n<!--wyświetlenie informacji o mleku-->\r\n<div>\r\n    <h2>");
            EndContext();
            BeginContext(144, 10, false);
#line 10 "C:\Users\Wojtek\Desktop\Kredek\wojciech_wojtowicz\lab6\WojciechWojtowiczLab6Zadanie\WojciechWojtowiczLab6Zadanie\Views\Home\GetMilk.cshtml"
   Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(154, 15, true);
            WriteLiteral("</h2>\r\n    <h4>");
            EndContext();
            BeginContext(170, 11, false);
#line 11 "C:\Users\Wojtek\Desktop\Kredek\wojciech_wojtowicz\lab6\WojciechWojtowiczLab6Zadanie\WojciechWojtowiczLab6Zadanie\Views\Home\GetMilk.cshtml"
   Write(Model.Price);

#line default
#line hidden
            EndContext();
            BeginContext(181, 21, true);
            WriteLiteral(" zł/kg</h4>\r\n    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 202, "\"", 233, 1);
#line 12 "C:\Users\Wojtek\Desktop\Kredek\wojciech_wojtowicz\lab6\WojciechWojtowiczLab6Zadanie\WojciechWojtowiczLab6Zadanie\Views\Home\GetMilk.cshtml"
WriteAttributeValue("", 208, Url.Content(Model.Photo), 208, 25, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(234, 2, true);
            WriteLiteral(" ,");
            EndContext();
            BeginWriteAttribute("alt", " alt=\"", 236, "\"", 253, 1);
#line 12 "C:\Users\Wojtek\Desktop\Kredek\wojciech_wojtowicz\lab6\WojciechWojtowiczLab6Zadanie\WojciechWojtowiczLab6Zadanie\Views\Home\GetMilk.cshtml"
WriteAttributeValue("", 242, Model.Name, 242, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(254, 11, true);
            WriteLiteral(" />\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MilkViewModels> Html { get; private set; }
    }
}
#pragma warning restore 1591
