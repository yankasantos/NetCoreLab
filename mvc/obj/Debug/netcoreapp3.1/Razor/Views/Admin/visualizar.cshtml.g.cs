#pragma checksum "C:\Users\ylpereira1\Documents\projects\NetCoreLab\mvc\Views\Admin\visualizar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "298ea23fd3d38950910a783833fd1d546b97da27"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_visualizar), @"mvc.1.0.view", @"/Views/Admin/visualizar.cshtml")]
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
#line 1 "C:\Users\ylpereira1\Documents\projects\NetCoreLab\mvc\Views\_ViewImports.cshtml"
using mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ylpereira1\Documents\projects\NetCoreLab\mvc\Views\_ViewImports.cshtml"
using mvc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"298ea23fd3d38950910a783833fd1d546b97da27", @"/Views/Admin/visualizar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6a06753573638890b0ff2d42042a0bcf031bf36", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_visualizar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\ylpereira1\Documents\projects\NetCoreLab\mvc\Views\Admin\visualizar.cshtml"
 if((bool)ViewData["autenticado"]){

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>OI visualizar ");
#nullable restore
#line 2 "C:\Users\ylpereira1\Documents\projects\NetCoreLab\mvc\Views\Admin\visualizar.cshtml"
                 Write(ViewData["autenticado"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
#nullable restore
#line 3 "C:\Users\ylpereira1\Documents\projects\NetCoreLab\mvc\Views\Admin\visualizar.cshtml"
}else{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>Estou aqui</h1>\r\n");
#nullable restore
#line 5 "C:\Users\ylpereira1\Documents\projects\NetCoreLab\mvc\Views\Admin\visualizar.cshtml"
}

#line default
#line hidden
#nullable disable
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
