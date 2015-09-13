using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;


namespace URLAutomation
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [CodedUITest]
    public class CodedUITest1
    {
        public CodedUITest1()
        {
        }

     

        [TestMethod]
        public void EndToEndFlow()
        {
            URLAutomation.FileHandler endtoend = new URLAutomation.FileHandler();
            endtoend.ReadURLFile();
            foreach (string line in endtoend.urlArray)
            {
                //this.UIMap.OpeningBrowser(line);
            }
            // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        }

        [TestMethod]
        public void UsingYouTubeMp3()
        {
            URLAutomation.FileHandler endtoend = new URLAutomation.FileHandler();
            endtoend.ReadURLFile();
            foreach (string line in endtoend.urlArray)
            {
                this.UIMap.UsingActualSite(line);
            }
        }
        #region Additional test attributes
        //[ClassInitialize]
        //public static void LaunchBroswer(TestContext context)
        //{
        //    Playback.Initialize();
        //    BrowserWindow browser = BrowserWindow.Launch(new System.Uri("http://www.bing.com/"));
        //}
        // You can use the following additional attributes as you write your tests:

        ////Use TestInitialize to run code before running each test 
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //}

        ////Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //}

        #endregion

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        private TestContext testContextInstance;

        public UIMap UIMap
        {
            get
            {
                if ((this.map == null))
                {
                    this.map = new UIMap();
                }

                return this.map;
            }
        }

        private UIMap map;
    }
}
