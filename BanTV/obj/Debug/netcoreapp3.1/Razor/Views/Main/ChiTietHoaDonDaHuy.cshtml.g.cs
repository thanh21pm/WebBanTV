#pragma checksum "E:\DoanthuctapBanTV\BanTV\BanTV\Views\Main\ChiTietHoaDonDaHuy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c71234a62480ede2cd0a3a98cb525cd7dc8cd7c5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Main_ChiTietHoaDonDaHuy), @"mvc.1.0.view", @"/Views/Main/ChiTietHoaDonDaHuy.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c71234a62480ede2cd0a3a98cb525cd7dc8cd7c5", @"/Views/Main/ChiTietHoaDonDaHuy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5060917ffb4f25a7036e0102b1cc36904af80b5e", @"/Views/_ViewImports.cshtml")]
    public class Views_Main_ChiTietHoaDonDaHuy : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BanTV.Models.HoaDon>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("150"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\DoanthuctapBanTV\BanTV\BanTV\Views\Main\ChiTietHoaDonDaHuy.cshtml"
  
    ViewData["Title"] = "Chi tiết hóa đơn";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<br />
<br />
<br />
<br />
<h4>Chi tiết hóa đơn</h4>
<hr />
<div class=""row"">
    <!--Thông tin hóa đơn-->
    <div class=""col-md"">
        <h5>Thông tin hóa đơn</h5>
        <dl class=""row"">
            <dt class=""col-sm-3"">
                Mã hóa đơn
            </dt>
            <dd class=""col-sm-9"">
                ");
#nullable restore
#line 20 "E:\DoanthuctapBanTV\BanTV\BanTV\Views\Main\ChiTietHoaDonDaHuy.cshtml"
           Write(Model.Mahd);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-3\">\r\n                Ngày lập\r\n            </dt>\r\n            <dd class=\"col-sm-9\">\r\n                ");
#nullable restore
#line 26 "E:\DoanthuctapBanTV\BanTV\BanTV\Views\Main\ChiTietHoaDonDaHuy.cshtml"
           Write(Model.Ngay);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-3\">\r\n                Tổng tiền\r\n            </dt>\r\n            <dd class=\"col-sm-9\">\r\n                ");
#nullable restore
#line 32 "E:\DoanthuctapBanTV\BanTV\BanTV\Views\Main\ChiTietHoaDonDaHuy.cshtml"
           Write(Model.Tongtien);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </dd>
        </dl>
    </div>

    <!--Thông tin khách hàng-->
    <div class=""col-md"">
        <h5>Thông tin khách hàng</h5>
        <dl class=""row"">
            <dt class=""col-sm-3"">
                Mã khách hàng
            </dt>
            <dd class=""col-sm-9"">
                ");
#nullable restore
#line 45 "E:\DoanthuctapBanTV\BanTV\BanTV\Views\Main\ChiTietHoaDonDaHuy.cshtml"
           Write(Model.Makh);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-3\">\r\n                Tên\r\n            </dt>\r\n            <dd class=\"col-sm-9\">\r\n                ");
#nullable restore
#line 51 "E:\DoanthuctapBanTV\BanTV\BanTV\Views\Main\ChiTietHoaDonDaHuy.cshtml"
           Write(Model.MakhNavigation.Ten);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-3\">\r\n                Điện thoại\r\n            </dt>\r\n            <dd class=\"col-sm-9\">\r\n                ");
#nullable restore
#line 57 "E:\DoanthuctapBanTV\BanTV\BanTV\Views\Main\ChiTietHoaDonDaHuy.cshtml"
           Write(Model.MakhNavigation.Dienthoai);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-3\">\r\n                Email\r\n            </dt>\r\n            <dd class=\"col-sm-9\">\r\n                ");
#nullable restore
#line 63 "E:\DoanthuctapBanTV\BanTV\BanTV\Views\Main\ChiTietHoaDonDaHuy.cshtml"
           Write(Model.MakhNavigation.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-3\">\r\n                Địa chỉ\r\n            </dt>\r\n            <dd class=\"col-sm-9\">\r\n");
#nullable restore
#line 69 "E:\DoanthuctapBanTV\BanTV\BanTV\Views\Main\ChiTietHoaDonDaHuy.cshtml"
                  
                    string diachi = Model.MadcNavigation.Diachi1 + ", " + Model.MadcNavigation.Phuongxa + ", " + Model.MadcNavigation.Quanhuyen + ", " + Model.MadcNavigation.Tinhthanh;

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <label>");
#nullable restore
#line 71 "E:\DoanthuctapBanTV\BanTV\BanTV\Views\Main\ChiTietHoaDonDaHuy.cshtml"
                      Write(diachi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n");
            WriteLiteral(@"            </dd>
        </dl>
    </div>
</div>

<hr />

<h5>Thông tin sản phẩm</h5>
<table class=""table"">
    <thead>
        <tr>
            <th>STT</th>
            <th>Mã mặt hàng</th>
            <th>Tên</th>
            <th>Hình</th>
            <th>Đơn giá</th>
            <th>Số lượng</th>
            <th>Thành tiền</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 94 "E:\DoanthuctapBanTV\BanTV\BanTV\Views\Main\ChiTietHoaDonDaHuy.cshtml"
         foreach (CthoaDon c in ViewBag.chittiethoadon)
        {
            int stt = 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 98 "E:\DoanthuctapBanTV\BanTV\BanTV\Views\Main\ChiTietHoaDonDaHuy.cshtml"
               Write(stt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 99 "E:\DoanthuctapBanTV\BanTV\BanTV\Views\Main\ChiTietHoaDonDaHuy.cshtml"
               Write(c.Mamh);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 100 "E:\DoanthuctapBanTV\BanTV\BanTV\Views\Main\ChiTietHoaDonDaHuy.cshtml"
               Write(c.MamhNavigation.Ten);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c71234a62480ede2cd0a3a98cb525cd7dc8cd7c58939", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2679, "~/images/images/", 2679, 16, true);
#nullable restore
#line 101 "E:\DoanthuctapBanTV\BanTV\BanTV\Views\Main\ChiTietHoaDonDaHuy.cshtml"
AddHtmlAttributeValue("", 2695, c.MamhNavigation.Hinhanh, 2695, 25, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 102 "E:\DoanthuctapBanTV\BanTV\BanTV\Views\Main\ChiTietHoaDonDaHuy.cshtml"
               Write(c.Dongia.ToString("n0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" đ</td>\r\n                <td>");
#nullable restore
#line 103 "E:\DoanthuctapBanTV\BanTV\BanTV\Views\Main\ChiTietHoaDonDaHuy.cshtml"
               Write(c.Soluong);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 104 "E:\DoanthuctapBanTV\BanTV\BanTV\Views\Main\ChiTietHoaDonDaHuy.cshtml"
               Write(c.Thanhtien.ToString("n0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" đ</td>\r\n            </tr>\r\n");
#nullable restore
#line 106 "E:\DoanthuctapBanTV\BanTV\BanTV\Views\Main\ChiTietHoaDonDaHuy.cshtml"
            stt++;
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n<br />\r\n<br />\r\n<br />\r\n<br />\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BanTV.Models.HoaDon> Html { get; private set; }
    }
}
#pragma warning restore 1591
