#pragma checksum "C:\Users\Nur\Downloads\Deneme\vize-odevi-main (1)\vize-odevi-main\vize-odevi-main\Vize-Ödevi\Vize-Ödevi\Views\musteriler\Listele.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4e48fd1b84e638c78131e4e610c566e436252e9a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_musteriler_Listele), @"mvc.1.0.view", @"/Views/musteriler/Listele.cshtml")]
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
#line 1 "C:\Users\Nur\Downloads\Deneme\vize-odevi-main (1)\vize-odevi-main\vize-odevi-main\Vize-Ödevi\Vize-Ödevi\Views\_ViewImports.cshtml"
using Vize_Ödevi;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Nur\Downloads\Deneme\vize-odevi-main (1)\vize-odevi-main\vize-odevi-main\Vize-Ödevi\Vize-Ödevi\Views\_ViewImports.cshtml"
using Vize_Ödevi.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e48fd1b84e638c78131e4e610c566e436252e9a", @"/Views/musteriler/Listele.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf9dc9bcbd69dd772c94ed163ae9be9701a0c539", @"/Views/_ViewImports.cshtml")]
    public class Views_musteriler_Listele : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Vize_Ödevi.Models.Musteriler>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "yeni", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Nur\Downloads\Deneme\vize-odevi-main (1)\vize-odevi-main\vize-odevi-main\Vize-Ödevi\Vize-Ödevi\Views\musteriler\Listele.cshtml"
  
    ViewData["Title"] = "Listele";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Müşteri Listesi</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4e48fd1b84e638c78131e4e610c566e436252e9a3965", async() => {
                WriteLiteral("Yeni Kayıt");
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
            WriteLiteral(@"
</p>

<table class=""table"">
    <thead>
        <tr>
            <th>
               Müşteri ID
            </th>
            <th>
                Müşteri Adı 
            </th>
            <th>
                Müşteri Soyadı
            </th>
            <th>
                Müşteri Adres
            </th>
            <th>
                Müşteri Telefon
            </th>
            <th>
                Müşteri Ürün ID
            </th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 39 "C:\Users\Nur\Downloads\Deneme\vize-odevi-main (1)\vize-odevi-main\vize-odevi-main\Vize-Ödevi\Vize-Ödevi\Views\musteriler\Listele.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 43 "C:\Users\Nur\Downloads\Deneme\vize-odevi-main (1)\vize-odevi-main\vize-odevi-main\Vize-Ödevi\Vize-Ödevi\Views\musteriler\Listele.cshtml"
               Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 46 "C:\Users\Nur\Downloads\Deneme\vize-odevi-main (1)\vize-odevi-main\vize-odevi-main\Vize-Ödevi\Vize-Ödevi\Views\musteriler\Listele.cshtml"
               Write(Html.DisplayFor(modelItem => item.musteriAd));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 49 "C:\Users\Nur\Downloads\Deneme\vize-odevi-main (1)\vize-odevi-main\vize-odevi-main\Vize-Ödevi\Vize-Ödevi\Views\musteriler\Listele.cshtml"
               Write(Html.DisplayFor(modelItem => item.musteriSoyad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 52 "C:\Users\Nur\Downloads\Deneme\vize-odevi-main (1)\vize-odevi-main\vize-odevi-main\Vize-Ödevi\Vize-Ödevi\Views\musteriler\Listele.cshtml"
               Write(Html.DisplayFor(modelItem => item.musteriAdres));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 55 "C:\Users\Nur\Downloads\Deneme\vize-odevi-main (1)\vize-odevi-main\vize-odevi-main\Vize-Ödevi\Vize-Ödevi\Views\musteriler\Listele.cshtml"
               Write(Html.DisplayFor(modelItem => item.musteriTel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 58 "C:\Users\Nur\Downloads\Deneme\vize-odevi-main (1)\vize-odevi-main\vize-odevi-main\Vize-Ödevi\Vize-Ödevi\Views\musteriler\Listele.cshtml"
               Write(Html.DisplayFor(modelItem => item.musteriUrunId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                   ");
#nullable restore
#line 61 "C:\Users\Nur\Downloads\Deneme\vize-odevi-main (1)\vize-odevi-main\vize-odevi-main\Vize-Ödevi\Vize-Ödevi\Views\musteriler\Listele.cshtml"
              Write(Html.ActionLink("Güncelle", "Guncelle", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                   ");
#nullable restore
#line 62 "C:\Users\Nur\Downloads\Deneme\vize-odevi-main (1)\vize-odevi-main\vize-odevi-main\Vize-Ödevi\Vize-Ödevi\Views\musteriler\Listele.cshtml"
              Write(Html.ActionLink("Detay", "Detay", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                   ");
#nullable restore
#line 63 "C:\Users\Nur\Downloads\Deneme\vize-odevi-main (1)\vize-odevi-main\vize-odevi-main\Vize-Ödevi\Vize-Ödevi\Views\musteriler\Listele.cshtml"
              Write(Html.ActionLink("Sil", "Sil", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 66 "C:\Users\Nur\Downloads\Deneme\vize-odevi-main (1)\vize-odevi-main\vize-odevi-main\Vize-Ödevi\Vize-Ödevi\Views\musteriler\Listele.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Vize_Ödevi.Models.Musteriler>> Html { get; private set; }
    }
}
#pragma warning restore 1591
