#pragma checksum "G:\Programowanie\C#\.net core\Projekt\Projekt\Views\EndedRent\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dbd31d1417ff02dbc5e32bc6f661265115b46590"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_EndedRent_Details), @"mvc.1.0.view", @"/Views/EndedRent/Details.cshtml")]
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
#line 1 "G:\Programowanie\C#\.net core\Projekt\Projekt\Views\_ViewImports.cshtml"
using Projekt;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\Programowanie\C#\.net core\Projekt\Projekt\Views\_ViewImports.cshtml"
using Projekt.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dbd31d1417ff02dbc5e32bc6f661265115b46590", @"/Views/EndedRent/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90ccb9a0a85e2b383b463914ff60e93aa736b684", @"/Views/_ViewImports.cshtml")]
    public class Views_EndedRent_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Projekt.Models.RentModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "G:\Programowanie\C#\.net core\Projekt\Projekt\Views\EndedRent\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Szczegóły wypożyczenia</h1>\r\n\r\n<div>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 13 "G:\Programowanie\C#\.net core\Projekt\Projekt\Views\EndedRent\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Customer.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 16 "G:\Programowanie\C#\.net core\Projekt\Projekt\Views\EndedRent\Details.cshtml"
       Write(Html.DisplayFor(model => model.Customer.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 19 "G:\Programowanie\C#\.net core\Projekt\Projekt\Views\EndedRent\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Customer.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 22 "G:\Programowanie\C#\.net core\Projekt\Projekt\Views\EndedRent\Details.cshtml"
       Write(Html.DisplayFor(model => model.Customer.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 25 "G:\Programowanie\C#\.net core\Projekt\Projekt\Views\EndedRent\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Car.NumberPlate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 28 "G:\Programowanie\C#\.net core\Projekt\Projekt\Views\EndedRent\Details.cshtml"
       Write(Html.DisplayFor(model => model.Car.NumberPlate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 31 "G:\Programowanie\C#\.net core\Projekt\Projekt\Views\EndedRent\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Car.Brand));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 34 "G:\Programowanie\C#\.net core\Projekt\Projekt\Views\EndedRent\Details.cshtml"
       Write(Html.DisplayFor(model => model.Car.Brand));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 37 "G:\Programowanie\C#\.net core\Projekt\Projekt\Views\EndedRent\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Car.Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 40 "G:\Programowanie\C#\.net core\Projekt\Projekt\Views\EndedRent\Details.cshtml"
       Write(Html.DisplayFor(model => model.Car.Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 43 "G:\Programowanie\C#\.net core\Projekt\Projekt\Views\EndedRent\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.RentDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 46 "G:\Programowanie\C#\.net core\Projekt\Projekt\Views\EndedRent\Details.cshtml"
       Write(Html.DisplayFor(model => model.RentDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 49 "G:\Programowanie\C#\.net core\Projekt\Projekt\Views\EndedRent\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DeliveryDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 52 "G:\Programowanie\C#\.net core\Projekt\Projekt\Views\EndedRent\Details.cshtml"
       Write(Html.DisplayFor(model => model.DeliveryDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 55 "G:\Programowanie\C#\.net core\Projekt\Projekt\Views\EndedRent\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Cost));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 58 "G:\Programowanie\C#\.net core\Projekt\Projekt\Views\EndedRent\Details.cshtml"
       Write(Html.DisplayFor(model => model.Cost));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 61 "G:\Programowanie\C#\.net core\Projekt\Projekt\Views\EndedRent\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Ended));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 64 "G:\Programowanie\C#\.net core\Projekt\Projekt\Views\EndedRent\Details.cshtml"
       Write(Html.DisplayFor(model => model.Ended));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dbd31d1417ff02dbc5e32bc6f661265115b465909486", async() => {
                WriteLiteral("Powrót");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Projekt.Models.RentModel> Html { get; private set; }
    }
}
#pragma warning restore 1591