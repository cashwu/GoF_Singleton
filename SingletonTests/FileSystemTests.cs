using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Singleton;

namespace Singleton.Tests
{
    [TestClass()]
    public class FileSystemTests
    {
        [TestMethod()]
        public void getInstanceTest()
        {
            FileSystem file1 = FileSystem.getInstance();
            Assert.IsNotNull(file1);

            FileSystem file2 = FileSystem.getInstance();
            Assert.IsNotNull(file2);

            Assert.AreEqual(file1, file2);
        }
    }
}