using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FontAwesomeCS.UnitTest
{
    [TestClass]
    public class FontAwesomeCSTests
    {
        [TestMethod]
        public void FontAwesomeCS_Simple()
        {
            var fa = FAIcon.GithubAltBrands;

            Assert.AreEqual("github-alt", fa.Key());
            Assert.AreEqual("Alternate GitHub", fa.Label());
            Assert.AreEqual("brands", fa.Style());
            Assert.AreEqual("\uf113", fa.Unicode());

            Assert.AreEqual("brands", fa.FAStyle().Style());
        }
    }
}