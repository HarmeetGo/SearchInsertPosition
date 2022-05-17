using LeetCode1;
namespace UnitTest1
{
    public class UnitTest1
    {
        [Theory]

        [InlineData(new int[] { 1, 2, 4, 5 }, 3, 2)]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 6, 5)]
        public void SearchInsertPositionTest(int[] nums, int target, int expected)
        {
            var actual = SearchInsertPosition.SearchPosition(nums, target);

            Assert.Equal(expected, actual);
        }
    }
}