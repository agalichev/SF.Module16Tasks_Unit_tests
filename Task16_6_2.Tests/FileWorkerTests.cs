namespace Task16_6_2.Tests
{
    [TestClass]
    public class FileWorkerTests
    {
        [TestMethod]
        public void GetSafeFilenameMustReturnCorrectValue()
        {
            var fileWorker = new FileWorker();
            PrivateObject privateObject = new PrivateObject(fileWorker);
            var privateFunction = privateObject.Invoke("GetSafeFilename", @"Folder:?<>*/\_Name:");
            NUnit.Framework.Assert.AreEqual(privateFunction, "Folder________Name_");
        }
    }
}