#pragma checksum "C:\Users\Nikola\source\repos\ProjekatNapredniWeb\ProjekatNapredniWeb\Views\Poruka\PorukaVIew.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a5fe6e7027310868caa711300a9e49d18f701d85"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Poruka_PorukaVIew), @"mvc.1.0.view", @"/Views/Poruka/PorukaVIew.cshtml")]
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
#line 6 "C:\Users\Nikola\source\repos\ProjekatNapredniWeb\ProjekatNapredniWeb\Views\Poruka\PorukaVIew.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5fe6e7027310868caa711300a9e49d18f701d85", @"/Views/Poruka/PorukaVIew.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34b15dd49e827074e485424d236a04d97d5970b0", @"/Views/_ViewImports.cshtml")]
    public class Views_Poruka_PorukaVIew : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ProjekatNapredniWeb.Models.Poruka>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Nikola\source\repos\ProjekatNapredniWeb\ProjekatNapredniWeb\Views\Poruka\PorukaVIew.cshtml"
  
    ViewData["Title"] = "PorukaVIew";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<div class=\"products-list\">\r\n\r\n");
#nullable restore
#line 11 "C:\Users\Nikola\source\repos\ProjekatNapredniWeb\ProjekatNapredniWeb\Views\Poruka\PorukaVIew.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"card\">\r\n        <p><strong>");
#nullable restore
#line 14 "C:\Users\Nikola\source\repos\ProjekatNapredniWeb\ProjekatNapredniWeb\Views\Poruka\PorukaVIew.cshtml"
              Write(localizer["ImePrezime"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(": </strong>");
#nullable restore
#line 14 "C:\Users\Nikola\source\repos\ProjekatNapredniWeb\ProjekatNapredniWeb\Views\Poruka\PorukaVIew.cshtml"
                                                 Write(Html.DisplayFor(modelItem => item.ImePrezime));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p><strong>");
#nullable restore
#line 15 "C:\Users\Nikola\source\repos\ProjekatNapredniWeb\ProjekatNapredniWeb\Views\Poruka\PorukaVIew.cshtml"
              Write(localizer["Email"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(": </strong>");
#nullable restore
#line 15 "C:\Users\Nikola\source\repos\ProjekatNapredniWeb\ProjekatNapredniWeb\Views\Poruka\PorukaVIew.cshtml"
                                            Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p><strong>");
#nullable restore
#line 16 "C:\Users\Nikola\source\repos\ProjekatNapredniWeb\ProjekatNapredniWeb\Views\Poruka\PorukaVIew.cshtml"
              Write(localizer["DatumIzdavanja"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(": </strong>");
#nullable restore
#line 16 "C:\Users\Nikola\source\repos\ProjekatNapredniWeb\ProjekatNapredniWeb\Views\Poruka\PorukaVIew.cshtml"
                                                     Write(Html.DisplayFor(modelItem => item.Datum.Day));

#line default
#line hidden
#nullable disable
            WriteLiteral(". ");
#nullable restore
#line 16 "C:\Users\Nikola\source\repos\ProjekatNapredniWeb\ProjekatNapredniWeb\Views\Poruka\PorukaVIew.cshtml"
                                                                                                    Write(Html.DisplayFor(modelItem => item.Datum.Month));

#line default
#line hidden
#nullable disable
            WriteLiteral(". ");
#nullable restore
#line 16 "C:\Users\Nikola\source\repos\ProjekatNapredniWeb\ProjekatNapredniWeb\Views\Poruka\PorukaVIew.cshtml"
                                                                                                                                                     Write(Html.DisplayFor(modelItem => item.Datum.Year));

#line default
#line hidden
#nullable disable
            WriteLiteral(".</p>\r\n        <p><strong>");
#nullable restore
#line 17 "C:\Users\Nikola\source\repos\ProjekatNapredniWeb\ProjekatNapredniWeb\Views\Poruka\PorukaVIew.cshtml"
              Write(localizer["Poruka"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(": </strong>");
#nullable restore
#line 17 "C:\Users\Nikola\source\repos\ProjekatNapredniWeb\ProjekatNapredniWeb\Views\Poruka\PorukaVIew.cshtml"
                                             Write(Html.DisplayFor(modelItem => item.PorukaSadrzaj));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <a style=\'font-size:15px; text-decoration:none; color:rgba(215, 255, 0, 1);\'");
            BeginWriteAttribute("href", " href=\'", 889, "\'", 1027, 13);
            WriteAttributeValue("", 896, "mailto:", 896, 7, true);
#nullable restore
#line 18 "C:\Users\Nikola\source\repos\ProjekatNapredniWeb\ProjekatNapredniWeb\Views\Poruka\PorukaVIew.cshtml"
WriteAttributeValue(" ", 903, item.Email, 904, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 915, "?subject=NM", 916, 12, true);
            WriteAttributeValue(" ", 927, "|", 928, 2, true);
            WriteAttributeValue(" ", 929, "Odgovor", 930, 8, true);
            WriteAttributeValue(" ", 937, "na", 938, 3, true);
            WriteAttributeValue(" ", 940, "poruku:", 941, 8, true);
#nullable restore
#line 18 "C:\Users\Nikola\source\repos\ProjekatNapredniWeb\ProjekatNapredniWeb\Views\Poruka\PorukaVIew.cshtml"
WriteAttributeValue(" ", 948, item.Id, 949, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 957, "|", 958, 2, true);
#nullable restore
#line 18 "C:\Users\Nikola\source\repos\ProjekatNapredniWeb\ProjekatNapredniWeb\Views\Poruka\PorukaVIew.cshtml"
WriteAttributeValue(" ", 959, item.ImePrezime, 960, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 976, "&body=Poštovani,%0D%0A%0D%0A%0D%0AS", 977, 36, true);
            WriteAttributeValue(" ", 1012, "poštovanjem,", 1013, 13, true);
            WriteAttributeValue(" ", 1025, ".", 1026, 2, true);
            EndWriteAttribute();
            WriteLiteral(" target=\'_blank\' rel=\'noopener noreferrer\'>");
#nullable restore
#line 18 "C:\Users\Nikola\source\repos\ProjekatNapredniWeb\ProjekatNapredniWeb\Views\Poruka\PorukaVIew.cshtml"
                                                                                                                                                                                                                                                                     Write(localizer["Odgovori"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n    </div>\r\n");
#nullable restore
#line 20 "C:\Users\Nikola\source\repos\ProjekatNapredniWeb\ProjekatNapredniWeb\Views\Poruka\PorukaVIew.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ProjekatNapredniWeb.Models.Poruka>> Html { get; private set; }
    }
}
#pragma warning restore 1591
