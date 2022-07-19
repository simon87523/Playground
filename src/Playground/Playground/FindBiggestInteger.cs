namespace Playground
{
    internal static class FindBiggestInteger
    {
        public static int GetMax_1(int a, int b, int c)
        {
            if (a > b)
            {
                if (a > c)
                    return a;
                else
                    return c;
            }
            else
            {
                if (b > c)
                    return b;
                else
                    return c;
            }
        }


        /// <summary>
        ///     Finds the largest number in parameter
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns>largest number</returns>
        public static int GetMax_2(int a, int b, int c)
        {
            var max = a;
            if (b > max) max = b;
            if (c > max) max = c;

            return max;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static int GetMax_3(int[] values)
        {
            int max = values[0];
            for (int i = 1; i < 7; i++)
            {
                if (values[i] > max)
                    max = values[i];
            }
            return max;
        }
    }
}
