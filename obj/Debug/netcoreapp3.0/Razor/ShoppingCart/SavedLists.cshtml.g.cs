#pragma checksum "E:\Cibernetics Core\3er Año\+IS+\TrendyShop\TrendyShop\ShoppingCart\SavedLists.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a6a72ce885340522ccdf1cea6678315570ce765"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.ShoppingCart_SavedLists), @"mvc.1.0.view", @"/ShoppingCart/SavedLists.cshtml")]
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
#line 1 "E:\Cibernetics Core\3er Año\+IS+\TrendyShop\TrendyShop\ShoppingCart\SavedLists.cshtml"
using TrendyShop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a6a72ce885340522ccdf1cea6678315570ce765", @"/ShoppingCart/SavedLists.cshtml")]
    public class ShoppingCart_SavedLists : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TrendyShop.Models.ShoppingList>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\Cibernetics Core\3er Año\+IS+\TrendyShop\TrendyShop\ShoppingCart\SavedLists.cshtml"
  
    ViewData["Title"] = "SavedLists";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"

<nav class=""navbar fixed-top navbar-expand-lg navbar-dark bg-dark fixed-top"">
    <div class=""container"">
        <a class=""navbar-brand"" href=""/"">Inicio</a>
        <button class=""navbar-toggler navbar-toggler-right"" type=""button"" data-toggle=""collapse"" data-target=""#navbarResponsive"" aria-controls=""navbarResponsive"" aria-expanded=""false"" aria-label=""Toggle navigation"">
            <span class=""navbar-toggler-icon""></span>
        </button>
        <div class=""collapse navbar-collapse"" id=""navbarResponsive"">
            <ul class=""navbar-nav ml-auto"">

                <li class=""nav-item dropdown"">
                    <a class=""nav-link dropdown-toggle"" href=""#"" id=""navbarDropdownPortfolio"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                        Anuncios
                    </a>
                    <div class=""dropdown-menu dropdown-menu-right"" aria-labelledby=""navbarDropdownPortfolio"">
                        <a class=""dropdown-item"" href=""/Add/NewAdd"">An");
            WriteLiteral(@"unciar</a>
                        <a class=""dropdown-item"" href=""/Add"">Lista de Anuncios</a>
                    </div>
                </li>

                <li class=""nav-item"">
                    <a class=""nav-link"" href=""/ShoppingCart/Index"">Carrito de Compra</a>
                </li>


                <li class=""nav-item dropdown"">
                    <a class=""nav-link dropdown-toggle"" href=""#"" id=""navbarDropdownPortfolio"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                        Subasta
                    </a>
                    <div class=""dropdown-menu dropdown-menu-right"" aria-labelledby=""navbarDropdownPortfolio"">
                        <a class=""dropdown-item"" href=""/Auction/NewAuction"">Nueva Subasta</a>
                        <a class=""dropdown-item"" href=""/Auction"">Lista de Subastas</a>
                    </div>
                </li>

                <li class=""nav-item"">
                    <a class=""nav-link"" href=""/Home/About"">Acerc");
            WriteLiteral(@"a de</a>
                </li>
                <li class=""nav-item"">
                    <a class=""nav-link"" href=""/Home/Contact"">Contáctanos</a>
                </li>

                <li class=""nav-item dropdown"">
                    <a class=""nav-link dropdown-toggle"" href=""#"" id=""navbarDropdownPortfolio"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                        Usuario
                    </a>
                    <div class=""dropdown-menu dropdown-menu-right"" aria-labelledby=""navbarDropdownPortfolio"">
                        <a class=""dropdown-item"" href=""/User/Login"">Entrar</a>
                        <a class=""dropdown-item"" href=""/Home/Register"">Registrar</a>
                    </div>
                </li>

            </ul>
        </div>
    </div>
</nav>



<h1>Listas de Compra</h1>

<div>
    <table class=""table-striped"" style=""margin-left:auto;margin-right:auto"" width=""40%"">
        <tr>
            <th>Nombre</th>
            <th></th");
            WriteLiteral(">\r\n            <th></th>\r\n            <th></th>\r\n\r\n\r\n\r\n        </tr>\r\n\r\n");
#nullable restore
#line 82 "E:\Cibernetics Core\3er Año\+IS+\TrendyShop\TrendyShop\ShoppingCart\SavedLists.cshtml"
         foreach (var art in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 85 "E:\Cibernetics Core\3er Año\+IS+\TrendyShop\TrendyShop\ShoppingCart\SavedLists.cshtml"
               Write(art.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 86 "E:\Cibernetics Core\3er Año\+IS+\TrendyShop\TrendyShop\ShoppingCart\SavedLists.cshtml"
               Write(Html.ActionLink("Cargar", "LoadShoppingList", "ShoppingCart", new { sid = art.ShoppingListId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 87 "E:\Cibernetics Core\3er Año\+IS+\TrendyShop\TrendyShop\ShoppingCart\SavedLists.cshtml"
               Write(Html.ActionLink("Eliminar", "DeleteShoppingList", "ShoppingCart", new { sid = art.ShoppingListId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 88 "E:\Cibernetics Core\3er Año\+IS+\TrendyShop\TrendyShop\ShoppingCart\SavedLists.cshtml"
               Write(Html.ActionLink("Detalles", "Details", "ShoppingCart", new { sid = art.ShoppingListId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n            </tr>\r\n");
#nullable restore
#line 91 "E:\Cibernetics Core\3er Año\+IS+\TrendyShop\TrendyShop\ShoppingCart\SavedLists.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TrendyShop.Models.ShoppingList>> Html { get; private set; }
    }
}
#pragma warning restore 1591