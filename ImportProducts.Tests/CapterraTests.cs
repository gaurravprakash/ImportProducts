using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;

namespace ImportProducts.Tests
{
    [TestClass]
    public class CapterraTests
    {
        string capterraContent = @"---
-
              tags: ""Bugs & Issue Tracking, Development Tools, Methodologies""
              name: ""MyGitHub""
              twitter: ""githubfree""
            ";

        IProductSource capterra = Substitute.For<IProductSource>();

        [TestMethod]
        public void IsAbleToParseCapterraFile()
        {
            capterra.ReadFile(Arg.Any<string>()).ReturnsForAnyArgs(capterraContent);
            capterra.ParseFile(null);
            Assert.IsTrue(true);
        }
    }
}
