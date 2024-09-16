using System.Text.Json;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebComponentTest1.Pages.Shared;

namespace WebComponentTest1.Pages
{
   public class Test2Model : PageModel
   {
      public TestSuiteStatus2 TestSuiteStatus { get; set; }

      public string TestSuiteStatusJson => JsonSerializer.Serialize(TestSuiteStatus, new JsonSerializerOptions
      {
         DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
         PropertyNamingPolicy = JsonNamingPolicy.CamelCase
      });

      public void OnGet()
      {
         TestSuiteStatus = new TestSuiteStatus2 { TestSuiteName = "" };
      }
   }
}
