#pragma checksum "C:\Users\Marcus Taylor\source\repos\WebApplication3\WebApplication3\Views\Shared\DatabasePartialView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5df4751fbfa1bbb544b5ecd780a63cb9093d23be"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_DatabasePartialView), @"mvc.1.0.view", @"/Views/Shared/DatabasePartialView.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/DatabasePartialView.cshtml", typeof(AspNetCore.Views_Shared_DatabasePartialView))]
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
#line 1 "C:\Users\Marcus Taylor\source\repos\WebApplication3\WebApplication3\Views\_ViewImports.cshtml"
using WebApplication3;

#line default
#line hidden
#line 2 "C:\Users\Marcus Taylor\source\repos\WebApplication3\WebApplication3\Views\_ViewImports.cshtml"
using WebApplication3.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5df4751fbfa1bbb544b5ecd780a63cb9093d23be", @"/Views/Shared/DatabasePartialView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"463d1c12e8fc14b2589daa67feec3183fea97611", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_DatabasePartialView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Database>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(17, 65, true);
            WriteLiteral("<div class=\"item\">\r\n    <dl>\r\n        <dt>Item</dt>\r\n        <dd>");
            EndContext();
            BeginContext(83, 10, false);
#line 5 "C:\Users\Marcus Taylor\source\repos\WebApplication3\WebApplication3\Views\Shared\DatabasePartialView.cshtml"
       Write(Model.Item);

#line default
#line hidden
            EndContext();
            BeginContext(93, 45, true);
            WriteLiteral("</dd>\r\n\r\n        <dt>Price</dt>\r\n        <dd>");
            EndContext();
            BeginContext(139, 11, false);
#line 8 "C:\Users\Marcus Taylor\source\repos\WebApplication3\WebApplication3\Views\Shared\DatabasePartialView.cshtml"
       Write(Model.Price);

#line default
#line hidden
            EndContext();
            BeginContext(150, 44, true);
            WriteLiteral("</dd>\r\n\r\n        <dt>Unit</dt>\r\n        <dd>");
            EndContext();
            BeginContext(195, 10, false);
#line 11 "C:\Users\Marcus Taylor\source\repos\WebApplication3\WebApplication3\Views\Shared\DatabasePartialView.cshtml"
       Write(Model.Unit);

#line default
#line hidden
            EndContext();
            BeginContext(205, 65, true);
            WriteLiteral("</dd>\r\n\r\n        <dt>ContactName</dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(271, 17, false);
#line 15 "C:\Users\Marcus Taylor\source\repos\WebApplication3\WebApplication3\Views\Shared\DatabasePartialView.cshtml"
       Write(Model.ContactName);

#line default
#line hidden
            EndContext();
            BeginContext(288, 65, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt> ContactNumber</dt>\r\n        <dd> ");
            EndContext();
            BeginContext(354, 19, false);
#line 19 "C:\Users\Marcus Taylor\source\repos\WebApplication3\WebApplication3\Views\Shared\DatabasePartialView.cshtml"
        Write(Model.ContactNumber);

#line default
#line hidden
            EndContext();
            BeginContext(373, 28, true);
            WriteLiteral("</dd>\r\n    </dl>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Database> Html { get; private set; }
    }
}
#pragma warning restore 1591
