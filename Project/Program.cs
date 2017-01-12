using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Solution
    {
        /*
         * Learning the dance of Kariakoo is not as easy as it sounds, but if you apply some basic
         * rules from the beginning, you can quickly become a Kariakoo master.
         * The first thing you need to know is that you can only move forward, or backward. When
         * moving backward, your number of steps will be negative.
         * 
         * This dance asks every performer to follow a precise sequence of steps:
         * Stage 0 : First, get away from obstacles by setting up your starting point at position 0
         * Stage 1 : Take one step forward (+1 step)
         * Stage 2 : Take two steps backward (-2 steps)
         * To follow, the steps as well as the direction you will have to take in your next move will
         * each time be obtained thanks to a specific calculation: the number of steps you took on the
         * previous stage minus the number of steps you took on the penultimate stage (the second-last
         * stage).
         * 
         * That is, on stage 3, a dancer will have to take 3 steps backwards (-2 - 1).
         */
        public static int GetPositionAt(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            if (n == 2) return -1;

            int pos = -1;
            var prev = -2;
            var penu = 1;
            for (var i = 3; i < n ; i++)
            {
                var delta = prev - penu;
                penu = prev;
                prev = delta;
                pos += delta;
            }
            return pos + prev - penu;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("How many steps ?");
            var stepCount = int.Parse(Console.ReadLine());

            Console.WriteLine("The kariakoo dancer is at position : {0}", Solution.GetPositionAt(stepCount));
        }
    }
}