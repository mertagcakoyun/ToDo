using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDo.Web.TagHelpers
{
    [HtmlTargetElement("ToDO")]
    public class Paragraph : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {       
            //<p><b> ToDo App </b></p>
            //var tagBuilder = new TagBuilder("p");
            //tagBuilder.InnerHtml.AppendHtml("<b> ToDo App </b>");
            //output.Content.SetHtmlContent(tagBuilder);


            base.Process(context, output);
        }

    }
}
