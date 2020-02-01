using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace ISA3.Pages.Extensions
{
    public static class DisplayControlsForHtmlExtension
    {
        public static IHtmlContent DisplayControlsFor<TClassType, TPropertyType>(
            this IHtmlHelper<TClassType> htmlHelper,
            Expression<Func<TClassType, TPropertyType>> expression)
        {
            var content = HtmlString(htmlHelper, expression);

            return new HtmlContentBuilder(content);
        }

        internal static IList<object> HtmlString<TClassType, TPropertyType>
            (IHtmlHelper<TClassType> htmlHelper,
            Expression<Func<TClassType, TPropertyType>> expression)
        {
            return new List<object>
            {
                new HtmlString("<dt class=\"col-sm-2\">"),
                htmlHelper.DisplayNameFor(expression),
                new HtmlString("</dt>"),
                new HtmlString("<dd class=\"col-sm-10\">"),
                htmlHelper.DisplayFor(expression),
                new HtmlString("</dd>")
            };
        }
    }
}