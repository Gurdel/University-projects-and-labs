using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class Tests
    {
        string path = "normPhones.xml";

        [TestMethod]
        public void TestLINQ_Meizu_M6_Note_3_32()
        {
            XML.Phone searchPhone = new XML.Phone();
            searchPhone.Firm = "Meizu";
            searchPhone.Model = "M6 Note";
            searchPhone.Ram = "3";
            searchPhone.Rom = "32";
            searchPhone.Battery = "4000";
            searchPhone.Processor = "Snapdragon 625";
            searchPhone.Os = "Android 7.1";
            searchPhone.Diagonal = "5.5";
            searchPhone.Resolution = "FHD";
            searchPhone.Matrix = "IPS";

            XML.Phone comparePhone = new XML.Phone();
            comparePhone.Firm = "Meizu";
            comparePhone.Model = "M6 Note";
            comparePhone.Ram = "3";
            comparePhone.Rom = "32";
            comparePhone.Battery = "4000";
            comparePhone.Processor = "Snapdragon 625";
            comparePhone.Os = "Android 7.1";
            comparePhone.Diagonal = "5.5";
            comparePhone.Resolution = "FHD";
            comparePhone.Matrix = "IPS";

            XML.IStrategy searchMethod = new XML.LINQ(path);

            List<XML.Phone> resultPhonesList = searchMethod.Algorithm(searchPhone, path);
            Assert.AreEqual(1, resultPhonesList.Count);
            Assert.AreEqual(true, resultPhonesList[0].Comparing(comparePhone));
        }

        [TestMethod]
        public void TestLINQ_Huawei_P20_4_128()
        {
            XML.Phone searchPhone = new XML.Phone();
            searchPhone.Firm = "Huawei";
            searchPhone.Model = "P20";
            searchPhone.Ram = "4";
            searchPhone.Rom = "128";
            searchPhone.Battery = "3400";
            searchPhone.Processor = "Kirin 970";
            searchPhone.Os = "Android 8.1";
            searchPhone.Diagonal = "5.8";
            searchPhone.Resolution = "FHD+";
            searchPhone.Matrix = "IPS";

            XML.Phone comparePhone = new XML.Phone();
            comparePhone.Firm = "Huawei";
            comparePhone.Model = "P20";
            comparePhone.Ram = "4";
            comparePhone.Rom = "128";
            comparePhone.Battery = "3400";
            comparePhone.Processor = "Kirin 970";
            comparePhone.Os = "Android 8.1";
            comparePhone.Diagonal = "5.8";
            comparePhone.Resolution = "FHD+";
            comparePhone.Matrix = "IPS";

            XML.IStrategy searchMethod = new XML.LINQ(path);

            List<XML.Phone> resultPhonesList = searchMethod.Algorithm(searchPhone, path);
            Assert.AreEqual(1, resultPhonesList.Count);
            Assert.AreEqual(true, resultPhonesList[0].Comparing(comparePhone));
        }

        [TestMethod]
        public void TestSAX_Meizu_M6_Note_3_32()
        {
            XML.Phone searchPhone = new XML.Phone();
            searchPhone.Firm = "Meizu";
            searchPhone.Model = "M6 Note";
            searchPhone.Ram = "3";
            searchPhone.Rom = "32";
            searchPhone.Battery = "4000";
            searchPhone.Processor = "Snapdragon 625";
            searchPhone.Os = "Android 7.1";
            searchPhone.Diagonal = "5.5";
            searchPhone.Resolution = "FHD";
            searchPhone.Matrix = "IPS";

            XML.Phone comparePhone = new XML.Phone();
            comparePhone.Firm = "Meizu";
            comparePhone.Model = "M6 Note";
            comparePhone.Ram = "3";
            comparePhone.Rom = "32";
            comparePhone.Battery = "4000";
            comparePhone.Processor = "Snapdragon 625";
            comparePhone.Os = "Android 7.1";
            comparePhone.Diagonal = "5.5";
            comparePhone.Resolution = "FHD";
            comparePhone.Matrix = "IPS";

            XML.IStrategy searchMethod = new XML.SAX(path);

            List<XML.Phone> resultPhonesList = searchMethod.Algorithm(searchPhone, path);
            Assert.AreEqual(1, resultPhonesList.Count);
            Assert.AreEqual(true, resultPhonesList[0].Comparing(comparePhone));
        }

        [TestMethod]
        public void TestSAX_Huawei_P20_4_128()
        {
            XML.Phone searchPhone = new XML.Phone();
            searchPhone.Firm = "Huawei";
            searchPhone.Model = "P20";
            searchPhone.Ram = "4";
            searchPhone.Rom = "128";
            searchPhone.Battery = "3400";
            searchPhone.Processor = "Kirin 970";
            searchPhone.Os = "Android 8.1";
            searchPhone.Diagonal = "5.8";
            searchPhone.Resolution = "FHD+";
            searchPhone.Matrix = "IPS";

            XML.Phone comparePhone = new XML.Phone();
            comparePhone.Firm = "Huawei";
            comparePhone.Model = "P20";
            comparePhone.Ram = "4";
            comparePhone.Rom = "128";
            comparePhone.Battery = "3400";
            comparePhone.Processor = "Kirin 970";
            comparePhone.Os = "Android 8.1";
            comparePhone.Diagonal = "5.8";
            comparePhone.Resolution = "FHD+";
            comparePhone.Matrix = "IPS";

            XML.IStrategy searchMethod = new XML.SAX(path);

            List<XML.Phone> resultPhonesList = searchMethod.Algorithm(searchPhone, path);
            Assert.AreEqual(1, resultPhonesList.Count);
            Assert.AreEqual(true, resultPhonesList[0].Comparing(comparePhone));
        }

        [TestMethod]
        public void TestDOM_Meizu_M6_Note_3_32()
        {
            XML.Phone searchPhone = new XML.Phone();
            searchPhone.Firm = "Meizu";
            searchPhone.Model = "M6 Note";
            searchPhone.Ram = "3";
            searchPhone.Rom = "32";
            searchPhone.Battery = "4000";
            searchPhone.Processor = "Snapdragon 625";
            searchPhone.Os = "Android 7.1";
            searchPhone.Diagonal = "5.5";
            searchPhone.Resolution = "FHD";
            searchPhone.Matrix = "IPS";

            XML.Phone comparePhone = new XML.Phone();
            comparePhone.Firm = "Meizu";
            comparePhone.Model = "M6 Note";
            comparePhone.Ram = "3";
            comparePhone.Rom = "32";
            comparePhone.Battery = "4000";
            comparePhone.Processor = "Snapdragon 625";
            comparePhone.Os = "Android 7.1";
            comparePhone.Diagonal = "5.5";
            comparePhone.Resolution = "FHD";
            comparePhone.Matrix = "IPS";

            XML.IStrategy searchMethod = new XML.DOM(path);

            List<XML.Phone> resultPhonesList = searchMethod.Algorithm(searchPhone, path);
            Assert.AreEqual(1, resultPhonesList.Count);
            Assert.AreEqual(true, resultPhonesList[0].Comparing(comparePhone));
        }

        [TestMethod]
        public void TestDOM_Huawei_P20_4_128()
        {
            XML.Phone searchPhone = new XML.Phone();
            searchPhone.Firm = "Huawei";
            searchPhone.Model = "P20";
            searchPhone.Ram = "4";
            searchPhone.Rom = "128";
            searchPhone.Battery = "3400";
            searchPhone.Processor = "Kirin 970";
            searchPhone.Os = "Android 8.1";
            searchPhone.Diagonal = "5.8";
            searchPhone.Resolution = "FHD+";
            searchPhone.Matrix = "IPS";

            XML.Phone comparePhone = new XML.Phone();
            comparePhone.Firm = "Huawei";
            comparePhone.Model = "P20";
            comparePhone.Ram = "4";
            comparePhone.Rom = "128";
            comparePhone.Battery = "3400";
            comparePhone.Processor = "Kirin 970";
            comparePhone.Os = "Android 8.1";
            comparePhone.Diagonal = "5.8";
            comparePhone.Resolution = "FHD+";
            comparePhone.Matrix = "IPS";

            XML.IStrategy searchMethod = new XML.DOM(path);

            List<XML.Phone> resultPhonesList = searchMethod.Algorithm(searchPhone, path);
            Assert.AreEqual(1, resultPhonesList.Count);
            Assert.AreEqual(true, resultPhonesList[0].Comparing(comparePhone));
        }
    }
}
