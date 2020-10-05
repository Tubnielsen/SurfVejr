#pragma checksum "C:\Users\tubni\programming\Surfsup\SurfVejr\Surfvejr\Views\Home\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b7dae95be997d61c9244037d9bfabd0fa1510650"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_index), @"mvc.1.0.view", @"/Views/Home/index.cshtml")]
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
#line 1 "C:\Users\tubni\programming\Surfsup\SurfVejr\Surfvejr\Views\_ViewImports.cshtml"
using Surfvejr;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tubni\programming\Surfsup\SurfVejr\Surfvejr\Views\_ViewImports.cshtml"
using Surfvejr.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7dae95be997d61c9244037d9bfabd0fa1510650", @"/Views/Home/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4846debd8ab224ceee9d138e0d87cf091ba61ecd", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\tubni\programming\Surfsup\SurfVejr\Surfvejr\Views\Home\index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b7dae95be997d61c9244037d9bfabd0fa15106503481", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\">\r\n    <meta content=\"width=device-width, initial-scale=1.0\" name=\"viewport\">\r\n\r\n    <title>Surfs Up!</title>\r\n    <meta");
                BeginWriteAttribute("content", " content=\"", 239, "\"", 249, 0);
                EndWriteAttribute();
                WriteLiteral(" name=\"descriptison\">\r\n    <meta");
                BeginWriteAttribute("content", " content=\"", 282, "\"", 292, 0);
                EndWriteAttribute();
                WriteLiteral(@" name=""keywords"">

    <!-- Favicons -->
    <link href=""img/favicon.png"" rel=""icon"">
    <link href=""img/apple-touch-icon.png"" rel=""apple-touch-icon"">

    <!-- Google Fonts -->
    <link href=""https://fonts.googleapis.com/css?family=Open+Sans:300,300i,400,400i,600,600i,700,700i|Lato:400,300,700,900"" rel=""stylesheet"">

    <!-- Vendor CSS Files -->
    <link href=""vendor/bootstrap/css/bootstrap.min.css"" rel=""stylesheet"">
    <link href=""vendor/icofont/icofont.min.css"" rel=""stylesheet"">
    <link href=""vendor/venobox/venobox.css"" rel=""stylesheet"">
    <link href=""vendor/owl.carousel/assets/owl.carousel.min.css"" rel=""stylesheet"">

    <!-- Main CSS File -->
    <link href=""css/style.css"" rel=""stylesheet"">

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b7dae95be997d61c9244037d9bfabd0fa15106505726", async() => {
                WriteLiteral(@"



    <!-- ======= Hero Section ======= -->
    <section id=""hero"">
        <div class=""hero-container"">
            <h1>Spot me surf-bro</h1>
            <h2>Don't take this seriously</h2>
            <a href=""#about"" class=""btn-get-started scrollto"">Find Surf Spot</a>
        </div>
    </section><!-- #hero -->

    <main id=""main"">
  
        
        <!-- ======= About Us Section ======= -->
        <section id=""about"" class=""about"">
            <div class=""container"">

                <div class=""section-title"">
                    <h2>About Us</h2>
                </div>

                <div class=""row"">
                    <div class=""col-lg-6 order-1 order-lg-2"">
                        <img src=""assets/img/about-img.jpg"" class=""img-fluid""");
                BeginWriteAttribute("alt", " alt=\"", 1829, "\"", 1835, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                    </div>
                    <div class=""col-lg-6 pt-4 pt-lg-0 order-2 order-lg-1"">
                        <h3>Voluptatem dignissimos provident quasi corporis voluptates sit assumenda.</h3>
                        <p class=""font-italic"">
                            Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore
                            magna aliqua.
                        </p>
                        <ul>
                            <li><i class=""icofont-check-circled""></i> Ullamco laboris nisi ut aliquip ex ea commodo consequat.</li>
                            <li><i class=""icofont-check-circled""></i> Duis aute irure dolor in reprehenderit in voluptate velit.</li>
                            <li><i class=""icofont-check-circled""></i> Ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate trideta storacalaperda mastiro dolore eu fugiat nulla pariatur.</li>
 ");
                WriteLiteral(@"                       </ul>
                        <p>
                            Ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate
                            velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in
                            culpa qui officia deserunt mollit anim id est laborum
                        </p>
                    </div>
                </div>

            </div>
        </section><!-- End About Us Section -->
    </main>




    <!-- ======= Footer ======= -->
    <footer id=""footer"">
        <div class=""container"">
            <div class=""copyright"">
                &copy; Copyright <strong><span>SurfsUp</span></strong>. All Rights Reserved
            </div>
        </div>
    </footer><!-- End #footer -->

    <a href=""#"" class=""back-to-top""><i class=""icofont-simple-up""></i></a>

    <!-- Vendor JS Files -->
    <script src=""vendor/jque");
                WriteLiteral(@"ry/jquery.min.js""></script>
    <script src=""vendor/bootstrap/js/bootstrap.bundle.min.js""></script>
    <script src=""vendor/jquery.easing/jquery.easing.min.js""></script>
    <script src=""vendor/php-email-form/validate.js""></script>
    <script src=""vendor/isotope-layout/isotope.pkgd.min.js""></script>
    <script src=""vendor/venobox/venobox.min.js""></script>
    <script src=""vendor/owl.carousel/owl.carousel.min.js""></script>

    <!-- Main JS File -->
    <script src=""js/main.js""></script>

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
