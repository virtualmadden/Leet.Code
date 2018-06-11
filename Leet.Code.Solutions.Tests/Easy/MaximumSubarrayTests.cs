using System;
using System.Collections.Generic;
using FluentAssertions;
using Leet.Code.Solutions.Easy;
using NUnit.Framework;

namespace Leet.Code.Solutions.Tests.Easy
{
    [TestFixture]
    public class MaximumSubarrayTests
    {
        [SetUp]
        public void SetUp()
        {
            _solution = new MaximumSubarraySolution();
        }

        private static readonly List<Tuple<int[], int>> TestCases = new List<Tuple<int[], int>>
        {
            new Tuple<int[], int>(new[] {-2, 1, -3, 4, -1, 2, 1, -5, 4}, 6)
        };

        private MaximumSubarraySolution _solution;

        [TestCaseSource(nameof(TestCases))]
        public void ShouldReturnTheLargestSum(Tuple<int[], int> testCase)
        {
            _solution.MaxSubArray(testCase.Item1).Should().Be(testCase.Item2);
        }
    }
}