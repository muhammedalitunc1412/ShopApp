#pragma checksum "C:\Users\ASUS\Desktop\Projelerim\ShopApp\ShopApp.WEBUI\Views\Shop\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a17e096bdb15f6b8506b13385f829334e3e757c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shop_List), @"mvc.1.0.view", @"/Views/Shop/List.cshtml")]
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
#line 1 "C:\Users\ASUS\Desktop\Projelerim\ShopApp\ShopApp.WEBUI\Views\_ViewImports.cshtml"
using ShopApp.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ASUS\Desktop\Projelerim\ShopApp\ShopApp.WEBUI\Views\_ViewImports.cshtml"
using ShopApp.WEBUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ASUS\Desktop\Projelerim\ShopApp\ShopApp.WEBUI\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ASUS\Desktop\Projelerim\ShopApp\ShopApp.WEBUI\Views\_ViewImports.cshtml"
using ShopApp.WEBUI.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ASUS\Desktop\Projelerim\ShopApp\ShopApp.WEBUI\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ASUS\Desktop\Projelerim\ShopApp\ShopApp.WEBUI\Views\_ViewImports.cshtml"
using ShopApp.WEBUI.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a17e096bdb15f6b8506b13385f829334e3e757c", @"/Views/Shop/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c03beef1eab73c8d25fbd5da42e4b4423e84a74", @"/Views/_ViewImports.cshtml")]
    public class Views_Shop_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShopApp.WEBUI.Models.ProductListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ASUS\Desktop\Projelerim\ShopApp\ShopApp.WEBUI\Views\Shop\List.cshtml"
  
    ViewData["Title"] = "List";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-3\">\r\n        ");
#nullable restore
#line 8 "C:\Users\ASUS\Desktop\Projelerim\ShopApp\ShopApp.WEBUI\Views\Shop\List.cshtml"
   Write(await Component.InvokeAsync("Categories"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 9 "C:\Users\ASUS\Desktop\Projelerim\ShopApp\ShopApp.WEBUI\Views\Shop\List.cshtml"
   Write(await Html.PartialAsync("_search"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    </div>\r\n    <div class=\"col-md-9\">\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 14 "C:\Users\ASUS\Desktop\Projelerim\ShopApp\ShopApp.WEBUI\Views\Shop\List.cshtml"
             foreach (var product in Model.Products)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-4\">\r\n                    ");
#nullable restore
#line 17 "C:\Users\ASUS\Desktop\Projelerim\ShopApp\ShopApp.WEBUI\Views\Shop\List.cshtml"
               Write(await Html.PartialAsync("_showproduct", product));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n");
#nullable restore
#line 19 "C:\Users\ASUS\Desktop\Projelerim\ShopApp\ShopApp.WEBUI\Views\Shop\List.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\ASUS\Desktop\Projelerim\ShopApp\ShopApp.WEBUI\Views\Shop\List.cshtml"
             if (Model.Products.Count == 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-12\">\r\n                    <div class=\"alert alert-danger\">\r\n                        Ürün Yok :(\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 27 "C:\Users\ASUS\Desktop\Projelerim\ShopApp\ShopApp.WEBUI\Views\Shop\List.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>          <div class=\"row\">\r\n            <div class=\"col\">\r\n                <nav aria-label=\"Page navigation example\">\r\n                    <ul class=\"pagination\">\r\n\r\n");
#nullable restore
#line 33 "C:\Users\ASUS\Desktop\Projelerim\ShopApp\ShopApp.WEBUI\Views\Shop\List.cshtml"
                         for (int i = 0; i < Model.PageInfo.TotalPages(); i++)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\ASUS\Desktop\Projelerim\ShopApp\ShopApp.WEBUI\Views\Shop\List.cshtml"
                             if (String.IsNullOrEmpty(Model.PageInfo.CurrentCategory))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li");
            BeginWriteAttribute("class", " class=\"", 1225, "\"", 1289, 2);
            WriteAttributeValue("", 1233, "page-item", 1233, 9, true);
#nullable restore
#line 37 "C:\Users\ASUS\Desktop\Projelerim\ShopApp\ShopApp.WEBUI\Views\Shop\List.cshtml"
WriteAttributeValue(" ", 1242, Model.PageInfo.CurrentPage==i+1?"active":"", 1243, 46, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 1349, "\"", 1377, 2);
            WriteAttributeValue("", 1356, "/products?page=", 1356, 15, true);
#nullable restore
#line 38 "C:\Users\ASUS\Desktop\Projelerim\ShopApp\ShopApp.WEBUI\Views\Shop\List.cshtml"
WriteAttributeValue("", 1371, i+1, 1371, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        ");
#nullable restore
#line 39 "C:\Users\ASUS\Desktop\Projelerim\ShopApp\ShopApp.WEBUI\Views\Shop\List.cshtml"
                                    Write(i+1);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </a>\r\n                                </li>\r\n");
#nullable restore
#line 42 "C:\Users\ASUS\Desktop\Projelerim\ShopApp\ShopApp.WEBUI\Views\Shop\List.cshtml"

                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li");
            BeginWriteAttribute("class", " class=\"", 1643, "\"", 1707, 2);
            WriteAttributeValue("", 1651, "page-item", 1651, 9, true);
#nullable restore
#line 46 "C:\Users\ASUS\Desktop\Projelerim\ShopApp\ShopApp.WEBUI\Views\Shop\List.cshtml"
WriteAttributeValue(" ", 1660, Model.PageInfo.CurrentPage==i+1?"active":"", 1661, 46, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 1767, "\"", 1827, 4);
            WriteAttributeValue("", 1774, "/products/", 1774, 10, true);
#nullable restore
#line 47 "C:\Users\ASUS\Desktop\Projelerim\ShopApp\ShopApp.WEBUI\Views\Shop\List.cshtml"
WriteAttributeValue("", 1784, Model.PageInfo.CurrentCategory, 1784, 31, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1815, "?page=", 1815, 6, true);
#nullable restore
#line 47 "C:\Users\ASUS\Desktop\Projelerim\ShopApp\ShopApp.WEBUI\Views\Shop\List.cshtml"
WriteAttributeValue("", 1821, i+1, 1821, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        ");
#nullable restore
#line 48 "C:\Users\ASUS\Desktop\Projelerim\ShopApp\ShopApp.WEBUI\Views\Shop\List.cshtml"
                                    Write(i+1);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </a>\r\n                                </li>\r\n");
#nullable restore
#line 51 "C:\Users\ASUS\Desktop\Projelerim\ShopApp\ShopApp.WEBUI\Views\Shop\List.cshtml"

                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "C:\Users\ASUS\Desktop\Projelerim\ShopApp\ShopApp.WEBUI\Views\Shop\List.cshtml"
                             


                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                    </ul>\r\n                </nav>\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n    \r\n  \r\n</div>\r\n\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script src=""https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js"" integrity=""sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo"" crossorigin=""anonymous""></script>
    <script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js"" integrity=""sha384-wfSDF2E50Y2D1uUdj0O3uMBJnjuUD4Ih7YwaYd1iqfktj0Uod8GCExl3Og8ifwB6"" crossorigin=""anonymous""></script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShopApp.WEBUI.Models.ProductListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591