#pragma checksum "C:\Users\user\Desktop\CTS\Testing\NUnit code reference\ASPcoreHANDSON\Views\Home\Table.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8533e34c9bef411173793e2dabd5946de3090102"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Table), @"mvc.1.0.view", @"/Views/Home/Table.cshtml")]
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
#line 1 "C:\Users\user\Desktop\CTS\Testing\NUnit code reference\ASPcoreHANDSON\Views\_ViewImports.cshtml"
using ASPcoreHANDSON;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\Desktop\CTS\Testing\NUnit code reference\ASPcoreHANDSON\Views\_ViewImports.cshtml"
using ASPcoreHANDSON.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8533e34c9bef411173793e2dabd5946de3090102", @"/Views/Home/Table.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34feb02dfcbbc820791f6ff4dfce1d992eb7a45f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Table : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ASPcoreHANDSON.Models.Employeedeets>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Users\user\Desktop\CTS\Testing\NUnit code reference\ASPcoreHANDSON\Views\Home\Table.cshtml"
 foreach (var e in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row\">\r\n        <div class=\"col-md-4\">");
#nullable restore
#line 7 "C:\Users\user\Desktop\CTS\Testing\NUnit code reference\ASPcoreHANDSON\Views\Home\Table.cshtml"
                         Write(e.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        <div class=\"col-md-4\">");
#nullable restore
#line 8 "C:\Users\user\Desktop\CTS\Testing\NUnit code reference\ASPcoreHANDSON\Views\Home\Table.cshtml"
                         Write(e.Salary);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        <div class=\"col-md-4\">");
#nullable restore
#line 9 "C:\Users\user\Desktop\CTS\Testing\NUnit code reference\ASPcoreHANDSON\Views\Home\Table.cshtml"
                         Write(e.Permanent);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    </div>\r\n");
#nullable restore
#line 11 "C:\Users\user\Desktop\CTS\Testing\NUnit code reference\ASPcoreHANDSON\Views\Home\Table.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ASPcoreHANDSON.Models.Employeedeets>> Html { get; private set; }
    }
}
#pragma warning restore 1591
