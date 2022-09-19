using NUnit.Framework;
using UnityEngine;

namespace Tests
{
    public class CombinedFilterTest
    {
        [Test]
        public void CombinedFilterSimple()
        {
            int[] input = { 4, 3, 3, 10, 1, 3, 5, 10, 3, 6 };  
            int[] output = CombinedFilter.combinedFilter(input);
            int[] expected = { 1, -1, -1, 1, 1, -1, 2, 1, -1, -1 };

            CollectionAssert.AreEqual(expected, output);
        }
    }
}

