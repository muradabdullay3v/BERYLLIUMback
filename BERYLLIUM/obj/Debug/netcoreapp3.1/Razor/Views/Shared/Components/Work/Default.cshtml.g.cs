#pragma checksum "C:\Users\Murad's Tape\Desktop\BERYLLIUMback\BERYLLIUM\Views\Shared\Components\Work\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4cbb079a71fc8033466403d6471500621d49259d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Work_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Work/Default.cshtml")]
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
#line 1 "C:\Users\Murad's Tape\Desktop\BERYLLIUMback\BERYLLIUM\Views\Shared\Components\Work\Default.cshtml"
using BERYLLIUM.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4cbb079a71fc8033466403d6471500621d49259d", @"/Views/Shared/Components/Work/Default.cshtml")]
    public class Views_Shared_Components_Work_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<section id=""work"">
    <div class=""work_title"">
        <h2>Work</h2>
        <p>
            Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus placerat enim et urna sagittis,
            rhoncus euismod erat tincidunt. Donec tincidunt volutpat erat.
        </p>
    </div>
    <div class=""custom_container"">
        <div class=""work_cards"">
");
#nullable restore
#line 13 "C:\Users\Murad's Tape\Desktop\BERYLLIUMback\BERYLLIUM\Views\Shared\Components\Work\Default.cshtml"
             foreach (var work in @Model.Works)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"work_cards-item\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 557, "\"", 572, 1);
#nullable restore
#line 16 "C:\Users\Murad's Tape\Desktop\BERYLLIUMback\BERYLLIUM\Views\Shared\Components\Work\Default.cshtml"
WriteAttributeValue("", 563, work.Url, 563, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"image\">\r\n                    <h3>");
#nullable restore
#line 17 "C:\Users\Murad's Tape\Desktop\BERYLLIUMback\BERYLLIUM\Views\Shared\Components\Work\Default.cshtml"
                   Write(work.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                    <p>");
#nullable restore
#line 18 "C:\Users\Murad's Tape\Desktop\BERYLLIUMback\BERYLLIUM\Views\Shared\Components\Work\Default.cshtml"
                  Write(work.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n");
#nullable restore
#line 20 "C:\Users\Murad's Tape\Desktop\BERYLLIUMback\BERYLLIUM\Views\Shared\Components\Work\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\Murad's Tape\Desktop\BERYLLIUMback\BERYLLIUM\Views\Shared\Components\Work\Default.cshtml"
             foreach (var work in @Model.Works)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"work_cards-item\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 850, "\"", 865, 1);
#nullable restore
#line 24 "C:\Users\Murad's Tape\Desktop\BERYLLIUMback\BERYLLIUM\Views\Shared\Components\Work\Default.cshtml"
WriteAttributeValue("", 856, work.Url, 856, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"image\">\r\n                    <h3>");
#nullable restore
#line 25 "C:\Users\Murad's Tape\Desktop\BERYLLIUMback\BERYLLIUM\Views\Shared\Components\Work\Default.cshtml"
                   Write(work.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                    <p>");
#nullable restore
#line 26 "C:\Users\Murad's Tape\Desktop\BERYLLIUMback\BERYLLIUM\Views\Shared\Components\Work\Default.cshtml"
                  Write(work.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n");
#nullable restore
#line 28 "C:\Users\Murad's Tape\Desktop\BERYLLIUMback\BERYLLIUM\Views\Shared\Components\Work\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
