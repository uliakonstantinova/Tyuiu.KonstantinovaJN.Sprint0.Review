using Tyuiu.KonstantinovaJN.Sprint0.TaskReview.V0.Lib;
namespace Tyuiu.KonstantinovaJN.Sprint0.TaskReview.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalc()
        {
            DataService ds = new DataService();
            int x = 2;
            int y = 12;
            int z = 3;
            var res = ds.Calculate(x, y, z);
            Assert.AreEqual(85, res);

        }
    }
}