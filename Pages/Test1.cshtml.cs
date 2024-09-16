using System.Text.Json;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebComponentTest1.Pages.Shared;

namespace WebComponentTest1.Pages
{
   public class Test1Model : PageModel
   {
      public TestSuiteStatus TestSuiteStatus { get; set; }

      public string TestSuiteStatusJson => JsonSerializer.Serialize(TestSuiteStatus, new JsonSerializerOptions
      {
         PropertyNamingPolicy = JsonNamingPolicy.CamelCase
      });

      public void OnGet()
      {
         TestSuiteStatus = new TestSuiteStatus { TestSuiteName = "" };

         //TestSuiteStatus = new TestSuiteStatus
         //{
         //   TestSuiteName = "Test Suite 1",
         //   TestsTotal = 25,
         //   TestsPassed = 5,
         //   TestsFailed = 8,
         //   TestsNotRun = 12,
         //   ActiveTestCase = "Test Case 1"
         //};
      }
   }
}
