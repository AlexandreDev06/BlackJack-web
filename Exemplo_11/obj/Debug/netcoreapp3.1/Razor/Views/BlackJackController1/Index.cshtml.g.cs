#pragma checksum "C:\Users\Alex\Documents\FACULDADE\Tecnicas de programacao\Black_jack_web\BlackJack-web\Exemplo_11\Views\BlackJackController1\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c66129898184e25d3aa6a4f18bc94cda0ce272bf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BlackJackController1_Index), @"mvc.1.0.view", @"/Views/BlackJackController1/Index.cshtml")]
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
#line 1 "C:\Users\Alex\Documents\FACULDADE\Tecnicas de programacao\Black_jack_web\BlackJack-web\Exemplo_11\Views\_ViewImports.cshtml"
using Exemplo_11;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Alex\Documents\FACULDADE\Tecnicas de programacao\Black_jack_web\BlackJack-web\Exemplo_11\Views\_ViewImports.cshtml"
using Exemplo_11.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c66129898184e25d3aa6a4f18bc94cda0ce272bf", @"/Views/BlackJackController1/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27ceec164a7cd4aa67036470025a07e47923722d", @"/Views/_ViewImports.cshtml")]
    public class Views_BlackJackController1_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Alex\Documents\FACULDADE\Tecnicas de programacao\Black_jack_web\BlackJack-web\Exemplo_11\Views\BlackJackController1\Index.cshtml"
  
    ViewData["Title"] = "BlackJack";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<h1>Jogo BlackJack</h1>
<br />
<br />
<div class=""container-fluid"">
    <div class=""row"">
        <div class=""col-md-4"">
            <h3>
                Jogador 1
            </h3>
            <br /><br />
            <img alt=""carta1"" src=""/images/0.png"" height=""350"" width=""250"" name=""cartas1"" id=""cartas1"">
            <br /><br />
            <button type=""button"" class=""btn btn-success"" name=""btn_jogador_1"" id=""btn_jogador_1"" onclick=""jogador1()"">
                Jogar
            </button>
            <button type=""button"" class=""btn btn-success"" name=""btn_parar_1"" id=""btn_parar_1"" onclick=""parar1()"">
                Parar
            </button>
        </div>
        <div class=""col-md-4"">
            <h3>
                Partida
            </h3>
            <br /><br />
            <button type=""button"" class=""btn btn-success"" name=""btn_iniciar"" id=""btn_iniciar"" onclick=""iniciar()"">
                Iniciar
            </button>
            <button type=""button"" class=""btn btn");
            WriteLiteral(@"-success"" name=""btn_reiniciar"" id=""btn_reiniciar"" onclick=""reiniciar()"">
                Reiniciar
            </button>
            <br /><br />
            <div class=""row"">
                <div class=""col-md-4"">
                    <span class=""badge badge-default"" id=""resultado_jogador1"">0</span>
                </div>
                <div class=""col-md-4"">
                    <span class=""badge badge-default"">X</span>
                </div>
                <div class=""col-md-4"">
                    <span class=""badge badge-default"" id=""resultado_jogador2"">0</span>
                </div>
                <br />
                <br />
                <div class=""col-md-4"">
                    <FONT style=""font-size:20pt""><span class=""badge badge-default"" id=""resultado_total"">ㅤㅤㅤㅤResultado</span></FONT>
                </div>
            </div>
        </div>
        <div class=""col-md-4"">
            <h3>
                Jogador 2
            </h3>
            <br /><br />
        ");
            WriteLiteral(@"    <img alt=""carta2"" src=""/images/0.png"" height=""350"" width=""250"" name=""cartas2"" id=""cartas2"">
            <br /><br />
            <button type=""button"" class=""btn btn-success"" name=""btn_jogador_2"" id=""btn_jogador_2"" onclick=""jogador2()"">
                Jogar
            </button>
            <button type=""button"" class=""btn btn-success"" name=""btn_parar_2"" id=""btn_parar_2"" onclick=""parar2()"">
                Parar
            </button>
        </div>
    </div>
</div>");
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
