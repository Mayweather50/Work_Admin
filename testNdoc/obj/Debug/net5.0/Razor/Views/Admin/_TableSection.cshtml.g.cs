#pragma checksum "C:\Users\UserHome\Downloads\BacPac-main\BacPac-main\testNdoc\Views\Admin\_TableSection.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a125d5dc70fb6f965da3823703f08dc49b50487"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin__TableSection), @"mvc.1.0.view", @"/Views/Admin/_TableSection.cshtml")]
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
#line 1 "C:\Users\UserHome\Downloads\BacPac-main\BacPac-main\testNdoc\Views\_ViewImports.cshtml"
using testNdoc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\UserHome\Downloads\BacPac-main\BacPac-main\testNdoc\Views\_ViewImports.cshtml"
using testNdoc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a125d5dc70fb6f965da3823703f08dc49b50487", @"/Views/Admin/_TableSection.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34b193fc75ff9d3768298c47a40f542c6848fdd7", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin__TableSection : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Section >>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\UserHome\Downloads\BacPac-main\BacPac-main\testNdoc\Views\Admin\_TableSection.cshtml"
  
    ViewBag.Title = "Каталог компонентов";

#line default
#line hidden
#nullable disable
            WriteLiteral("<table class=\"table table-sm\">\n    <tr>\n        <th>Имя компонента</th>\n      \n    </tr>\n\n");
#nullable restore
#line 11 "C:\Users\UserHome\Downloads\BacPac-main\BacPac-main\testNdoc\Views\Admin\_TableSection.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\n    <td style=\"cursor:pointer;\"");
            BeginWriteAttribute("onclick", " onclick=\"", 242, "\"", 274, 3);
            WriteAttributeValue("", 252, "GetDocuments(", 252, 13, true);
#nullable restore
#line 14 "C:\Users\UserHome\Downloads\BacPac-main\BacPac-main\testNdoc\Views\Admin\_TableSection.cshtml"
WriteAttributeValue("", 265, item.Id, 265, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 273, ")", 273, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\n\n\n        ");
#nullable restore
#line 17 "C:\Users\UserHome\Downloads\BacPac-main\BacPac-main\testNdoc\Views\Admin\_TableSection.cshtml"
   Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n    </td>\n</tr>\n");
#nullable restore
#line 21 "C:\Users\UserHome\Downloads\BacPac-main\BacPac-main\testNdoc\Views\Admin\_TableSection.cshtml"
     }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Section >> Html { get; private set; }
    }
}
#pragma warning restore 1591
