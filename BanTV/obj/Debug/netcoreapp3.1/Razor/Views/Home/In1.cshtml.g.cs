#pragma checksum "E:\DoanthuctapBanTV\BanTV\BanTV\Views\Home\In1.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "32d29734b38538619a52daaf025e9d82503897a0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_In1), @"mvc.1.0.view", @"/Views/Home/In1.cshtml")]
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
#line 1 "E:\DoanthuctapBanTV\BanTV\BanTV\Views\_ViewImports.cshtml"
using BanTV;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\DoanthuctapBanTV\BanTV\BanTV\Views\_ViewImports.cshtml"
using BanTV.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32d29734b38538619a52daaf025e9d82503897a0", @"/Views/Home/In1.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5060917ffb4f25a7036e0102b1cc36904af80b5e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_In1 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BanTV.Models.MatHang>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("..."), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-decoration-none"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-info mt-auto"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddToCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\DoanthuctapBanTV\BanTV\BanTV\Views\Home\In1.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h3 class=\"text-danger p-5\">Tất cả sản phẩm từ 6-10 triệu</h3>\r\n<div class=\"row gx-4 gx-lg-5 row-cols-2 row-cols-md-3 row-cols-xl-4 justify-content-center\">\r\n");
#nullable restore
#line 8 "E:\DoanthuctapBanTV\BanTV\BanTV\Views\Home\In1.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col mb-5\">\r\n            <div class=\"card h-100\">\r\n                <!-- Sale badge-->\r\n");
#nullable restore
#line 13 "E:\DoanthuctapBanTV\BanTV\BanTV\Views\Home\In1.cshtml"
                 if (int.Parse(item.Giagoc.ToString()) > int.Parse(item.Giaban.ToString()))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"badge bg-danger text-white position-absolute\" style=\"top: 0.5rem; right: 0.5rem\">Giảm giá</div>");
#nullable restore
#line 15 "E:\DoanthuctapBanTV\BanTV\BanTV\Views\Home\In1.cshtml"
                                                                                                                               }

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "E:\DoanthuctapBanTV\BanTV\BanTV\Views\Home\In1.cshtml"
                 if (int.Parse(item.hot.ToString()) == 1)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"badge bg-danger text-white position-absolute\" style=\"top: 0.5rem; left: 0.5rem\">HOT</div>");
#nullable restore
#line 18 "E:\DoanthuctapBanTV\BanTV\BanTV\Views\Home\In1.cshtml"
                                                                                                                         }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <!-- Product image-->\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "32d29734b38538619a52daaf025e9d82503897a07547", async() => {
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "32d29734b38538619a52daaf025e9d82503897a07822", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1049, "~/images/images/", 1049, 16, true);
#nullable restore
#line 22 "E:\DoanthuctapBanTV\BanTV\BanTV\Views\Home\In1.cshtml"
AddHtmlAttributeValue("", 1065, Html.DisplayFor(modelItem => item.Hinhanh), 1065, 43, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 21 "E:\DoanthuctapBanTV\BanTV\BanTV\Views\Home\In1.cshtml"
                                                                                             WriteLiteral(item.Mamh);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                <div class=\"badge text-dark position-absolute\" style=\"bottom: 1.5rem; left: 0.5rem\"><i class=\"fa fa-eye \"></i>  ");
#nullable restore
#line 24 "E:\DoanthuctapBanTV\BanTV\BanTV\Views\Home\In1.cshtml"
                                                                                                                           Write(Html.DisplayFor(modelItem => item.luotxem));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n\r\n                <!-- Product details-->\r\n                <div class=\"card-body p-4\">\r\n                    <div class=\"text-center\">\r\n                        <!-- Product name-->\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "32d29734b38538619a52daaf025e9d82503897a012488", async() => {
                WriteLiteral("\r\n                            <h5 class=\"fw-bolder text-dark\">");
#nullable restore
#line 32 "E:\DoanthuctapBanTV\BanTV\BanTV\Views\Home\In1.cshtml"
                                                       Write(Html.DisplayFor(modelItem => item.Ten));

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 31 "E:\DoanthuctapBanTV\BanTV\BanTV\Views\Home\In1.cshtml"
                                                                                                     WriteLiteral(item.Mamh);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

                        <div class=""d-flex justify-content-center small text-warning mb-2"">
                            <div class=""bi-star-fill""></div>
                            <div class=""bi-star-fill""></div>
                            <div class=""bi-star-fill""></div>
                            <div class=""bi-star-fill""></div>
                            <div class=""bi-star-fill""></div>
                        </div>

                        <!-- Product price-->
");
#nullable restore
#line 44 "E:\DoanthuctapBanTV\BanTV\BanTV\Views\Home\In1.cshtml"
                         if (int.Parse(item.Giagoc.ToString()) == int.Parse(item.Giaban.ToString()))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span class=\"text-danger fw-bolder\">");
#nullable restore
#line 46 "E:\DoanthuctapBanTV\BanTV\BanTV\Views\Home\In1.cshtml"
                                                           Write(Html.DisplayFor(modelItem => item.Giaban));

#line default
#line hidden
#nullable disable
            WriteLiteral("đ</span> ");
#nullable restore
#line 46 "E:\DoanthuctapBanTV\BanTV\BanTV\Views\Home\In1.cshtml"
                                                                                                                   }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span class=\"text-muted text-decoration-line-through\">");
#nullable restore
#line 49 "E:\DoanthuctapBanTV\BanTV\BanTV\Views\Home\In1.cshtml"
                                                                             Write(Html.DisplayFor(modelItem => item.Giagoc));

#line default
#line hidden
#nullable disable
            WriteLiteral("đ</span>\r\n                            <span class=\"text-danger fw-bolder\">");
#nullable restore
#line 50 "E:\DoanthuctapBanTV\BanTV\BanTV\Views\Home\In1.cshtml"
                                                           Write(Html.DisplayFor(modelItem => item.Giaban));

#line default
#line hidden
#nullable disable
            WriteLiteral("đ</span>");
#nullable restore
#line 50 "E:\DoanthuctapBanTV\BanTV\BanTV\Views\Home\In1.cshtml"
                                                                                                                  }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div>\r\n                <!-- Product actions-->\r\n                <div class=\"card-footer p-4 pt-0 border-top-0 bg-transparent\">\r\n                    <div class=\"text-center\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "32d29734b38538619a52daaf025e9d82503897a018068", async() => {
                WriteLiteral("Chọn mua");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 55 "E:\DoanthuctapBanTV\BanTV\BanTV\Views\Home\In1.cshtml"
                                                                                                              WriteLiteral(item.Mamh);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</div>\r\n                </div>\r\n                <div class=\"badge text-dark position-absolute\" style=\"bottom: 0.5rem; left: 0.5rem\"><i class=\"fa fa-shopping-cart\"></i> ");
#nullable restore
#line 57 "E:\DoanthuctapBanTV\BanTV\BanTV\Views\Home\In1.cshtml"
                                                                                                                                   Write(Html.DisplayFor(modelItem => item.luotmua));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n            </div>\r\n        </div>");
#nullable restore
#line 60 "E:\DoanthuctapBanTV\BanTV\BanTV\Views\Home\In1.cshtml"
              }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BanTV.Models.MatHang>> Html { get; private set; }
    }
}
#pragma warning restore 1591
