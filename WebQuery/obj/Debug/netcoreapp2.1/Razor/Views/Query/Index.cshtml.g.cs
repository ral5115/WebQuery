#pragma checksum "C:\Users\ASUS\Desktop\Utiles\Debug\Nueva carpeta\Codigo Fuente\WebQuery\WebQuery\WebQuery\Views\Query\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "232ce3b679831691d7f22d1726e5463f4fb06657"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Query_Index), @"mvc.1.0.view", @"/Views/Query/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Query/Index.cshtml", typeof(AspNetCore.Views_Query_Index))]
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
#line 1 "C:\Users\ASUS\Desktop\Utiles\Debug\Nueva carpeta\Codigo Fuente\WebQuery\WebQuery\WebQuery\Views\_ViewImports.cshtml"
using WebQuery;

#line default
#line hidden
#line 2 "C:\Users\ASUS\Desktop\Utiles\Debug\Nueva carpeta\Codigo Fuente\WebQuery\WebQuery\WebQuery\Views\_ViewImports.cshtml"
using WebQuery.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"232ce3b679831691d7f22d1726e5463f4fb06657", @"/Views/Query/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"341653543f5e3ff1f6989b783be45f57ede00f43", @"/Views/_ViewImports.cshtml")]
    public class Views_Query_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebQuery.DAO.Pag<QueryOne>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onclick", new global::Microsoft.AspNetCore.Html.HtmlString("process()"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\ASUS\Desktop\Utiles\Debug\Nueva carpeta\Codigo Fuente\WebQuery\WebQuery\WebQuery\Views\Query\Index.cshtml"
  
    ViewData["Title"] = "Resultado de Consulta";

#line default
#line hidden
            BeginContext(92, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(94, 437, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c4303989a8274cb69d952c48cb9bda5d", async() => {
                BeginContext(132, 113, true);
                WriteLiteral("\r\n    <div class=\"form-action no-color\">\r\n        <p>\r\n            Filtro: <input type=\"text\" name=\"searchString\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 245, "\"", 279, 1);
#line 9 "C:\Users\ASUS\Desktop\Utiles\Debug\Nueva carpeta\Codigo Fuente\WebQuery\WebQuery\WebQuery\Views\Query\Index.cshtml"
WriteAttributeValue("", 253, ViewData["CurrentFilter"], 253, 26, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(280, 113, true);
                WriteLiteral(" />\r\n            <input type=\"submit\" value=\"Buscar\" class=\"btn btn-default\" onclick=\"process()\" />\r\n            ");
                EndContext();
                BeginContext(393, 65, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "59535646707b4cc68adc8634023637ef", async() => {
                    BeginContext(435, 19, true);
                    WriteLiteral("Todos los Registros");
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
                BeginContext(458, 25, true);
                WriteLiteral(" | Registros encontrados ");
                EndContext();
                BeginContext(484, 12, false);
#line 11 "C:\Users\ASUS\Desktop\Utiles\Debug\Nueva carpeta\Codigo Fuente\WebQuery\WebQuery\WebQuery\Views\Query\Index.cshtml"
                                                                                                 Write(Model.TotalR);

#line default
#line hidden
                EndContext();
                BeginContext(496, 28, true);
                WriteLiteral("\r\n        </p>\r\n    </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(531, 70, true);
            WriteLiteral("\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>");
            EndContext();
            BeginContext(601, 135, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7f4b8a8092544d7cb29dadcebd7b4d98", async() => {
                BeginContext(726, 6, true);
                WriteLiteral("Pedido");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-sortOrder", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 19 "C:\Users\ASUS\Desktop\Utiles\Debug\Nueva carpeta\Codigo Fuente\WebQuery\WebQuery\WebQuery\Views\Query\Index.cshtml"
                                               WriteLiteral(ViewData["NombreSortParm"]);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-sortOrder", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 19 "C:\Users\ASUS\Desktop\Utiles\Debug\Nueva carpeta\Codigo Fuente\WebQuery\WebQuery\WebQuery\Views\Query\Index.cshtml"
                                                                                                     WriteLiteral(ViewData["CurrentFilter"]);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentFilter"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-currentFilter", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentFilter"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(736, 510, true);
            WriteLiteral(@"</th>
            <th>Fecha</th>
            <th>Nit Cliente</th>
            <th>Cliente Sucursal</th>
            <th>Cliente</th>
            <th>Id Centro Operacion</th>
            <th>Centro Operacion</th>
            <th>Id Bodega</th>
            <th>Bodega</th>
            <th>Id Item</th>
            <th>Item</th>
            <th>Unidad Pedida</th>
            <th>Cantidad Pedida</th>
            <th>Estado</th>
            <th>Error</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 37 "C:\Users\ASUS\Desktop\Utiles\Debug\Nueva carpeta\Codigo Fuente\WebQuery\WebQuery\WebQuery\Views\Query\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(1295, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(1334, 11, false);
#line 40 "C:\Users\ASUS\Desktop\Utiles\Debug\Nueva carpeta\Codigo Fuente\WebQuery\WebQuery\WebQuery\Views\Query\Index.cshtml"
               Write(item.Pedido);

#line default
#line hidden
            EndContext();
            BeginContext(1345, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1373, 10, false);
#line 41 "C:\Users\ASUS\Desktop\Utiles\Debug\Nueva carpeta\Codigo Fuente\WebQuery\WebQuery\WebQuery\Views\Query\Index.cshtml"
               Write(item.Fecha);

#line default
#line hidden
            EndContext();
            BeginContext(1383, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1411, 16, false);
#line 42 "C:\Users\ASUS\Desktop\Utiles\Debug\Nueva carpeta\Codigo Fuente\WebQuery\WebQuery\WebQuery\Views\Query\Index.cshtml"
               Write(item.Cliente_Nit);

#line default
#line hidden
            EndContext();
            BeginContext(1427, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1455, 16, false);
#line 43 "C:\Users\ASUS\Desktop\Utiles\Debug\Nueva carpeta\Codigo Fuente\WebQuery\WebQuery\WebQuery\Views\Query\Index.cshtml"
               Write(item.Cliente_Suc);

#line default
#line hidden
            EndContext();
            BeginContext(1471, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1499, 12, false);
#line 44 "C:\Users\ASUS\Desktop\Utiles\Debug\Nueva carpeta\Codigo Fuente\WebQuery\WebQuery\WebQuery\Views\Query\Index.cshtml"
               Write(item.Cliente);

#line default
#line hidden
            EndContext();
            BeginContext(1511, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1539, 10, false);
#line 45 "C:\Users\ASUS\Desktop\Utiles\Debug\Nueva carpeta\Codigo Fuente\WebQuery\WebQuery\WebQuery\Views\Query\Index.cshtml"
               Write(item.Co_Id);

#line default
#line hidden
            EndContext();
            BeginContext(1549, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1577, 21, false);
#line 46 "C:\Users\ASUS\Desktop\Utiles\Debug\Nueva carpeta\Codigo Fuente\WebQuery\WebQuery\WebQuery\Views\Query\Index.cshtml"
               Write(item.Centro_Operacion);

#line default
#line hidden
            EndContext();
            BeginContext(1598, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1626, 14, false);
#line 47 "C:\Users\ASUS\Desktop\Utiles\Debug\Nueva carpeta\Codigo Fuente\WebQuery\WebQuery\WebQuery\Views\Query\Index.cshtml"
               Write(item.Bodega_Id);

#line default
#line hidden
            EndContext();
            BeginContext(1640, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1668, 11, false);
#line 48 "C:\Users\ASUS\Desktop\Utiles\Debug\Nueva carpeta\Codigo Fuente\WebQuery\WebQuery\WebQuery\Views\Query\Index.cshtml"
               Write(item.Bodega);

#line default
#line hidden
            EndContext();
            BeginContext(1679, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1707, 12, false);
#line 49 "C:\Users\ASUS\Desktop\Utiles\Debug\Nueva carpeta\Codigo Fuente\WebQuery\WebQuery\WebQuery\Views\Query\Index.cshtml"
               Write(item.Item_Id);

#line default
#line hidden
            EndContext();
            BeginContext(1719, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1747, 9, false);
#line 50 "C:\Users\ASUS\Desktop\Utiles\Debug\Nueva carpeta\Codigo Fuente\WebQuery\WebQuery\WebQuery\Views\Query\Index.cshtml"
               Write(item.Item);

#line default
#line hidden
            EndContext();
            BeginContext(1756, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1784, 18, false);
#line 51 "C:\Users\ASUS\Desktop\Utiles\Debug\Nueva carpeta\Codigo Fuente\WebQuery\WebQuery\WebQuery\Views\Query\Index.cshtml"
               Write(item.Unidad_Pedida);

#line default
#line hidden
            EndContext();
            BeginContext(1802, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1830, 17, false);
#line 52 "C:\Users\ASUS\Desktop\Utiles\Debug\Nueva carpeta\Codigo Fuente\WebQuery\WebQuery\WebQuery\Views\Query\Index.cshtml"
               Write(item.Cantidad_Ped);

#line default
#line hidden
            EndContext();
            BeginContext(1847, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1875, 11, false);
#line 53 "C:\Users\ASUS\Desktop\Utiles\Debug\Nueva carpeta\Codigo Fuente\WebQuery\WebQuery\WebQuery\Views\Query\Index.cshtml"
               Write(item.Estado);

#line default
#line hidden
            EndContext();
            BeginContext(1886, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1914, 10, false);
#line 54 "C:\Users\ASUS\Desktop\Utiles\Debug\Nueva carpeta\Codigo Fuente\WebQuery\WebQuery\WebQuery\Views\Query\Index.cshtml"
               Write(item.Error);

#line default
#line hidden
            EndContext();
            BeginContext(1924, 26, true);
            WriteLiteral("</td>\r\n            </tr>\r\n");
            EndContext();
#line 56 "C:\Users\ASUS\Desktop\Utiles\Debug\Nueva carpeta\Codigo Fuente\WebQuery\WebQuery\WebQuery\Views\Query\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1961, 28, true);
            WriteLiteral("    </tbody>\r\n\r\n</table>\r\n\r\n");
            EndContext();
#line 61 "C:\Users\ASUS\Desktop\Utiles\Debug\Nueva carpeta\Codigo Fuente\WebQuery\WebQuery\WebQuery\Views\Query\Index.cshtml"
  
    var prevDisabled = !Model.HasPreviousPage ? "disabled" : "";
    var nextDisabled = !Model.HasNextPage ? "disabled" : "";
    var pageIndex = Model.PageIndex;
    var numberPage = "";

#line default
#line hidden
            BeginContext(2188, 263, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8c6ae28ff38449168b993c3f6632d102", async() => {
                BeginContext(2431, 16, true);
                WriteLiteral("\r\n    Anterior\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-sortOrder", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 68 "C:\Users\ASUS\Desktop\Utiles\Debug\Nueva carpeta\Codigo Fuente\WebQuery\WebQuery\WebQuery\Views\Query\Index.cshtml"
            WriteLiteral(ViewData["CurrentSort"]);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-sortOrder", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 69 "C:\Users\ASUS\Desktop\Utiles\Debug\Nueva carpeta\Codigo Fuente\WebQuery\WebQuery\WebQuery\Views\Query\Index.cshtml"
        WriteLiteral(Model.PageIndex+1);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-page", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 70 "C:\Users\ASUS\Desktop\Utiles\Debug\Nueva carpeta\Codigo Fuente\WebQuery\WebQuery\WebQuery\Views\Query\Index.cshtml"
                WriteLiteral(ViewData["CurrentFilter"]);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentFilter"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-currentFilter", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentFilter"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2376, "btn", 2376, 3, true);
            AddHtmlAttributeValue(" ", 2379, "btn-default", 2380, 12, true);
#line 72 "C:\Users\ASUS\Desktop\Utiles\Debug\Nueva carpeta\Codigo Fuente\WebQuery\WebQuery\WebQuery\Views\Query\Index.cshtml"
AddHtmlAttributeValue(" ", 2391, prevDisabled, 2392, 13, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2451, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 76 "C:\Users\ASUS\Desktop\Utiles\Debug\Nueva carpeta\Codigo Fuente\WebQuery\WebQuery\WebQuery\Views\Query\Index.cshtml"
 for (int i = 1; i <= Model.TotalPages; i++)
{
    if (pageIndex == i)
    {
        numberPage = "disabled";
    }
    else
    {
        numberPage = "";
    }

#line default
#line hidden
            BeginContext(2625, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(2629, 259, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bac03dac87ea4d50bd25529691371d94", async() => {
                BeginContext(2867, 9, true);
                WriteLiteral("\r\n       ");
                EndContext();
                BeginContext(2877, 1, false);
#line 92 "C:\Users\ASUS\Desktop\Utiles\Debug\Nueva carpeta\Codigo Fuente\WebQuery\WebQuery\WebQuery\Views\Query\Index.cshtml"
  Write(i);

#line default
#line hidden
                EndContext();
                BeginContext(2878, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-sortOrder", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 87 "C:\Users\ASUS\Desktop\Utiles\Debug\Nueva carpeta\Codigo Fuente\WebQuery\WebQuery\WebQuery\Views\Query\Index.cshtml"
                WriteLiteral(ViewData["CurrentSort"]);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-sortOrder", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 88 "C:\Users\ASUS\Desktop\Utiles\Debug\Nueva carpeta\Codigo Fuente\WebQuery\WebQuery\WebQuery\Views\Query\Index.cshtml"
           WriteLiteral(i);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-page", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 89 "C:\Users\ASUS\Desktop\Utiles\Debug\Nueva carpeta\Codigo Fuente\WebQuery\WebQuery\WebQuery\Views\Query\Index.cshtml"
                    WriteLiteral(ViewData["CurrentFilter"]);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentFilter"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-currentFilter", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentFilter"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2810, "btn", 2810, 3, true);
            AddHtmlAttributeValue(" ", 2813, "btn-default", 2814, 12, true);
#line 90 "C:\Users\ASUS\Desktop\Utiles\Debug\Nueva carpeta\Codigo Fuente\WebQuery\WebQuery\WebQuery\Views\Query\Index.cshtml"
AddHtmlAttributeValue(" ", 2825, numberPage, 2826, 11, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2888, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 94 "C:\Users\ASUS\Desktop\Utiles\Debug\Nueva carpeta\Codigo Fuente\WebQuery\WebQuery\WebQuery\Views\Query\Index.cshtml"
}

#line default
#line hidden
            BeginContext(2893, 302, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "15cfaa22e2f94c06b63999d11b23a0fa", async() => {
                BeginContext(3174, 17, true);
                WriteLiteral("\r\n    Siguiente\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-sortOrder", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 96 "C:\Users\ASUS\Desktop\Utiles\Debug\Nueva carpeta\Codigo Fuente\WebQuery\WebQuery\WebQuery\Views\Query\Index.cshtml"
            WriteLiteral(ViewData["CurrentSort"]);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-sortOrder", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 97 "C:\Users\ASUS\Desktop\Utiles\Debug\Nueva carpeta\Codigo Fuente\WebQuery\WebQuery\WebQuery\Views\Query\Index.cshtml"
        WriteLiteral(Model.PageIndex+1);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-page", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 98 "C:\Users\ASUS\Desktop\Utiles\Debug\Nueva carpeta\Codigo Fuente\WebQuery\WebQuery\WebQuery\Views\Query\Index.cshtml"
                WriteLiteral(ViewData["CurrentFilter"]);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentFilter"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-currentFilter", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentFilter"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 99 "C:\Users\ASUS\Desktop\Utiles\Debug\Nueva carpeta\Codigo Fuente\WebQuery\WebQuery\WebQuery\Views\Query\Index.cshtml"
           WriteLiteral(ViewData["Data"]);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["dataView"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-dataView", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["dataView"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3119, "btn", 3119, 3, true);
            AddHtmlAttributeValue(" ", 3122, "btn-default", 3123, 12, true);
#line 100 "C:\Users\ASUS\Desktop\Utiles\Debug\Nueva carpeta\Codigo Fuente\WebQuery\WebQuery\WebQuery\Views\Query\Index.cshtml"
AddHtmlAttributeValue(" ", 3134, nextDisabled, 3135, 13, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebQuery.DAO.Pag<QueryOne>> Html { get; private set; }
    }
}
#pragma warning restore 1591
