using NUnit.Framework;

namespace kids_with_the_greatest_number_of_candies
{
    public class KidsWithCandiesTests
    {
        [Test]
        public void RunTestWithFors()
        {
            var expectedArray = new bool[]{
                true,true,true,false,true
            };

            var inputArray = new int[]{
                2,3,5,1,3
            };

            var extraCandies = 3;

            var result = Solutions.KidsWithCandiesTwoFors(inputArray, extraCandies);

            Assert.AreEqual(expectedArray, result);
        }

        [Test]
        public void RunTestWithMax()
        {
            var expectedArray = new bool[]{
                true,true,true,false,true
            };

            var inputArray = new int[]{
                2,3,5,1,3
            };

            var extraCandies = 3;

            var result = Solutions.KidsWithCandieWithMax(inputArray, extraCandies);

            Assert.AreEqual(expectedArray, result);
        }

        [Test]
        public void RunTestWithLinq()
        {
            var expectedArray = new bool[]{
                true,true,true,false,true
            };

            var inputArray = new int[]{
                2,3,5,1,3
            };

            var extraCandies = 3;

            var result = Solutions.KidsWithCandieWithLinq(inputArray, extraCandies);

            Assert.AreEqual(expectedArray, result);
        }
    }
}