namespace WebComponentTest1.Pages.Shared
{
   public class TestSuiteStatus
   {
      public string TestSuiteName { get; set; }
      public int? TestsTotal { get; set; } = null;
      public int TestsPassed { get; set; }
      public int TestsFailed { get; set; }
      public int TestsNotRun { get; set; }
      public string ActiveTestCase { get; set; }
   }
}
