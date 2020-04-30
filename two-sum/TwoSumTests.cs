using System;
using System.Collections;
using System.Collections.Generic;
using Xunit;

namespace two_sum
{
    public class TwoSumTests
    {
        [Fact]
        public void MustReturnIndexesOfNumbers()
        {
            var sut = new Solution();

            var indexArray = sut.TwoSumBruteForce(new int[] {2, 7, 11, 15}, 18);

            Assert.Equal(indexArray[0], 1);
            Assert.Equal(indexArray[1], 2);
        }

        [Fact]
        public void MustReturnIndexesOfNumbersDictionary()
        {
            var sut = new Solution();

            var indexArray = sut.TwoSumHashTable(new int[] {2, 7, 11, 15}, 18);

            Assert.Equal(indexArray[0], 1);
            Assert.Equal(indexArray[1], 2);
        }
        
        [Fact]
        public void MustReturnIndexesOfNumbersDictionaryOnePass()
        {
            var sut = new Solution();

            var indexArray = sut.TwoSumHashTableOnePass(new int[] {2, 7, 11, 15}, 18);

            Assert.Equal(indexArray[0], 1);
            Assert.Equal(indexArray[1], 2);
        }
    }

    public class Solution {
        // Time complexity: O(n²)
        public int[] TwoSumBruteForce(int[] nums, int target) {
            for(int i = 0; i < nums.Length; i++){
                for(int j = i + 1; j < nums.Length; j++){
                    if(nums[i] + nums[j] == target) return new int[] {i,j};
                }
            }
            return new int[1];
        }

        // Time complexity: O(n)
        public int[] TwoSumHashTable(int[] nums, int target){
            var dictionary = new Dictionary<int, int>();
            for(int i = 0; i < nums.Length; i++){
                dictionary.Add(nums[i], i);
            }

            for(int i = 0; i < nums.Length; i++){
                int complement = target - nums[i];
                if(dictionary.ContainsKey(complement) && dictionary[complement] != i)
                    return new int[] {i,  dictionary[complement]};
            }
            throw new ArgumentException("No two sum solution");
        }


        public int[] TwoSumHashTableOnePass(int[] nums, int target){
            var dictionary = new Dictionary<int, int>();
            for(int i = 0; i < nums.Length; i++){
                int complement = target - nums[i];
                if(dictionary.ContainsKey(complement)){
                    return new int[] {dictionary[complement], i};
                }
                dictionary.Add(nums[i], i);
            }
            throw new ArgumentException("No two sum solution");
        }
    }
}
