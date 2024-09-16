using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebComponentTest1.Common
{
   /// <summary>
   /// A couple of functions that enable the use of script sections in partials.
   /// </summary>
   public static class HtmlHelperExtensions
   {
      /// <summary>
      /// Adds a partial view script to the Http context to be rendered in the parent view
      /// </summary>
      public static IHtmlHelper Script(this IHtmlHelper htmlHelper, Func<object, HelperResult> template)
      {
         htmlHelper.ViewContext.HttpContext.Items["_script_" + Guid.NewGuid()] = template;
         return null;
      }

      /// <summary>
      /// Renders any scripts used within the partial views
      /// </summary>
      public static IHtmlHelper RenderPartialViewScripts(this IHtmlHelper htmlHelper)
      {
         foreach (object key in htmlHelper.ViewContext.HttpContext.Items.Keys)
         {
            if (key.ToString().StartsWith("_script_"))
            {
               if (htmlHelper.ViewContext.HttpContext.Items[key] is Func<object, HelperResult> template)
               {
                  htmlHelper.ViewContext.Writer.Write(template(null));
               }
            }
         }
         return null;
      }
   }
}
