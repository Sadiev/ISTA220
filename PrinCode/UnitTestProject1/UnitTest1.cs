using CsAst;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shouldly;

namespace UnitTestProject1
{
    [TestClass]
    public class IDisplayTests
    {
        //[TestMethod]
        //public void DefaultClassDisplay()
        //{
        //    var underTest = new Class("underTest");
        //    var displayed = underTest.Display();

        //    Assert.AreEqual("class underTest {}", displayed);
        //}
        public void TestClassDisplay(Visibility visibility)
        {
            var underTest = new Class("underTest", visibility);
            var displayed = underTest.Display();

            //Assert.AreEqual($"{Util.DisplayVisibility(visibility)}class underTest {{}}", displayed);

            displayed.ShouldBe($"{Util.DisplayVisibility(visibility)}class underTest {{}}");
        }
        [TestMethod]
        public void PrivateClassDisplay()
        {
            TestClassDisplay(Visibility.Private);
        }
        [TestMethod]
        public void PublicClassDisplay()
        {
            TestClassDisplay(Visibility.Public);
        }

        [TestMethod]
        public void ProtectedClassDisplay()
        {
            TestClassDisplay(Visibility.Protected);
        }
    }
}
