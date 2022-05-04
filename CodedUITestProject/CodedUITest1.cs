using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Windows.Input;
using System.Xml;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;


namespace CodedUITestProject
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [CodedUITest]
    public class CodedUITest1
    {
        private UIMap map;
        private TestContext testContext;
        public TestContext TestContext1 { get => testContext; set => testContext = value; }

        public CodedUITest1()
        {
        }
        [TestInitialize]
        public void setup()
        {
            Playback.PlaybackSettings.WaitForReadyLevel = WaitForReadyLevel.Disabled;
        }

        [TestMethod]
        public void CodedUITestMethod1()
        {
            this.UIMap.RecordedMethod_addValueNumber("2","4","6","8");
            this.UIMap.AssertMethod_XepLoai("Yeu");

        }
        [TestMethod]
        public void CodedUITestMethodRandom()
        {
            Random rd = new Random();
            this.UIMap.RecordedMethod_addValueNumber(rd.Next(1,10).ToString(), rd.Next(1, 10).ToString(), rd.Next(1, 10).ToString(), rd.Next(1, 10).ToString());

        }
        [TestMethod]
        public void CodedUITestMethodRandom10()
        {
            for (int i = 0; i < 10; i++)
            {
                Random rd = new Random();
                this.UIMap.RecordedMethod_addValueNumber(rd.Next(1, 10).ToString(), rd.Next(1, 10).ToString(), rd.Next(1, 10).ToString(), rd.Next(1, 10).ToString());
            }
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\testData.csv", "testData#csv", DataAccessMethod.Sequential), DeploymentItem("testData.csv")]
        public void CodedUITestMethod2()
        {
            string diemToan, diemLy, diemHoa, diemRenLuyen;
            string xepLoai;
            diemToan = TestContext.DataRow[0].ToString();
            diemLy = TestContext.DataRow[1].ToString();
            diemHoa = TestContext.DataRow[2].ToString();
            diemRenLuyen = TestContext.DataRow[3].ToString();
            xepLoai = TestContext.DataRow[4].ToString();
            this.UIMap.RecordedMethod_addValueNumber(diemToan, diemLy, diemHoa, diemRenLuyen);
            this.UIMap.AssertMethod_XepLoai(xepLoai);
        }
        #region Additional test attributes

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
                if (this.map == null)
                {
                    this.map = new UIMap();
                }

                return this.map;
            }
        }

        

        
    }
}
