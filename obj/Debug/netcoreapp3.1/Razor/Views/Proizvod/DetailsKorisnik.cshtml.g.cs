#pragma checksum "C:\Users\Nikola\source\repos\ProjekatNapredniWeb\ProjekatNapredniWeb\Views\Proizvod\DetailsKorisnik.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "69b180ef0a544b9929a94a5b9650a98391fc5e81"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Proizvod_DetailsKorisnik), @"mvc.1.0.view", @"/Views/Proizvod/DetailsKorisnik.cshtml")]
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
#line 1 "C:\Users\Nikola\source\repos\ProjekatNapredniWeb\ProjekatNapredniWeb\Views\_ViewImports.cshtml"
using ProjekatNapredniWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Nikola\source\repos\ProjekatNapredniWeb\ProjekatNapredniWeb\Views\_ViewImports.cshtml"
using ProjekatNapredniWeb.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Nikola\source\repos\ProjekatNapredniWeb\ProjekatNapredniWeb\Views\Proizvod\DetailsKorisnik.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69b180ef0a544b9929a94a5b9650a98391fc5e81", @"/Views/Proizvod/DetailsKorisnik.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34b15dd49e827074e485424d236a04d97d5970b0", @"/Views/_ViewImports.cshtml")]
    public class Views_Proizvod_DetailsKorisnik : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjekatNapredniWeb.Models.Proizvod>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("border: none; outline: 0; padding: 12px; color: black; background-color:white; text-align: center; cursor: pointer; font-size: 18px; text-decoration: none;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ProizvodViewKorisnik", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Nikola\source\repos\ProjekatNapredniWeb\ProjekatNapredniWeb\Views\Proizvod\DetailsKorisnik.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>");
#nullable restore
#line 8 "C:\Users\Nikola\source\repos\ProjekatNapredniWeb\ProjekatNapredniWeb\Views\Proizvod\DetailsKorisnik.cshtml"
Write(Html.DisplayFor(model => model.Naziv));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col-9\"></div>\r\n        <div class=\"col-4\">\r\n            <div>\r\n                <dl class=\"dl-horizontal\">\r\n                    <dt>\r\n                        ");
#nullable restore
#line 17 "C:\Users\Nikola\source\repos\ProjekatNapredniWeb\ProjekatNapredniWeb\Views\Proizvod\DetailsKorisnik.cshtml"
                   Write(Html.DisplayNameFor(model => model.Naziv));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
#nullable restore
#line 20 "C:\Users\Nikola\source\repos\ProjekatNapredniWeb\ProjekatNapredniWeb\Views\Proizvod\DetailsKorisnik.cshtml"
                   Write(Html.DisplayFor(model => model.Naziv));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt>\r\n                        ");
#nullable restore
#line 23 "C:\Users\Nikola\source\repos\ProjekatNapredniWeb\ProjekatNapredniWeb\Views\Proizvod\DetailsKorisnik.cshtml"
                   Write(Html.DisplayNameFor(model => model.Cena));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
#nullable restore
#line 26 "C:\Users\Nikola\source\repos\ProjekatNapredniWeb\ProjekatNapredniWeb\Views\Proizvod\DetailsKorisnik.cshtml"
                   Write(Html.DisplayFor(model => model.Cena));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt>\r\n                        ");
#nullable restore
#line 29 "C:\Users\Nikola\source\repos\ProjekatNapredniWeb\ProjekatNapredniWeb\Views\Proizvod\DetailsKorisnik.cshtml"
                   Write(Html.DisplayNameFor(model => model.Izdavac));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
#nullable restore
#line 32 "C:\Users\Nikola\source\repos\ProjekatNapredniWeb\ProjekatNapredniWeb\Views\Proizvod\DetailsKorisnik.cshtml"
                   Write(Html.DisplayFor(model => model.Izdavac));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt>\r\n                        ");
#nullable restore
#line 35 "C:\Users\Nikola\source\repos\ProjekatNapredniWeb\ProjekatNapredniWeb\Views\Proizvod\DetailsKorisnik.cshtml"
                   Write(Html.DisplayNameFor(model => model.Zanr));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
#nullable restore
#line 38 "C:\Users\Nikola\source\repos\ProjekatNapredniWeb\ProjekatNapredniWeb\Views\Proizvod\DetailsKorisnik.cshtml"
                   Write(Html.DisplayFor(model => model.Zanr));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt>\r\n                        ");
#nullable restore
#line 41 "C:\Users\Nikola\source\repos\ProjekatNapredniWeb\ProjekatNapredniWeb\Views\Proizvod\DetailsKorisnik.cshtml"
                   Write(Html.DisplayNameFor(model => model.Platforma));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
#nullable restore
#line 44 "C:\Users\Nikola\source\repos\ProjekatNapredniWeb\ProjekatNapredniWeb\Views\Proizvod\DetailsKorisnik.cshtml"
                   Write(Html.DisplayFor(model => model.Platforma));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt>\r\n                        ");
#nullable restore
#line 47 "C:\Users\Nikola\source\repos\ProjekatNapredniWeb\ProjekatNapredniWeb\Views\Proizvod\DetailsKorisnik.cshtml"
                   Write(Html.DisplayNameFor(model => model.DatumIzlaska));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
#nullable restore
#line 50 "C:\Users\Nikola\source\repos\ProjekatNapredniWeb\ProjekatNapredniWeb\Views\Proizvod\DetailsKorisnik.cshtml"
                   Write(Html.DisplayFor(model => model.DatumIzlaska.Day));

#line default
#line hidden
#nullable disable
            WriteLiteral(". ");
#nullable restore
#line 50 "C:\Users\Nikola\source\repos\ProjekatNapredniWeb\ProjekatNapredniWeb\Views\Proizvod\DetailsKorisnik.cshtml"
                                                                      Write(Html.DisplayFor(model => model.DatumIzlaska.Month));

#line default
#line hidden
#nullable disable
            WriteLiteral(". ");
#nullable restore
#line 50 "C:\Users\Nikola\source\repos\ProjekatNapredniWeb\ProjekatNapredniWeb\Views\Proizvod\DetailsKorisnik.cshtml"
                                                                                                                           Write(Html.DisplayFor(model => model.DatumIzlaska.Year));

#line default
#line hidden
#nullable disable
            WriteLiteral(".\r\n                    </dd>\r\n                    <dt>\r\n\r\n                    </dt>\r\n\r\n                </dl>\r\n            </div>\r\n        </div>\r\n        <div class=\"col-6\">\r\n            <img style=\"height: 350px; width: auto;\"");
            BeginWriteAttribute("src", " src=\"", 2162, "\"", 2214, 2);
            WriteAttributeValue("", 2168, "/images/", 2168, 8, true);
#nullable restore
#line 60 "C:\Users\Nikola\source\repos\ProjekatNapredniWeb\ProjekatNapredniWeb\Views\Proizvod\DetailsKorisnik.cshtml"
WriteAttributeValue("", 2176, Html.DisplayFor(model => model.Slika), 2176, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
            <br>
        </div>
    </div>
</div>


<div>
    <a style=""border: none; outline: 0; padding: 12px; color: white; background: linear-gradient(to right, #2980b9, #2c3e50); text-align: center; cursor: pointer; font-size: 18px; text-decoration: none;""");
            BeginWriteAttribute("href", " href=\"", 2488, "\"", 2541, 2);
            WriteAttributeValue("", 2495, "/Korpa/Buy/", 2495, 11, true);
#nullable restore
#line 68 "C:\Users\Nikola\source\repos\ProjekatNapredniWeb\ProjekatNapredniWeb\Views\Proizvod\DetailsKorisnik.cshtml"
WriteAttributeValue("", 2506, Html.DisplayFor(model => model.Id), 2506, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"><svg xmlns=""http://www.w3.org/2000/svg"" class=""icon icon-tabler icon-tabler-shopping-cart-plus"" width=""24"" height=""24"" viewBox=""0 0 24 24"" stroke-width=""2"" stroke=""currentColor"" fill=""none"" stroke-linecap=""round"" stroke-linejoin=""round"">
    <path stroke=""none"" d=""M0 0h24v24H0z"" fill=""none""></path>
    <circle cx=""6"" cy=""19"" r=""2""></circle>
    <circle cx=""17"" cy=""19"" r=""2""></circle>
    <path d=""M17 17h-11v-14h-2""></path>
    <path d=""M6 5l6.005 .429m7.138 6.573l-.143 .998h-13""></path>
    <path d=""M15 6h6m-3 -3v6""></path>
</svg> ");
#nullable restore
#line 75 "C:\Users\Nikola\source\repos\ProjekatNapredniWeb\ProjekatNapredniWeb\Views\Proizvod\DetailsKorisnik.cshtml"
  Write(localizer["AddToCart"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "69b180ef0a544b9929a94a5b9650a98391fc5e8112568", async() => {
#nullable restore
#line 76 "C:\Users\Nikola\source\repos\ProjekatNapredniWeb\ProjekatNapredniWeb\Views\Proizvod\DetailsKorisnik.cshtml"
                                                                                                                                                                                                        Write(localizer["NazadNaListu"]);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHtmlLocalizer<Resource> localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjekatNapredniWeb.Models.Proizvod> Html { get; private set; }
    }
}
#pragma warning restore 1591
