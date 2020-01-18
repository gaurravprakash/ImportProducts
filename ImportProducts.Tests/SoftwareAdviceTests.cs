using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Text;

namespace ImportProducts.Tests
{
    [TestClass]
    public class SoftwareAdviceTests
    {
        string softwareAdviceContent = @"{
                        ""products"": [
                            {
                                ""categories"": [
                                    ""Customer Service and Support"",
                                    ""Central Call Center""
                                ],
                                ""twitter"": ""@helpdesk"",
                                ""title"": ""Helpdesk""
                            }
                        ]
                    }

                                ";

        IProductSource softwareAdvice = Substitute.For<IProductSource>();

        [TestMethod]
        public void IsAbleToParseSoftwareAdviceFile()
        {
            softwareAdvice.ReadFile(Arg.Any<string>()).ReturnsForAnyArgs(softwareAdviceContent);
            softwareAdvice.ParseFile(null);
            Assert.IsTrue(true);
        }
    }
}
