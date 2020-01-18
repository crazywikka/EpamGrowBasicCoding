using NUnit.Framework;


namespace TestFindMaxValue
{
    public class Tests
    {

        [Test]
        public void FindMaxValue74()
        {
            int[] mass = new int[] { 2, 15, 3, 46, 22, 74, 32, 11, 4 };
            int result = 74;
            int maxValue = basicCodingEpam.Program.findMaxValue(mass);
            Assert.AreEqual(maxValue, result);
        }
    }
}