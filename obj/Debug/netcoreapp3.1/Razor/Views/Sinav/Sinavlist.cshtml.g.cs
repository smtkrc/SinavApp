#pragma checksum "C:\Users\SametKürücü\source\repos\SinavProje\SinavProje\Views\Sinav\Sinavlist.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "35da020caa83c066e25047a721d0495b8c461252"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sinav_Sinavlist), @"mvc.1.0.view", @"/Views/Sinav/Sinavlist.cshtml")]
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
#nullable restore
#line 1 "C:\Users\SametKürücü\source\repos\SinavProje\SinavProje\Views\_ViewImports.cshtml"
using SinavProje;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\SametKürücü\source\repos\SinavProje\SinavProje\Views\Sinav\Sinavlist.cshtml"
using SinavProje.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35da020caa83c066e25047a721d0495b8c461252", @"/Views/Sinav/Sinavlist.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3365ec7359c51c81a6b7e733c7ba8888860ee6f5", @"/Views/_ViewImports.cshtml")]
    public class Views_Sinav_Sinavlist : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SorularDetay>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\SametKürücü\source\repos\SinavProje\SinavProje\Views\Sinav\Sinavlist.cshtml"
  
    ViewData["Title"] = "YeniSinav";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<table class=\"table table-bordered\">\r\n    <thead>\r\n        <tr>\r\n            <th>#</th>\r\n            <th>BAŞLIK</th>\r\n            <th>TARİH</th>\r\n            <th>Sil</th>\r\n            <th>SINAV ÇÖZ</th>\r\n\r\n        </tr>\r\n    </thead>\r\n");
#nullable restore
#line 20 "C:\Users\SametKürücü\source\repos\SinavProje\SinavProje\Views\Sinav\Sinavlist.cshtml"
     foreach (var x in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 23 "C:\Users\SametKürücü\source\repos\SinavProje\SinavProje\Views\Sinav\Sinavlist.cshtml"
           Write(x.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 24 "C:\Users\SametKürücü\source\repos\SinavProje\SinavProje\Views\Sinav\Sinavlist.cshtml"
           Write(x.SoruBaslik);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 25 "C:\Users\SametKürücü\source\repos\SinavProje\SinavProje\Views\Sinav\Sinavlist.cshtml"
           Write(x.Tarih);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td style=\"color:white\"><a");
            BeginWriteAttribute("href", " href=\"", 569, "\"", 597, 2);
            WriteAttributeValue("", 576, "/Sinav/SinavSil/", 576, 16, true);
#nullable restore
#line 26 "C:\Users\SametKürücü\source\repos\SinavProje\SinavProje\Views\Sinav\Sinavlist.cshtml"
WriteAttributeValue("", 592, x.ID, 592, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Sil</a></td>\r\n            <td style=\"color:white\"><a");
            BeginWriteAttribute("href", " href=\"", 674, "\"", 702, 2);
            WriteAttributeValue("", 681, "/Sinav/SinavCöz/", 681, 16, true);
#nullable restore
#line 27 "C:\Users\SametKürücü\source\repos\SinavProje\SinavProje\Views\Sinav\Sinavlist.cshtml"
WriteAttributeValue("", 697, x.ID, 697, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Çöz</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 29 "C:\Users\SametKürücü\source\repos\SinavProje\SinavProje\Views\Sinav\Sinavlist.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<SorularDetay>> Html { get; private set; }
    }
}
#pragma warning restore 1591
