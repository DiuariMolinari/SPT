#pragma checksum "C:\Projetos\AspNet\SPT\Views\Funcionarios\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f294037de94ccad4da3cda8161e5695c7c7a5955"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Funcionarios_Index), @"mvc.1.0.view", @"/Views/Funcionarios/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Funcionarios/Index.cshtml", typeof(AspNetCore.Views_Funcionarios_Index))]
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
#line 1 "C:\Projetos\AspNet\SPT\Views\_ViewImports.cshtml"
using SPT;

#line default
#line hidden
#line 2 "C:\Projetos\AspNet\SPT\Views\_ViewImports.cshtml"
using SPT.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f294037de94ccad4da3cda8161e5695c7c7a5955", @"/Views/Funcionarios/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d88ae7c6c4b01264b09ae3d0e0682da454347219", @"/Views/_ViewImports.cshtml")]
    public class Views_Funcionarios_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SPT.Models.Funcionario>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CriarFuncionario", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "FolhaPagamento", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AtualizarFuncionario", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ExcluirFuncionario", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(44, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Projetos\AspNet\SPT\Views\Funcionarios\Index.cshtml"
  
    ViewData["Title"] = "Funcionários";

#line default
#line hidden
            BeginContext(94, 37, true);
            WriteLiteral("\r\n<h2>Funcionários</h2>\r\n\r\n<td>\r\n    ");
            EndContext();
            BeginContext(131, 79, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "82eddba45b8a4f849d87b97c11a3fa10", async() => {
                BeginContext(185, 21, true);
                WriteLiteral("Cadastrar Funcionário");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(210, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(216, 98, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "06a0988507074d7d8eb8177e2b312007", async() => {
                BeginContext(291, 19, true);
                WriteLiteral("Folhas de Pagamento");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(314, 93, true);
            WriteLiteral("\r\n</td>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(408, 40, false);
#line 17 "C:\Projetos\AspNet\SPT\Views\Funcionarios\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(448, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(504, 39, false);
#line 20 "C:\Projetos\AspNet\SPT\Views\Funcionarios\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Cpf));

#line default
#line hidden
            EndContext();
            BeginContext(543, 211, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                Ativo\r\n            </th>\r\n            <th>\r\n                Valor Hora\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 32 "C:\Projetos\AspNet\SPT\Views\Funcionarios\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(803, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(864, 39, false);
#line 36 "C:\Projetos\AspNet\SPT\Views\Funcionarios\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(903, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(971, 38, false);
#line 39 "C:\Projetos\AspNet\SPT\Views\Funcionarios\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Cpf));

#line default
#line hidden
            EndContext();
            BeginContext(1009, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1077, 41, false);
#line 42 "C:\Projetos\AspNet\SPT\Views\Funcionarios\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
            EndContext();
            BeginContext(1118, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1186, 44, false);
#line 45 "C:\Projetos\AspNet\SPT\Views\Funcionarios\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.ValorHora));

#line default
#line hidden
            EndContext();
            BeginContext(1230, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1297, 106, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c429940a6da74530880ec8e0abd788ca", async() => {
                BeginContext(1393, 6, true);
                WriteLiteral("Editar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 48 "C:\Projetos\AspNet\SPT\Views\Funcionarios\Index.cshtml"
                                                           WriteLiteral(item.FuncionarioId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1403, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(1427, 104, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "afbb082e8c884e53bd1b176adcd81f51", async() => {
                BeginContext(1520, 7, true);
                WriteLiteral("Excluir");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 49 "C:\Projetos\AspNet\SPT\Views\Funcionarios\Index.cshtml"
                                                         WriteLiteral(item.FuncionarioId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1531, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 52 "C:\Projetos\AspNet\SPT\Views\Funcionarios\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1586, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SPT.Models.Funcionario>> Html { get; private set; }
    }
}
#pragma warning restore 1591
