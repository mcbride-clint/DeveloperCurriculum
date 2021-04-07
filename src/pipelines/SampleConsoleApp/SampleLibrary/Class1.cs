using System;
using System.Linq;

namespace SampleLibrary
{
    public static class BasicMath
    {
        public static int Add(params int[] numbers)
        {
            return numbers.Sum();
        }
    }
}
