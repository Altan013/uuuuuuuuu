#pragma checksum "C:\Users\lenovo\Desktop\uuuuuuuuu\WebApplication1\WebApplication1\Areas\Manage\Views\User\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8ef0622f6b2b039957bb8b54af60e044b0d5e159"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Manage_Views_User_Detail), @"mvc.1.0.view", @"/Areas/Manage/Views/User/Detail.cshtml")]
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
#line 1 "C:\Users\lenovo\Desktop\uuuuuuuuu\WebApplication1\WebApplication1\Areas\Manage\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lenovo\Desktop\uuuuuuuuu\WebApplication1\WebApplication1\Areas\Manage\Views\_ViewImports.cshtml"
using WebApplication1.ViewModels.Account;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ef0622f6b2b039957bb8b54af60e044b0d5e159", @"/Areas/Manage/Views/User/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fcc10cd0f73f379446081c0924c8a53057b07251", @"/Areas/Manage/Views/_ViewImports.cshtml")]
    public class Areas_Manage_Views_User_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AppUser>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\lenovo\Desktop\uuuuuuuuu\WebApplication1\WebApplication1\Areas\Manage\Views\User\Detail.cshtml"
  
    int orderCount = 0;
    int orderItemCount = 0;
    double totalOrderItem = 0;
    foreach (var item in Model.Orders)
    {
        foreach (var item1 in item.OrderItems)
        {
            totalOrderItem = item1.TotalPrice;
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""page-wrapper"">
    <!-- ============================================================== -->
    <div class=""page-breadcrumb"">
        <div class=""row align-items-center"">
            <div class=""col-md-6 col-8 align-self-center"">
                <h3 class=""page-title mb-0 p-0"">Blank Page</h3>
                <div class=""d-flex align-items-center"">
                    <nav aria-label=""breadcrumb"">
                        <ol class=""breadcrumb"">
                            <li class=""breadcrumb-item""><a href=""#"">Home</a></li>
                            <li class=""breadcrumb-item active"" aria-current=""page"">Blank Page</li>
                        </ol>
                    </nav>
                </div>
            </div>
            <div class=""col-md-6 col-4 align-self-center"">
                <div class=""text-end upgrade-btn"">
                    <ul class=""dropdown-menu"" aria-labelledby=""navbarDropdown""></ul>
                </div>
            </div>
        </div>
    </div>
");
            WriteLiteral(@"    <!-- ============================================================== -->
    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""col-12"">
                <div class=""card"">
                    <div class=""card-body"">
                        <table class=""table table-striped"">
                            <thead>
                                <tr>
                                    <th scope=""col"">Name</th>
                                    <th scope=""col"">UserName</th>
                                    <th scope=""col"">Emal</th>
                                    <th scope=""col"">Phone</th>
                                    <th scope=""col"">Address</th>
                                    <th scope=""col"">Country</th>
                                    <th scope=""col"">City</th>
                                    <th scope=""col"">State</th>
                                    <th scope=""col"">Zip Code</th>
                                </tr>
            ");
            WriteLiteral("                </thead>\r\n                            <tbody>\r\n                                <tr>\r\n                                    <td>");
#nullable restore
#line 58 "C:\Users\lenovo\Desktop\uuuuuuuuu\WebApplication1\WebApplication1\Areas\Manage\Views\User\Detail.cshtml"
                                   Write(Model.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 59 "C:\Users\lenovo\Desktop\uuuuuuuuu\WebApplication1\WebApplication1\Areas\Manage\Views\User\Detail.cshtml"
                                   Write(Model.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 60 "C:\Users\lenovo\Desktop\uuuuuuuuu\WebApplication1\WebApplication1\Areas\Manage\Views\User\Detail.cshtml"
                                   Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 61 "C:\Users\lenovo\Desktop\uuuuuuuuu\WebApplication1\WebApplication1\Areas\Manage\Views\User\Detail.cshtml"
                                   Write(Model.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 62 "C:\Users\lenovo\Desktop\uuuuuuuuu\WebApplication1\WebApplication1\Areas\Manage\Views\User\Detail.cshtml"
                                   Write(Model.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 63 "C:\Users\lenovo\Desktop\uuuuuuuuu\WebApplication1\WebApplication1\Areas\Manage\Views\User\Detail.cshtml"
                                   Write(Model.Country);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 64 "C:\Users\lenovo\Desktop\uuuuuuuuu\WebApplication1\WebApplication1\Areas\Manage\Views\User\Detail.cshtml"
                                   Write(Model.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 65 "C:\Users\lenovo\Desktop\uuuuuuuuu\WebApplication1\WebApplication1\Areas\Manage\Views\User\Detail.cshtml"
                                   Write(Model.State);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 66 "C:\Users\lenovo\Desktop\uuuuuuuuu\WebApplication1\WebApplication1\Areas\Manage\Views\User\Detail.cshtml"
                                   Write(Model.ZipCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                </tr>\r\n                            </tbody>\r\n                        </table>\r\n                        <div class=\"orders myaccount-table table-responsive text-center\">\r\n");
#nullable restore
#line 71 "C:\Users\lenovo\Desktop\uuuuuuuuu\WebApplication1\WebApplication1\Areas\Manage\Views\User\Detail.cshtml"
                             if (Model.Orders.Count() > 0)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <table class=""table table-bordered"">
                                    <thead class=""thead-light"">
                                        <tr>
                                            <th>Order</th>
                                            <th>User</th>
                                            <th>Product Count</th>
                                            <th>Total</th>
                                            <th>Date</th>
                                            <th>Status</th>
                                        </tr>
                                    </thead>
                                    <tbody>
");
#nullable restore
#line 85 "C:\Users\lenovo\Desktop\uuuuuuuuu\WebApplication1\WebApplication1\Areas\Manage\Views\User\Detail.cshtml"
                                         foreach (var item in Model.Orders)
                                        {
                                            orderCount++;
                                            orderItemCount = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <tr data-toggle=\"collapse\" data-target=\"#demo");
#nullable restore
#line 89 "C:\Users\lenovo\Desktop\uuuuuuuuu\WebApplication1\WebApplication1\Areas\Manage\Views\User\Detail.cshtml"
                                                                                     Write(orderCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"accordion-toggle\">\r\n                                                <td>");
#nullable restore
#line 90 "C:\Users\lenovo\Desktop\uuuuuuuuu\WebApplication1\WebApplication1\Areas\Manage\Views\User\Detail.cshtml"
                                               Write(orderCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td>");
#nullable restore
#line 91 "C:\Users\lenovo\Desktop\uuuuuuuuu\WebApplication1\WebApplication1\Areas\Manage\Views\User\Detail.cshtml"
                                               Write(item.AppUser.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td>");
#nullable restore
#line 92 "C:\Users\lenovo\Desktop\uuuuuuuuu\WebApplication1\WebApplication1\Areas\Manage\Views\User\Detail.cshtml"
                                               Write(item.OrderItems.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td>");
#nullable restore
#line 93 "C:\Users\lenovo\Desktop\uuuuuuuuu\WebApplication1\WebApplication1\Areas\Manage\Views\User\Detail.cshtml"
                                               Write(item.OrderItems.Sum(o => o.TotalPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td>");
#nullable restore
#line 94 "C:\Users\lenovo\Desktop\uuuuuuuuu\WebApplication1\WebApplication1\Areas\Manage\Views\User\Detail.cshtml"
                                               Write(item.CreatedAt?.ToString("MMMM dd, yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td>");
#nullable restore
#line 95 "C:\Users\lenovo\Desktop\uuuuuuuuu\WebApplication1\WebApplication1\Areas\Manage\Views\User\Detail.cshtml"
                                               Write(item.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                                            </tr>
                                            <tr>
                                                <td colspan=""12"" class=""hiddenRow"">
                                                    <div class=""accordian-body collapse""");
            BeginWriteAttribute("id", " id=\"", 5110, "\"", 5132, 2);
            WriteAttributeValue("", 5115, "demo", 5115, 4, true);
#nullable restore
#line 99 "C:\Users\lenovo\Desktop\uuuuuuuuu\WebApplication1\WebApplication1\Areas\Manage\Views\User\Detail.cshtml"
WriteAttributeValue("", 5119, orderCount, 5119, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                                        <table class=""table table-striped"">
                                                            <thead>
                                                                <tr class=""info"">
                                                                    <th>#</th>
                                                                    <th>Product Name</th>
                                                                    <th>Count</th>
                                                                    <th>Price</th>
                                                                    <th>Total Price</th>
                                                                </tr>
                                                            </thead>
                                                            <tbody>
");
#nullable restore
#line 111 "C:\Users\lenovo\Desktop\uuuuuuuuu\WebApplication1\WebApplication1\Areas\Manage\Views\User\Detail.cshtml"
                                                                 foreach (var orderItem in item.OrderItems)
                                                                {
                                                                    orderItemCount++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                    <tr data-toggle=\"collapse\" class=\"accordion-toggle\">\r\n                                                                        <td>");
#nullable restore
#line 115 "C:\Users\lenovo\Desktop\uuuuuuuuu\WebApplication1\WebApplication1\Areas\Manage\Views\User\Detail.cshtml"
                                                                       Write(orderItemCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                                        <td>");
#nullable restore
#line 116 "C:\Users\lenovo\Desktop\uuuuuuuuu\WebApplication1\WebApplication1\Areas\Manage\Views\User\Detail.cshtml"
                                                                       Write(orderItem.Product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                                        <td>");
#nullable restore
#line 117 "C:\Users\lenovo\Desktop\uuuuuuuuu\WebApplication1\WebApplication1\Areas\Manage\Views\User\Detail.cshtml"
                                                                       Write(orderItem.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                                        <td>");
#nullable restore
#line 118 "C:\Users\lenovo\Desktop\uuuuuuuuu\WebApplication1\WebApplication1\Areas\Manage\Views\User\Detail.cshtml"
                                                                       Write(orderItem.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                                        <td>");
#nullable restore
#line 119 "C:\Users\lenovo\Desktop\uuuuuuuuu\WebApplication1\WebApplication1\Areas\Manage\Views\User\Detail.cshtml"
                                                                       Write(orderItem.TotalPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                                    </tr>\r\n");
#nullable restore
#line 121 "C:\Users\lenovo\Desktop\uuuuuuuuu\WebApplication1\WebApplication1\Areas\Manage\Views\User\Detail.cshtml"
                                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                            </tbody>
                                                        </table>
                                                    </div>
                                                </td>
                                            </tr>
");
#nullable restore
#line 127 "C:\Users\lenovo\Desktop\uuuuuuuuu\WebApplication1\WebApplication1\Areas\Manage\Views\User\Detail.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </tbody>\r\n                                </table>\r\n");
#nullable restore
#line 130 "C:\Users\lenovo\Desktop\uuuuuuuuu\WebApplication1\WebApplication1\Areas\Manage\Views\User\Detail.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                    </div>\r\n                </div>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8ef0622f6b2b039957bb8b54af60e044b0d5e15919371", async() => {
                WriteLiteral("Go to Users List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
        </div>
    </div>
    <!-- ============================================================== -->
    <footer class=""footer text-center"">
        © 2021 Monster Admin by <a href=""https://www.wrappixel.com/"">wrappixel.com</a>
    </footer>
    <!-- ============================================================== -->
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AppUser> Html { get; private set; }
    }
}
#pragma warning restore 1591
