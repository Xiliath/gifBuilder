#pragma checksum "C:\Users\Pascal\Documents\GitHub\gifBuilder\gimmegif.web.host\gimmegif.web.host\Views\Manage\_StatusMessage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0723a602e84d5a261d35f2702dcc54883c69cad5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Manage__StatusMessage), @"mvc.1.0.view", @"/Views/Manage/_StatusMessage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Manage/_StatusMessage.cshtml", typeof(AspNetCore.Views_Manage__StatusMessage))]
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
#line 1 "C:\Users\Pascal\Documents\GitHub\gifBuilder\gimmegif.web.host\gimmegif.web.host\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\Pascal\Documents\GitHub\gifBuilder\gimmegif.web.host\gimmegif.web.host\Views\_ViewImports.cshtml"
using gimmegif.web.host;

#line default
#line hidden
#line 3 "C:\Users\Pascal\Documents\GitHub\gifBuilder\gimmegif.web.host\gimmegif.web.host\Views\_ViewImports.cshtml"
using gimmegif.web.host.Models;

#line default
#line hidden
#line 4 "C:\Users\Pascal\Documents\GitHub\gifBuilder\gimmegif.web.host\gimmegif.web.host\Views\_ViewImports.cshtml"
using gimmegif.web.host.Models.AccountViewModels;

#line default
#line hidden
#line 5 "C:\Users\Pascal\Documents\GitHub\gifBuilder\gimmegif.web.host\gimmegif.web.host\Views\_ViewImports.cshtml"
using gimmegif.web.host.Models.ManageViewModels;

#line default
#line hidden
#line 1 "C:\Users\Pascal\Documents\GitHub\gifBuilder\gimmegif.web.host\gimmegif.web.host\Views\Manage\_ViewImports.cshtml"
using gimmegif.web.host.Views.Manage;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0723a602e84d5a261d35f2702dcc54883c69cad5", @"/Views/Manage/_StatusMessage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b03ff2743f67e7d00456811e71033eab3c83d6d4", @"/Views/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40d5909b4f99be3fc81c80c52836b39a805a1991", @"/Views/Manage/_ViewImports.cshtml")]
    public class Views_Manage__StatusMessage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<string>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(15, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Pascal\Documents\GitHub\gifBuilder\gimmegif.web.host\gimmegif.web.host\Views\Manage\_StatusMessage.cshtml"
 if (!String.IsNullOrEmpty(Model))
{
    var statusMessageClass = Model.StartsWith("Error") ? "danger" : "success";

#line default
#line hidden
            BeginContext(136, 8, true);
            WriteLiteral("    <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 144, "\"", 201, 4);
            WriteAttributeValue("", 152, "alert", 152, 5, true);
            WriteAttributeValue(" ", 157, "alert-", 158, 7, true);
#line 6 "C:\Users\Pascal\Documents\GitHub\gifBuilder\gimmegif.web.host\gimmegif.web.host\Views\Manage\_StatusMessage.cshtml"
WriteAttributeValue("", 164, statusMessageClass, 164, 19, false);

#line default
#line hidden
            WriteAttributeValue(" ", 183, "alert-dismissible", 184, 18, true);
            EndWriteAttribute();
            BeginContext(202, 158, true);
            WriteLiteral(" role=\"alert\">\r\n        <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\"><span aria-hidden=\"true\">&times;</span></button>\r\n        ");
            EndContext();
            BeginContext(361, 5, false);
#line 8 "C:\Users\Pascal\Documents\GitHub\gifBuilder\gimmegif.web.host\gimmegif.web.host\Views\Manage\_StatusMessage.cshtml"
   Write(Model);

#line default
#line hidden
            EndContext();
            BeginContext(366, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
#line 10 "C:\Users\Pascal\Documents\GitHub\gifBuilder\gimmegif.web.host\gimmegif.web.host\Views\Manage\_StatusMessage.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<string> Html { get; private set; }
    }
}
#pragma warning restore 1591
