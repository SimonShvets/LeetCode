using FluentAssertions;

namespace LeetCode.Solutions.Tests
{
    public class TwoSumsTests
    {
        [Theory]
        [ClassData(typeof(TwoSumsTestData))]
        public void ShouldPass_WhenArgumentsAreValid2(int[] nums, int target, int[] expected)
        {
            //given
            //when
            var actual = Solutions.TwoSum(nums, target);

            //then
            expected.Should().Equal(actual);
        }
    }
}