#pragma checksum "F:\Study Material\Tatavsoft(Training)\Helperland\Helperland\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "efe6c81a464b55531233e1568d952a7ad4290eef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "F:\Study Material\Tatavsoft(Training)\Helperland\Helperland\Views\_ViewImports.cshtml"
using Helperland;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"efe6c81a464b55531233e1568d952a7ad4290eef", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"08d6a41ebeeea7046b77ebf56316c429a1c445ef", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "book_service", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Let\'s Book a Cleaner"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("ctr-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n");
#nullable restore
#line 2 "F:\Study Material\Tatavsoft(Training)\Helperland\Helperland\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Helperland | Home";
    Layout = "~/Views/Shared/HomePageLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""banner-image "">
    <div class=""container"">
        <h1>Do not feel like housework?</h1>
        <h3>Great! Book now for Helperland and enjoy the benefits</h3>
        <ul>
            <li>certified & insured helper</li>
            <li>easy booking procedure</li>
            <li>friendly customer service</li>
            <li>secure online payment method</li>
        </ul>
        <div class=""btn-wrapper text-center"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "efe6c81a464b55531233e1568d952a7ad4290eef4954", async() => {
                WriteLiteral("Let\'s Book a Cleaner");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>
        <div class=""step-wrapper"" id=""sw-1"">
            <div class=""row"">
                <div class=""col-lg-2"">
                    <img src=""/asset/step-1.png"">
                    <p>Enter your postcode</p>
                </div>
                <div class=""col-lg-1"">
                    <img src=""/asset/step-arrow-1.png"">
                </div>

                <div class=""col-lg-2"">
                    <img src=""/asset/step-2.png"">
                    <p>Select your plan</p>
                </div>
                <div class=""col-lg-1"">
                    <img src=""/asset/step-arrow-1-copy.png"">
                </div>

                <div class=""col-lg-2"">
                    <img src=""/asset/step-3.png"">
                    <p>Pay securely online</p>
                </div>
                <div class=""col-lg-1"">
                    <img src=""/asset/step-arrow-1.png"">
                </div>

                <div class=""col-lg-3"">
                    <img src=""/asset/step-4.png"">
        ");
            WriteLiteral(@"            <p>Enjoy amazing service</p>
                </div>
            </div>
        </div>

        <div class=""step-wrapper"" id=""sw-2"">
            <div class=""row"">
                <div class=""col-md-2"">
                    <img src=""/asset/step-1.png"">
                    <p>Enter your postcode</p>
                </div>
                <div class=""col-md-2"">
                    <img src=""/asset/step-arrow-1.png"">
                </div>

                <div class=""col-md-2"">
                    <img src=""/asset/step-2.png"">
                    <p>Select your plan</p>
                </div>
            </div>

            <div class=""row pt-3 pb-3"">
                <div class=""col-md-6"">

                </div>
                <div class=""col-md-2"">
                    <img src=""/asset/step-arrow-1.png"" class=""rotate_90"">
                </div>
            </div>
            <div class=""row"">
                <div class=""col-md-2"">
                    <img src=""/asset/step-4.png"">
                   ");
            WriteLiteral(@" <p>Enjoy amazing service</p>
                </div>
                <div class=""col-md-2"">
                    <img src=""/asset/step-arrow-1.png"" class=""rotate"">
                </div>

                <div class=""col-md-2"">
                    <img src=""/asset/step-3.png"">
                    <p>Pay securely online</p>
                </div>
            </div>
        </div>

    </div>
    <div class=""scroll-link-wrapper"">
        <a href=""Helperhand"" title=""Scroll Down"" class=""scroll-link"">
            <img src=""/asset/group-18_5.png"" alt=""Scroll-down"">
        </a>
    </div>
</div>
<!-- home section end-->
<!--why helperland section-->
<section id=""Helperhand"">
    <div class=""HelperHand container-fluid content"">
        <h2>Why Helperland</h2>
        <div class=""row helper-info"">
            <div class=""col-lg-4 col-sm-6 text-center"">
                <img src=""/asset/helper-img-1.png""");
            BeginWriteAttribute("alt", " alt=\"", 3625, "\"", 3631, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                <h3>Experience & Vetted Professionals</h3>
                <p>
                    dominate the industry in scale and scope with an adaptable,
                    extensive network that consistently delivers exceptional results.
                </p>
            </div>
            <div class=""col-lg-4 col-sm-6 text-center"">
                <img src=""/asset/group-23.png""");
            BeginWriteAttribute("alt", " alt=\"", 4021, "\"", 4027, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                <h3>Secure Online Payment</h3>
                <p>
                    Payment is processed securely online. Customers pay safely online and
                    manage the booking.
                </p>
            </div>
            <div class=""col-lg-4 col-sm-6 text-center"">
                <img src=""/asset/group-24.png""");
            BeginWriteAttribute("alt", " alt=\"", 4369, "\"", 4375, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                <h3>Dedicated Customer Service</h3>
                <p>
                    to our customers and are guided in all we do by their needs.
                    The team is always happy to support you and offer all the information.
                </p>
            </div>
        </div>
    </div>
</section>

<!--why helperland section end-->
<!--our blog section start-->
<section class=""blog_section f_color"">
    <div class=""container"">
        <div class=""our_blog_info"">
            <div class=""row align-items-center"">
                <div class=""col-lg-7 col-md-6"">
                    <h2 class=""h2"">Lorem ipsum dolor sit amet, consectetur</h2>
                    <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec nisi sapien, suscipit ut accumsan vitae, pulvinar ac libero.</p>
                    <p>Aliquam erat volutpat. Nullam quis ex odio. Nam bibendum cursus purus, vel efficitur urna finibus vitae. Nullam finibus aliquet pharetra. Morbi in sem dolor. Integer pretium hendreri");
            WriteLiteral(@"t ante quis vehicula.</p>
                    <p>Mauris consequat ornare enim, sed lobortis quam ultrices sed.</p>
                </div>
                <div class=""col-lg-5 col-md-6"">
                    <div class=""image-wrapper"">
                        <img src=""/asset/group-36.png"" alt=""Blog description"">
                    </div>
                </div>
            </div>
        </div>
        <div class=""our_blog_main"">
            <h2 class=""text-center"">Our Blog</h2>
            <div class=""row blog-wrapper"">
                <div class=""col-lg-4 col-sm-6 blog-detail-outer"">
                    <div class=""blog-detail"">
                        <div class=""blog-image"">
                            <img src=""/asset/group-28.png"" alt=""blog-image"">
                        </div>
                        <div class=""blog_content"">
                            <h3>Lorem ipsum dolor sit amet</h3>
                            <span>January 28, 2019</span>
                            <p>Lorem ipsum dolor sit ame");
            WriteLiteral(@"t, consectetur adipiscing elit. Sed fermentum metus pulvinar aliquet.</p>
                            <a href=""#"" title=""Read More"" class=""arrow-link"">Read More<em><img src=""/asset/shape-2.png"" alt=""right arrow""></em></a>
                        </div>
                    </div>
                </div>
                <div class=""col-lg-4 col-sm-6 blog-detail-outer"">
                    <div class=""blog-detail"">
                        <div class=""blog-image"">
                            <img src=""/asset/group-29.png"" alt=""blog-image"">
                        </div>
                        <div class=""blog_content"">
                            <h3>Lorem ipsum dolor sit amet</h3>
                            <span>January 28, 2019</span>
                            <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed fermentum metus pulvinar aliquet.</p>
                            <a href=""#"" title=""Read More"" class=""arrow-link"">Read More<em><img src=""/asset/shape-2.png"" alt=""right arrow""></em></a>
 ");
            WriteLiteral(@"                       </div>
                    </div>
                </div>
                <div class=""col-lg-4 col-sm-6 blog-detail-outer"">
                    <div class=""blog-detail"">
                        <div class=""blog-image"">
                            <img src=""/asset/group-30.png"" alt=""blog-image"">
                        </div>
                        <div class=""blog_content"">
                            <h3>Lorem ipsum dolor sit amet</h3>
                            <span>January 28, 2019</span>
                            <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed fermentum metus pulvinar aliquet.</p>
                            <a href=""#"" title=""Read More"" class=""arrow-link"">Read More<em><img src=""/asset/shape-2.png"" alt=""right arrow""></em></a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
<!--our blog section end-->
<!--customer section-->
<section class=""customer_section f_");
            WriteLiteral(@"color"">
    <div class=""container"">
        <h2 class=""text-center"">What Our Customers Say</h2>
        <div class=""row customer-wrapper"">
            <div class=""col-lg-4 col-sm-6 last-inner"">
                <div class=""customer-inner"">
                    <em class=""message-infor"">
                        <img src=""/asset/message.png"" alt=""Message Info"">
                    </em>
                    <div class=""person-info d-flex align-items-center"">
                        <div class=""person-image"">
                            <img src=""/asset/group-31.png"" alt=""Lary Watson"">
                        </div>
                        <div class=""p_content"">
                            <span class=""person-name"">Lary Watson</span>
                            <span class=""person-city"">Manchester</span>
                        </div>
                    </div>
                    <div class=""person-detail"">
                        <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed fermentum metus pul");
            WriteLiteral(@"vinar aliquet consequat. Praesent nec malesuada nibh.</p>
                        <p>Nullam et metus congue, auctor augue sit amet, consectetur tortor.</p>
                        <a href=""#"" title=""Read More"" class=""arrow-link"">Read More <em><img src=""/asset/shape-2.png"" alt=""Right Arrow""></em></a>
                    </div>
                </div>
            </div>
            <div class=""col-lg-4 col-sm-6 last-inner"">
                <div class=""customer-inner"">
                    <em class=""message-infor"">
                        <img src=""/asset/message.png"" alt=""Message Info"">
                    </em>
                    <div class=""person-info d-flex align-items-center"">
                        <div class=""person-image"">
                            <img src=""/asset/group-32.png"" alt=""John Smith"">
                        </div>
                        <div class=""p_content"">
                            <span class=""person-name"">John Smith</span>
                            <span class=""person-city"">Ma");
            WriteLiteral(@"nchester</span>
                        </div>
                    </div>
                    <div class=""person-detail"">
                        <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed fermentum metus pulvinar aliquet consequat. Praesent nec malesuada nibh.</p>
                        <p>Nullam et metus congue, auctor augue sit amet, consectetur tortor.</p>
                        <a href=""#"" title=""Read More"" class=""arrow-link"">Read More <em><img src=""/asset/shape-2.png"" alt=""Right Arrow""></em></a>
                    </div>
                </div>
            </div>
            <div class=""col-lg-4 col-sm-6 last-inner"">
                <div class=""customer-inner"">
                    <em class=""message-infor"">
                        <img src=""/asset/message.png"" alt=""Message Info"">
                    </em>
                    <div class=""person-info d-flex align-items-center"">
                        <div class=""person-image"">
                            <img src=""/asset/group-31.p");
            WriteLiteral(@"ng"" alt=""Lars Johnson"">
                        </div>
                        <div class=""p_content"">
                            <span class=""person-name"">Lars Johnson</span>
                            <span class=""person-city"">Manchester</span>
                        </div>
                    </div>
                    <div class=""person-detail"">
                        <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed fermentum metus pulvinar aliquet consequat. Praesent nec malesuada nibh.</p>
                        <p>Nullam et metus congue, auctor augue sit amet, consectetur tortor.</p>
                        <a href=""#"" title=""Read More"" class=""arrow-link"">Read More <em><img src=""/asset/shape-2.png"" alt=""Right Arrow""></em></a>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
<!--cutomer section end-->
<!--our news letter section-->
<section class=""news_letter f_color"">
    <div class=""container text-center"">
        <a href=""#""");
            WriteLiteral(@" class=""scroll-top""><img src=""/asset/forma-1.png"" alt=""up-arrow""></a>
        <a href=""#"" class=""message-boat""><img src=""/asset/layer-598.png"" alt=""message-boat""></a>
        <h2>GET OUR NEWSLETTER</h2>
        <div class=""form-row d-flex justify-content-center align-items-center"">
            <div class=""form-group"">
                <label for=""email"" style=""display: none;"">YOUR EMAIL</label>
                <input type=""text"" placeholder=""YOUR EMAIL"" id=""email"" class=""form-control"">
            </div>
            <div class=""btn-wrapper"">
                <button class=""submit_btn"">Submit</button>
            </div>
        </div>
    </div>
</section>

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
