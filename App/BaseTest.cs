namespace App
{
    using Base;
    using NUnit.Framework;

    [TestFixture]
    public class BaseTest
    {
        [SetUp]
        public void Setup()
            => Driver.StartBrowser();

        [TearDown]
        public void Clean()
            => Driver.StopBrowser();
    }
}