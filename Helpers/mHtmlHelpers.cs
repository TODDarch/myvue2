using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System.Text;

public static class mHtmlHelpers
{
    public static IHtmlContent RenderScripts(this IHtmlHelper htmlHelper, params string[] scriptPaths)
    {
        var sb = new StringBuilder();
        foreach (var scriptPath in scriptPaths)
        {
            var scriptTag = $"<script src=\"{scriptPath}\" ></script>";
            sb.AppendLine(scriptTag);
        }
        return new HtmlString(sb.ToString());
    }

    public static IHtmlContent RenderStyles(this IHtmlHelper htmlHelper, params string[] stylePaths)
    {
        var sb = new StringBuilder();
        foreach (var stylePath in stylePaths)
        {
            var styleTag = $"<link href=\"{stylePath}\" rel=\"stylesheet\" />";
            sb.AppendLine(styleTag);
        }
        return new HtmlString(sb.ToString());
    }
}
