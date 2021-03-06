﻿using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace ISA3.Pages.Extensions
{
    public static class EditControlsForHtmlExtension
    {
        public static IHtmlContent EditControlsFor<TClassType, TPropertyType>(
            this IHtmlHelper<TClassType> htmlHelper, Expression<Func<TClassType,
                TPropertyType>> expression)
        {
            var htmlStrings = HtmlString(htmlHelper, expression);
            return new HtmlContentBuilder(htmlStrings);
        }

        private static IList<object> HtmlString<TClassType,
            TPropertyType>(IHtmlHelper<TClassType> htmlHelper,
            Expression<Func<TClassType, TPropertyType>> expression)
        {
            return new List<object> {
                new HtmlString("<div class=\"form-group\">"),
                htmlHelper.LabelFor(expression, new {@class = "text-dark"}),
                htmlHelper.EditorFor(expression,
                    new {htmlAttributes = new {@class = "form-control"}}),
                htmlHelper.ValidationMessageFor(expression, "", new {@class = "text-danger"}),
                new HtmlString("</div>")
            };
        }
    }
}