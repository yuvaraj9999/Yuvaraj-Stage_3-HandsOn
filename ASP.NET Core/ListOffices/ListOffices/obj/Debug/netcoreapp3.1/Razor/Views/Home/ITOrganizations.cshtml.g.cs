#pragma checksum "C:\Users\Uvi\Documents\VStudio 2019\ASP.Net Core\ListOffices\ListOffices\Views\Home\ITOrganizations.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a2f91a75943ec30e03b45ebf370129192b4552f6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ITOrganizations), @"mvc.1.0.view", @"/Views/Home/ITOrganizations.cshtml")]
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
#line 1 "C:\Users\Uvi\Documents\VStudio 2019\ASP.Net Core\ListOffices\ListOffices\Views\_ViewImports.cshtml"
using ListOffices;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Uvi\Documents\VStudio 2019\ASP.Net Core\ListOffices\ListOffices\Views\_ViewImports.cshtml"
using ListOffices.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2f91a75943ec30e03b45ebf370129192b4552f6", @"/Views/Home/ITOrganizations.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"965d70be05b7b05b65a40957a15cdf5987c65d53", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ITOrganizations : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<string>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Uvi\Documents\VStudio 2019\ASP.Net Core\ListOffices\ListOffices\Views\Home\ITOrganizations.cshtml"
 foreach (var i in Model)
{
    if (i == "Amazon")
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div><span><b> ");
#nullable restore
#line 6 "C:\Users\Uvi\Documents\VStudio 2019\ASP.Net Core\ListOffices\ListOffices\Views\Home\ITOrganizations.cshtml"
                  Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></span></div>\r\n");
#nullable restore
#line 7 "C:\Users\Uvi\Documents\VStudio 2019\ASP.Net Core\ListOffices\ListOffices\Views\Home\ITOrganizations.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div><span>");
#nullable restore
#line 10 "C:\Users\Uvi\Documents\VStudio 2019\ASP.Net Core\ListOffices\ListOffices\Views\Home\ITOrganizations.cshtml"
              Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></div>\r\n");
#nullable restore
#line 11 "C:\Users\Uvi\Documents\VStudio 2019\ASP.Net Core\ListOffices\ListOffices\Views\Home\ITOrganizations.cshtml"
    }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<string>> Html { get; private set; }
    }
}
#pragma warning restore 1591