using System.Collections;

namespace LeetCode.Solutions.Tests
{
    public class TwoSumsTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { new int[4] { 2, 7, 11, 15 }, 9, new int[2] { 0, 1 } };
            yield return new object[] { new int[3] { 3, 2, 4 }, 6, new int[2] { 1, 2 } };
            yield return new object[] { new int[2] { 3, 3 }, 6, new int[2] { 0, 1 } };
        }

        IEnumerator IEnumerable.GetEnumerator()  => GetEnumerator();
    }
}
