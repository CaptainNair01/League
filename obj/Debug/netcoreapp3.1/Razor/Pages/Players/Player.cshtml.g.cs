#pragma checksum "/Users/nairarn/Downloads/League/Pages/Players/Player.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b76161482f2851bcb4d18f9cea6242e76a3f979f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(League.Pages.Players.Pages_Players_Player), @"mvc.1.0.razor-page", @"/Pages/Players/Player.cshtml")]
namespace League.Pages.Players
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
#line 1 "/Users/nairarn/Downloads/League/Pages/_ViewImports.cshtml"
using League;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/nairarn/Downloads/League/Pages/_ViewImports.cshtml"
using League.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{id}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b76161482f2851bcb4d18f9cea6242e76a3f979f", @"/Pages/Players/Player.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5e3ff45e0845b767ce2e91c14cb4035fde88f59", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Players_Player : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "/Users/nairarn/Downloads/League/Pages/Players/Player.cshtml"
  
  ViewData["Title"] = "NFL Player - " + @Html.DisplayFor(model => model.Player.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"jumbotron p-2\">\r\n  <h1 class=\"display-4\">\r\n    <img");
            BeginWriteAttribute("src", " src=\"", 195, "\"", 243, 3);
            WriteAttributeValue("", 201, "/image/nfl/logo/", 201, 16, true);
#nullable restore
#line 10 "/Users/nairarn/Downloads/League/Pages/Players/Player.cshtml"
WriteAttributeValue("", 217, Model.Player.TeamId, 217, 22, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 239, ".png", 239, 4, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n    ");
#nullable restore
#line 11 "/Users/nairarn/Downloads/League/Pages/Players/Player.cshtml"
Write(Html.DisplayFor(model => model.Player.Number));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 12 "/Users/nairarn/Downloads/League/Pages/Players/Player.cshtml"
Write(Html.DisplayFor(model => model.Player.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n  </h1>\r\n</div>\r\n\r\n<div>");
#nullable restore
#line 16 "/Users/nairarn/Downloads/League/Pages/Players/Player.cshtml"
Write(Model.Player.Position);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<hr/>\r\n<div>Rating: ");
#nullable restore
#line 18 "/Users/nairarn/Downloads/League/Pages/Players/Player.cshtml"
        Write(Model.Player.Rating);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<div>Rank: ");
#nullable restore
#line 19 "/Users/nairarn/Downloads/League/Pages/Players/Player.cshtml"
      Write(Model.Player.Rank);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<div>Depth: ");
#nullable restore
#line 20 "/Users/nairarn/Downloads/League/Pages/Players/Player.cshtml"
       Write(Model.Player.Depth);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<hr/>\r\n<div>Experience: ");
#nullable restore
#line 22 "/Users/nairarn/Downloads/League/Pages/Players/Player.cshtml"
            Write(Model.Player.Experience);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<div>College: ");
#nullable restore
#line 23 "/Users/nairarn/Downloads/League/Pages/Players/Player.cshtml"
         Write(Model.Player.College);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<div>Draft: ");
#nullable restore
#line 24 "/Users/nairarn/Downloads/League/Pages/Players/Player.cshtml"
       Write(Model.Player.DraftYear);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 24 "/Users/nairarn/Downloads/League/Pages/Players/Player.cshtml"
                                 Write(Model.Player.DraftRound);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 24 "/Users/nairarn/Downloads/League/Pages/Players/Player.cshtml"
                                                            Write(Model.Player.DraftPick);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<hr/>\r\n<div>Height: ");
#nullable restore
#line 26 "/Users/nairarn/Downloads/League/Pages/Players/Player.cshtml"
        Write(Model.Player.Height);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<div>Weight: ");
#nullable restore
#line 27 "/Users/nairarn/Downloads/League/Pages/Players/Player.cshtml"
        Write(Model.Player.Weight);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<div>Age ");
#nullable restore
#line 28 "/Users/nairarn/Downloads/League/Pages/Players/Player.cshtml"
    Write(Model.Player.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<div>Birthday: ");
#nullable restore
#line 29 "/Users/nairarn/Downloads/League/Pages/Players/Player.cshtml"
          Write(Model.Player.BirthDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PlayerModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PlayerModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PlayerModel>)PageContext?.ViewData;
        public PlayerModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
