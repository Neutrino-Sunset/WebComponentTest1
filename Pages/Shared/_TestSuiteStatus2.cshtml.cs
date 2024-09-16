namespace WebComponentTest1.Pages.Shared
{
   public class TestSuiteStatus2
   {
      public string TestSuiteName { get; set; }
      public int? TestSuiteId { get; set; }
      public int? TestsTotal { get; set; } = null;
      public int? TestsPassed { get; set; } = null;
      public int? TestsFailed { get; set; } = null;
      public int? TestsNotRun { get; set; } = null;
      public string ActiveTestCase { get; set; }
      public int? TestCaseId { get; set; }
   }
}
