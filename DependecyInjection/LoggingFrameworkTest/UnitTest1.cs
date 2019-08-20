using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Shouldly;
using LoggingFramework.Concrete;
using LoggingFramework.Abstract;

namespace LoggingFrameworkTest
{
    [TestClass]
    public class FileLoggerTests
    {
        private const string Path = "test.file.txt";
        
        private readonly ILogger logger = new FileLogger(Path); 
        
        [ClassInitialize()]
        public static void Innit(TestContext _)
        {
            File.Delete(Path);
        }
        //[TestCleanup()]
        [ClassCleanup()]
        public static void Cleanup()
        {
            File.Delete(Path);
        }
        [TestMethod]
        public void FileExists()
        {
            //File.Create(Path).Close();
            File.Exists(Path).ShouldBeTrue();

            //Assert.IsTrue(File.Exists(Path));
        }
        [TestMethod]
        public void LoggerLogs()
        {
            const string ToLog = "a nice little test string";
            logger.Log(ToLog);
            var read =File.ReadAllText(Path);
            read.ShouldBe($"{ToLog}\r\n");
        }
    }
}
