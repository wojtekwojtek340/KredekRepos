#pragma checksum "C:\Users\Wojtek\Desktop\Kredek\wojciech_wojtowicz\lab6\WojciechWojtowiczLab6\WojciechWojtowiczLab6\Views\Home\ContactFormGreetings.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1def1f3472e3798c91235a7e5b914fafce051b66"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ContactFormGreetings), @"mvc.1.0.view", @"/Views/Home/ContactFormGreetings.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ContactFormGreetings.cshtml", typeof(AspNetCore.Views_Home_ContactFormGreetings))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1def1f3472e3798c91235a7e5b914fafce051b66", @"/Views/Home/ContactFormGreetings.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4440e4b777a774cdd7df2684f2d3de15896f9a16", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ContactFormGreetings : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Wojtek\Desktop\Kredek\wojciech_wojtowicz\lab6\WojciechWojtowiczLab6\WojciechWojtowiczLab6\Views\Home\ContactFormGreetings.cshtml"
  
    ViewData["Title"] = "ContactFormGreetings";

#line default
#line hidden
            BeginContext(58, 103, true);
            WriteLiteral("\r\n<h2>ContactFormGreetings</h2>\r\n\r\n<!--Sekcja wyświetlająca powitanie użytkownika-->\r\n<div>\r\n    Witaj ");
            EndContext();
            BeginContext(162, 16, false);
#line 10 "C:\Users\Wojtek\Desktop\Kredek\wojciech_wojtowicz\lab6\WojciechWojtowiczLab6\WojciechWojtowiczLab6\Views\Home\ContactFormGreetings.cshtml"
     Write(ViewBag.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(178, 9, true);
            WriteLiteral("!\r\n</div>");
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
