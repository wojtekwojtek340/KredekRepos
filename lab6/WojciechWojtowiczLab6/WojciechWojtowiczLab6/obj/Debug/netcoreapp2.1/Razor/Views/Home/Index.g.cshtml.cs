#pragma checksum "C:\Users\Wojtek\Desktop\Kredek\wojciech_wojtowicz\lab6\WojciechWojtowiczLab6\WojciechWojtowiczLab6\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7ff40e44ad07d4ed1c2bfb60837dee5c4c3a5c7a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\Wojtek\Desktop\Kredek\wojciech_wojtowicz\lab6\WojciechWojtowiczLab6\WojciechWojtowiczLab6\Views\_ViewImports.cshtml"
using WojciechWojtowiczLab6;

#line default
#line hidden
#line 2 "C:\Users\Wojtek\Desktop\Kredek\wojciech_wojtowicz\lab6\WojciechWojtowiczLab6\WojciechWojtowiczLab6\Views\_ViewImports.cshtml"
using WojciechWojtowiczLab6.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ff40e44ad07d4ed1c2bfb60837dee5c4c3a5c7a", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4440e4b777a774cdd7df2684f2d3de15896f9a16", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Wojtek\Desktop\Kredek\wojciech_wojtowicz\lab6\WojciechWojtowiczLab6\WojciechWojtowiczLab6\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "HomePage";

#line default
#line hidden
            BeginContext(44, 31, true);
            WriteLiteral("\r\n\r\n<!--Stona główna-->\r\n\r\n<h2>");
            EndContext();
            BeginContext(76, 53, false);
#line 8 "C:\Users\Wojtek\Desktop\Kredek\wojciech_wojtowicz\lab6\WojciechWojtowiczLab6\WojciechWojtowiczLab6\Views\Home\Index.cshtml"
Write(Html.ActionLink("Przejdz", "IntrestingLinks", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(129, 19, true);
            WriteLiteral("</h2>\r\n<hr />\r\n<h2>");
            EndContext();
            BeginContext(149, 66, false);
#line 10 "C:\Users\Wojtek\Desktop\Kredek\wojciech_wojtowicz\lab6\WojciechWojtowiczLab6\WojciechWojtowiczLab6\Views\Home\Index.cshtml"
Write(Html.ActionLink("Pokaż wszystkie samochody", "GetAllCars", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(215, 19, true);
            WriteLiteral("</h2>\r\n<hr />\r\n<h2>");
            EndContext();
            BeginContext(235, 64, false);
#line 12 "C:\Users\Wojtek\Desktop\Kredek\wojciech_wojtowicz\lab6\WojciechWojtowiczLab6\WojciechWojtowiczLab6\Views\Home\Index.cshtml"
Write(Html.ActionLink("Pokaż listę modeli", "GetListOfModels", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(299, 19, true);
            WriteLiteral("</h2>\r\n<hr />\r\n<h2>");
            EndContext();
            BeginContext(319, 62, false);
#line 14 "C:\Users\Wojtek\Desktop\Kredek\wojciech_wojtowicz\lab6\WojciechWojtowiczLab6\WojciechWojtowiczLab6\Views\Home\Index.cshtml"
Write(Html.ActionLink("Formularz kontaktowy", "ContactForm", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(381, 17, true);
            WriteLiteral("</h2>\r\n<hr />\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591