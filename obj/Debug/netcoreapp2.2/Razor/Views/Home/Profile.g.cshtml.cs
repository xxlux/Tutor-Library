#pragma checksum "/Users/momo/Desktop/TutorLibrary/Views/Home/Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e7ce0c503a6f6dd9a20472151c3bf2c877cd6e50"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Profile), @"mvc.1.0.view", @"/Views/Home/Profile.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Profile.cshtml", typeof(AspNetCore.Views_Home_Profile))]
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
#line 1 "/Users/momo/Desktop/TutorLibrary/Views/_ViewImports.cshtml"
using LandR;

#line default
#line hidden
#line 2 "/Users/momo/Desktop/TutorLibrary/Views/_ViewImports.cshtml"
using LandR.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e7ce0c503a6f6dd9a20472151c3bf2c877cd6e50", @"/Views/Home/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4aecdc30a165aa4854e47665aa0af97b1bb45670", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Profile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProfileViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(25, 2, true);
            WriteLiteral("\n\n");
            EndContext();
#line 5 "/Users/momo/Desktop/TutorLibrary/Views/Home/Profile.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(69, 178, true);
            WriteLiteral("\n<img src=\"\" class=\"profile_main_pic\"></div>\n<div class=\"meeting_spot\">Building 3 Library</div>\n<div class=\"profile_details\">\n    <div class=\"profile_details_header\">Details for ");
            EndContext();
            BeginContext(248, 20, false);
#line 12 "/Users/momo/Desktop/TutorLibrary/Views/Home/Profile.cshtml"
                                               Write(Model.User.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(268, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(270, 19, false);
#line 12 "/Users/momo/Desktop/TutorLibrary/Views/Home/Profile.cshtml"
                                                                     Write(Model.User.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(289, 89, true);
            WriteLiteral(" \n        \n    </div>\n    <div class=\"rates_box\">\n        <div class=\"rates_text\">Rates: ");
            EndContext();
            BeginContext(379, 15, false);
#line 16 "/Users/momo/Desktop/TutorLibrary/Views/Home/Profile.cshtml"
                                  Write(Model.User.Rate);

#line default
#line hidden
            EndContext();
            BeginContext(394, 49, true);
            WriteLiteral("</div>\n        <div class=\"rates_text\">Schedule: ");
            EndContext();
            BeginContext(444, 19, false);
#line 17 "/Users/momo/Desktop/TutorLibrary/Views/Home/Profile.cshtml"
                                     Write(Model.User.Schedule);

#line default
#line hidden
            EndContext();
            BeginContext(463, 51, true);
            WriteLiteral("</div>\n        <div class=\"rates_text\">Speciality: ");
            EndContext();
            BeginContext(515, 18, false);
#line 18 "/Users/momo/Desktop/TutorLibrary/Views/Home/Profile.cshtml"
                                       Write(Model.User.Subject);

#line default
#line hidden
            EndContext();
            BeginContext(533, 47, true);
            WriteLiteral("</div>\n    </div>\n    <div class=\"button_box\">\n");
            EndContext();
#line 21 "/Users/momo/Desktop/TutorLibrary/Views/Home/Profile.cshtml"
         if(ViewBag.logged == null){

#line default
#line hidden
            BeginContext(617, 223, true);
            WriteLiteral("            <div>        \n                <a class=\"button\" href=\"Login\">Post a Review!</a>\n            </div>\n            <div>        \n                <a class=\"button\" href=\"Login\">Book this Tutor</a>\n            </div>\n");
            EndContext();
#line 28 "/Users/momo/Desktop/TutorLibrary/Views/Home/Profile.cshtml"
        }else{

#line default
#line hidden
            BeginContext(855, 59, true);
            WriteLiteral("            <div>        \n                <a class=\"button\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 914, "\"", 952, 2);
            WriteAttributeValue("", 921, "/LeaveReview/", 921, 13, true);
#line 30 "/Users/momo/Desktop/TutorLibrary/Views/Home/Profile.cshtml"
WriteAttributeValue("", 934, Model.User.UserId, 934, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(953, 146, true);
            WriteLiteral(">Post a Review!</a>\n            </div>\n            <div>        \n                <a class=\"button\" href=\"\">Book this Tutor</a>\n            </div>\n");
            EndContext();
#line 35 "/Users/momo/Desktop/TutorLibrary/Views/Home/Profile.cshtml"
        }

#line default
#line hidden
            BeginContext(1109, 20, true);
            WriteLiteral("\n    </div>\n</div>\n\n");
            EndContext();
#line 40 "/Users/momo/Desktop/TutorLibrary/Views/Home/Profile.cshtml"
 foreach (Review review in Model.Reviews){  

#line default
#line hidden
            BeginContext(1174, 40, true);
            WriteLiteral("<div class=\"review_component_container\">");
            EndContext();
            BeginContext(1215, 23, false);
#line 41 "/Users/momo/Desktop/TutorLibrary/Views/Home/Profile.cshtml"
                                   Write(review.Poster.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(1238, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1240, 23, false);
#line 41 "/Users/momo/Desktop/TutorLibrary/Views/Home/Profile.cshtml"
                                                            Write(review.Poster.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(1263, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1265, 17, false);
#line 41 "/Users/momo/Desktop/TutorLibrary/Views/Home/Profile.cshtml"
                                                                                     Write(review.ReviewText);

#line default
#line hidden
            EndContext();
            BeginContext(1282, 7, true);
            WriteLiteral("</div>\n");
            EndContext();
#line 42 "/Users/momo/Desktop/TutorLibrary/Views/Home/Profile.cshtml"
}

#line default
#line hidden
            BeginContext(1291, 8, true);
            WriteLiteral("</div>\n\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProfileViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
