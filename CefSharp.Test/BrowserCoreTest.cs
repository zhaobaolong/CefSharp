﻿using NUnit.Framework;

namespace CefSharp.Test
{
    [TestFixture]
    public class BrowserCoreTest
    {
        private BrowserCore browser_core;

        [SetUp]
        public void SetUp()
        {
            browser_core = new BrowserCore();
        }

        [Test]
        public void Test()
        {
            int event_count = 0;
            browser_core.PropertyChanged += (sender, e) => event_count++;

            browser_core.Tooltip = "foo";
            browser_core.Tooltip = null;
            browser_core.Tooltip = null;

            Assert.AreEqual(2, event_count);
        }
    }
}
