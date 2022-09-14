namespace UnitTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            //getting relative filepath
            string path = System.IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory + @"..\..\..\..\", "SampleText.txt");

            var result = WordCounter.WordCounter.wordCount(path);
            //performing test
            Assert.That(result, Is.EqualTo("6  85  474"));
        }
    }
}