using System.Collections.Generic;
using System.Linq;

namespace kids_with_the_greatest_number_of_candies
{
    public class Solutions
    {
        public static IList<bool> KidsWithCandiesTwoFors(int[] candies, int extraCandies)
        {
            var highestCandy = candies[0];
            foreach (var candy in candies)
            {
                if (candy > highestCandy)
                    highestCandy = candy;
            }
            var booleanCandies = new bool[candies.Length];
            for (int i = 0; i < candies.Length; i++)
            {
                booleanCandies[i] = (candies[i] + extraCandies) >= highestCandy;
            }

            return booleanCandies;
        }

        public static IList<bool> KidsWithCandieWithMax(int[] candies, int extraCandies)
        {
            var highestCandy = candies.Max();
            var booleanCandies = new bool[candies.Length];
            for (int i = 0; i < candies.Length; i++)
            {
                booleanCandies[i] = (candies[i] + extraCandies) >= highestCandy;
            }

            return booleanCandies;
        }

        public static IList<bool> KidsWithCandieWithLinq(int[] candies, int extraCandies)
        {
            var highestCandy = candies.Max();
            return candies.Select(x => (x + extraCandies) >= highestCandy).ToList();
        }
    }
}