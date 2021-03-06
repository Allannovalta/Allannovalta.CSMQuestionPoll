#pragma checksum "C:\Users\ALLAN_Novalta\Documents\Projects\Allannovalta.CSMQuestionPoll\Allannovalta.CSMQuestionPoll.Web\Areas\Manage\Views\PollQuestions\PollQuestions.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "347bbfefda306534f537009365bcb8776e92bd46"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Manage_Views_PollQuestions_PollQuestions), @"mvc.1.0.view", @"/Areas/Manage/Views/PollQuestions/PollQuestions.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Manage/Views/PollQuestions/PollQuestions.cshtml", typeof(AspNetCore.Areas_Manage_Views_PollQuestions_PollQuestions))]
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
#line 1 "C:\Users\ALLAN_Novalta\Documents\Projects\Allannovalta.CSMQuestionPoll\Allannovalta.CSMQuestionPoll.Web\Areas\Manage\Views\PollQuestions\PollQuestions.cshtml"
using Allannovalta.CSMQuestionPoll.Web.Infrastructure.Data.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"347bbfefda306534f537009365bcb8776e92bd46", @"/Areas/Manage/Views/PollQuestions/PollQuestions.cshtml")]
    public class Areas_Manage_Views_PollQuestions_PollQuestions : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Allannovalta.CSMQuestionPoll.Web.ViewModels.PollQuestions.PollQuestionViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\ALLAN_Novalta\Documents\Projects\Allannovalta.CSMQuestionPoll\Allannovalta.CSMQuestionPoll.Web\Areas\Manage\Views\PollQuestions\PollQuestions.cshtml"
  
    ViewData["Title"] = "PollQuestions";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(254, 1259, true);
            WriteLiteral(@"

<div class=""container"">
    <h2>PollQuestions</h2>
    <p>Here is a paged list of all the Poll Questions</p>
    <table class=""table"">
        <thead>
            <tr>
                <th>Title</th>
                <th>Content</th>
                <th>Thumbnail</th>
                <th>Is Published</th>
                <th>Post Expiry</th>
                <th></th>
            </tr>
        </thead>
        <tbody>
            {
                foreach (PollQuestion pollQuestion in Model.PollQuestions.Items)
                {
                    <tr>
                        <td>pollQuestion.Title</td>
                        <td>pollQuestion.Content</td>
                        <td>pollQuestion.Thumbnail</td>
                        <td>pollQuestion.IsPublished</td>
                        <td>pollQuestion.PostExpiry</td>
                        <td>
                            <a href=""#"" onclick=""confirmDeletePollQuestion()"" title=""Delete Poll Question""><button type=""button"" cla");
            WriteLiteral("ss=\"btn\"><i class=\"fas fa-times\"></i></button></a>\r\n                        </td>\r\n                    </tr>\r\n                }\r\n\r\n\r\n            }\r\n        </tbody>\r\n\r\n        <td colspan=\"4\">\r\n\r\n        </td>\r\n\r\n    </table>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Allannovalta.CSMQuestionPoll.Web.ViewModels.PollQuestions.PollQuestionViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
