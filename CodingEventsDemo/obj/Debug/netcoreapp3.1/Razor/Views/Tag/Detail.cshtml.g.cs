#pragma checksum "/Users/lin/Documents/codecamp2020/csharp/CodingEventsDemo/CodingEventsDemo/Views/Tag/Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e33d17d07bddc03b3066bb3df107b00041aa5658"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tag_Detail), @"mvc.1.0.view", @"/Views/Tag/Detail.cshtml")]
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
#line 1 "/Users/lin/Documents/codecamp2020/csharp/CodingEventsDemo/CodingEventsDemo/Views/_ViewImports.cshtml"
using CodingEventsDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/lin/Documents/codecamp2020/csharp/CodingEventsDemo/CodingEventsDemo/Views/_ViewImports.cshtml"
using CodingEventsDemo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e33d17d07bddc03b3066bb3df107b00041aa5658", @"/Views/Tag/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2862d6d7fe702d67a59e00c5d71a9cc7026b7fe", @"/Views/_ViewImports.cshtml")]
    public class Views_Tag_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CodingEventsDemo.Models.EventTag>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "/Users/lin/Documents/codecamp2020/csharp/CodingEventsDemo/CodingEventsDemo/Views/Tag/Detail.cshtml"
 if (Model.Count == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>No elements with the given tag</h1>\n");
#nullable restore
#line 6 "/Users/lin/Documents/codecamp2020/csharp/CodingEventsDemo/CodingEventsDemo/Views/Tag/Detail.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>Events Tagged: ");
#nullable restore
#line 9 "/Users/lin/Documents/codecamp2020/csharp/CodingEventsDemo/CodingEventsDemo/Views/Tag/Detail.cshtml"
                  Write(Model[0].Tag.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n    <ul>\n");
#nullable restore
#line 11 "/Users/lin/Documents/codecamp2020/csharp/CodingEventsDemo/CodingEventsDemo/Views/Tag/Detail.cshtml"
         foreach (var evtTag in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>");
#nullable restore
#line 13 "/Users/lin/Documents/codecamp2020/csharp/CodingEventsDemo/CodingEventsDemo/Views/Tag/Detail.cshtml"
           Write(evtTag.Event.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n");
#nullable restore
#line 14 "/Users/lin/Documents/codecamp2020/csharp/CodingEventsDemo/CodingEventsDemo/Views/Tag/Detail.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\n");
#nullable restore
#line 16 "/Users/lin/Documents/codecamp2020/csharp/CodingEventsDemo/CodingEventsDemo/Views/Tag/Detail.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CodingEventsDemo.Models.EventTag>> Html { get; private set; }
    }
}
#pragma warning restore 1591