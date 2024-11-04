using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ASPLesson.Helper
{
    public static class ListHelper
    {
        public static HtmlString CreateParagraph(this IHtmlHelper htmlHelper, string text)
        {
            var result = $"<h2>{text}</h2>";
            return new HtmlString(result);
        }

        public static HtmlString CreateList(this IHtmlHelper htmlHelper, IEnumerable<string> text)
        {
            var result = "<select>";
            foreach (var item in text)
            {
                result = $"{result}<option> {item}</option>";
            }
            result = $"{result}</select>";
            return new HtmlString(result);
        }

        //public static HtmlString CreateListWithStyles(this IHtmlHelper htmlHelper, params string[] styles)
        //{
        //    var indent = "<div style='padding: 10px;'></div>";
        //    var block = "<div class='card col-md-12' style='padding: 10px; background-color: black;'>";

        //    var result=$"{block}<select>";
        //}
    }
}
