#pragma checksum "E:\Cibernetics Core\3er Año\+IS+\TrendyShop\TrendyShop\Views\User\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "becd93e0add45f3fd13b067e7d9c472660a5d51c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Details), @"mvc.1.0.view", @"/Views/User/Details.cshtml")]
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
#line 1 "E:\Cibernetics Core\3er Año\+IS+\TrendyShop\TrendyShop\Views\_ViewImports.cshtml"
using TrendyShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "E:\Cibernetics Core\3er Año\+IS+\TrendyShop\TrendyShop\Views\User\Details.cshtml"
using TrendyShop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"becd93e0add45f3fd13b067e7d9c472660a5d51c", @"/Views/User/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae704499564c51386f8cbc7db1f8d99c6833b460", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<User>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "becd93e0add45f3fd13b067e7d9c472660a5d51c3264", async() => {
                WriteLiteral("\r\n\r\n    <meta charset=\"utf-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1, shrink-to-fit=no\">\r\n    <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 236, "\"", 246, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n    <meta name=\"author\"");
                BeginWriteAttribute("content", " content=\"", 273, "\"", 283, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n\r\n    <title>Compra Venta (Perfil de Vendedor)</title>\r\n\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "becd93e0add45f3fd13b067e7d9c472660a5d51c4813", async() => {
                WriteLiteral(@"

    <!-- Page Content -->
    <div class=""container my-2"">

        <ol class=""breadcrumb"">
            <li class=""breadcrumb-item"">
                <a href=""/Home/Index"">Inicio</a>
            </li>
            <li class=""breadcrumb-item active"">");
#nullable restore
#line 28 "E:\Cibernetics Core\3er Año\+IS+\TrendyShop\TrendyShop\Views\User\Details.cshtml"
                                          Write(Model.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n        </ol>\r\n\r\n        <!-- Page Heading/Breadcrumbs -->\r\n        <h1 class=\"mt-4 mb-3 text-center\">");
#nullable restore
#line 32 "E:\Cibernetics Core\3er Año\+IS+\TrendyShop\TrendyShop\Views\User\Details.cshtml"
                                     Write(Model.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</h1>

        <!-- Content Row -->
        <div class=""row"">
            <!-- Sidebar Column -->
            <div class=""col-lg-3 mb-4"">
                <div class=""list-group"">
                    <img src=""/images/profile.jpg"" class=""list-group-item"" height=""255"" width=""255"">
                    <p class=""list-group-item"">Número de Ventas: ");
#nullable restore
#line 40 "E:\Cibernetics Core\3er Año\+IS+\TrendyShop\TrendyShop\Views\User\Details.cshtml"
                                                            Write(Model.TotalSales);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                    <p class=\"list-group-item\">Valoración(0-5): ");
#nullable restore
#line 41 "E:\Cibernetics Core\3er Año\+IS+\TrendyShop\TrendyShop\Views\User\Details.cshtml"
                                                           Write(Model.Rating);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                </div>\r\n            </div>\r\n\r\n            <h5 class=\"col-lg-9 text-center\">");
#nullable restore
#line 45 "E:\Cibernetics Core\3er Año\+IS+\TrendyShop\TrendyShop\Views\User\Details.cshtml"
                                        Write(Model.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n        </div>\r\n\r\n\r\n    </div>\r\n    <!-- /.container -->\r\n    <!-- Footer -->\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<User> Html { get; private set; }
    }
}
#pragma warning restore 1591
