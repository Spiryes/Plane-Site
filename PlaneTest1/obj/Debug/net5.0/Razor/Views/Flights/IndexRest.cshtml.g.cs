#pragma checksum "D:\IT kariera kursove i (proekti)\IT kariera(Kurs) Projects\Plane-site\PlaneTest1\Views\Flights\IndexRest.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "439a7c4688fd13dfc7cce82c8fcae6e493902815"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Flights_IndexRest), @"mvc.1.0.view", @"/Views/Flights/IndexRest.cshtml")]
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
#line 1 "D:\IT kariera kursove i (proekti)\IT kariera(Kurs) Projects\Plane-site\PlaneTest1\Views\_ViewImports.cshtml"
using PlaneTest1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\IT kariera kursove i (proekti)\IT kariera(Kurs) Projects\Plane-site\PlaneTest1\Views\_ViewImports.cshtml"
using PlaneTest1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"439a7c4688fd13dfc7cce82c8fcae6e493902815", @"/Views/Flights/IndexRest.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c148700516ca4769b70119a2528685c688c5605f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Flights_IndexRest : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PlaneTest1.Models.Flights>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\IT kariera kursove i (proekti)\IT kariera(Kurs) Projects\Plane-site\PlaneTest1\Views\Flights\IndexRest.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Flights</h1>\r\n\r\n<table class=\"table table-striped table-bordered\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 13 "D:\IT kariera kursove i (proekti)\IT kariera(Kurs) Projects\Plane-site\PlaneTest1\Views\Flights\IndexRest.cshtml"
           Write(Html.DisplayNameFor(model => model.Arrival));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "D:\IT kariera kursove i (proekti)\IT kariera(Kurs) Projects\Plane-site\PlaneTest1\Views\Flights\IndexRest.cshtml"
           Write(Html.DisplayNameFor(model => model.Departure));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "D:\IT kariera kursove i (proekti)\IT kariera(Kurs) Projects\Plane-site\PlaneTest1\Views\Flights\IndexRest.cshtml"
           Write(Html.DisplayNameFor(model => model.PilotName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "D:\IT kariera kursove i (proekti)\IT kariera(Kurs) Projects\Plane-site\PlaneTest1\Views\Flights\IndexRest.cshtml"
           Write(Html.DisplayNameFor(model => model.From));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "D:\IT kariera kursove i (proekti)\IT kariera(Kurs) Projects\Plane-site\PlaneTest1\Views\Flights\IndexRest.cshtml"
           Write(Html.DisplayNameFor(model => model.To));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "D:\IT kariera kursove i (proekti)\IT kariera(Kurs) Projects\Plane-site\PlaneTest1\Views\Flights\IndexRest.cshtml"
           Write(Html.DisplayNameFor(model => model.BuisnesSeats));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "D:\IT kariera kursove i (proekti)\IT kariera(Kurs) Projects\Plane-site\PlaneTest1\Views\Flights\IndexRest.cshtml"
           Write(Html.DisplayNameFor(model => model.NormalSeats));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 36 "D:\IT kariera kursove i (proekti)\IT kariera(Kurs) Projects\Plane-site\PlaneTest1\Views\Flights\IndexRest.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 40 "D:\IT kariera kursove i (proekti)\IT kariera(Kurs) Projects\Plane-site\PlaneTest1\Views\Flights\IndexRest.cshtml"
               Write(Html.DisplayFor(modelItem => item.Arrival));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 43 "D:\IT kariera kursove i (proekti)\IT kariera(Kurs) Projects\Plane-site\PlaneTest1\Views\Flights\IndexRest.cshtml"
               Write(Html.DisplayFor(modelItem => item.Departure));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 46 "D:\IT kariera kursove i (proekti)\IT kariera(Kurs) Projects\Plane-site\PlaneTest1\Views\Flights\IndexRest.cshtml"
               Write(Html.DisplayFor(modelItem => item.PilotName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 49 "D:\IT kariera kursove i (proekti)\IT kariera(Kurs) Projects\Plane-site\PlaneTest1\Views\Flights\IndexRest.cshtml"
               Write(Html.DisplayFor(modelItem => item.From));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 52 "D:\IT kariera kursove i (proekti)\IT kariera(Kurs) Projects\Plane-site\PlaneTest1\Views\Flights\IndexRest.cshtml"
               Write(Html.DisplayFor(modelItem => item.To));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 55 "D:\IT kariera kursove i (proekti)\IT kariera(Kurs) Projects\Plane-site\PlaneTest1\Views\Flights\IndexRest.cshtml"
               Write(Html.DisplayFor(modelItem => item.BuisnesSeats));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 58 "D:\IT kariera kursove i (proekti)\IT kariera(Kurs) Projects\Plane-site\PlaneTest1\Views\Flights\IndexRest.cshtml"
               Write(Html.DisplayFor(modelItem => item.NormalSeats));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 61 "D:\IT kariera kursove i (proekti)\IT kariera(Kurs) Projects\Plane-site\PlaneTest1\Views\Flights\IndexRest.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PlaneTest1.Models.Flights>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591