#pragma checksum "D:\shasti\sashti\Views\AddEmployee\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7df813985cb0be527c9bd87f461de0a9f7fc2f5c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AddEmployee_Index), @"mvc.1.0.view", @"/Views/AddEmployee/Index.cshtml")]
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
#line 1 "D:\shasti\sashti\Views\_ViewImports.cshtml"
using sashti;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\shasti\sashti\Views\_ViewImports.cshtml"
using sashti.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7df813985cb0be527c9bd87f461de0a9f7fc2f5c", @"/Views/AddEmployee/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82a1ea8c1494222479bcc27b3fa3ec5a69abcc7c", @"/Views/_ViewImports.cshtml")]
    public class Views_AddEmployee_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div");
            BeginWriteAttribute("class", " class=\"", 4, "\"", 12, 0);
            EndWriteAttribute();
            WriteLiteral(">\n\t<div class=\"page-title\">\n\t\t<div class=\"title_left\">\n\t\t\t<h3><i class=\"fa fa-users\"></i> Add Employee</h3>\n\t\t</div>\n\n");
            WriteLiteral(@"

	</div>
	<div class=""clearfix""></div>

	<div class=""row"">
		<div class=""col-md-12 col-sm-12 "">
			<div class=""x_panel"">
				<div class=""x_title"">
					<h2><i class=""fa fa-users""></i> <small>Add</small></h2>
					<ul class=""nav navbar-right panel_toolbox"">
						<li>
							<a class=""collapse-link""><i class=""fa fa-chevron-up""></i></a>
						</li>
						<li class=""dropdown"">
							<a href=""#"" class=""dropdown-toggle"" data-toggle=""dropdown"" role=""button"" aria-expanded=""false""><i class=""fa fa-wrench""></i></a>
							<ul class=""dropdown-menu"" role=""menu"">
								<li>
									<a href=""#"">Settings 1</a>
								</li>
								<li>
									<a href=""#"">Settings 2</a>
								</li>
							</ul>
						</li>
						<li>
							<a class=""close-link""><i class=""fa fa-close""></i></a>
						</li>
					</ul>
					<div class=""clearfix""></div>
				</div>

				<div class=""x_content"">
					<p>Insert Employee Information</p>
					<div id=""wizard"" class=""form_wizard wizard_horizontal"">
						<ul class=""wizard_steps"">
							<li>
");
            WriteLiteral(@"								<a href=""#step-1"">
									<span class=""step_no"">1</span>
									<span class=""step_descr"">
										Employee Master<br />
										<small>Employee Master description</small>
									</span>
								</a>
							</li>
							<li>
								<a href=""#step-2"">
									<span class=""step_no"">2</span>
									<span class=""step_descr"">
										Job Details<br />
										<small>Employee Job description</small>
									</span>
								</a>
							</li>
							<li>
								<a href=""#step-3"">
									<span class=""step_no"">3</span>
									<span class=""step_descr"">
										Employee Bank Information<br />
										<small>Employee Bank description</small>
									</span>
								</a>
							</li>

						</ul>
						<div id=""step-1"">
							asdf
						</div>
						<div id=""step-2"">
							werwer
						</div>
						<div id=""step-3"">
							hjkl
						</div>

					</div>
				</div>
			</div>
		</div>
	</div>

</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\n\t<script src=\"../vendors/jQuery-Smart-Wizard/js/jquery.smartWizard.js\"></script>\n");
            }
            );
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