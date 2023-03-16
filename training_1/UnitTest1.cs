
using logic__1;

namespace training_1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_Are_1()
        {
            //Arrange 

            int expected_area = 48;
            

            //Act 

            var l = new logic_1();
            int result = l.Are(6, 8);

            //Assert 
            Assert.AreEqual(expected_area, result);



        }
    }
}

