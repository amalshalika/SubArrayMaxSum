namespace MaximumSum
{
    public class MaximumSumSubArray
    {
        public int GetMaximumSubArraySum(int[] mainArray)
        {
            int maximumSum = mainArray[0];
            int sum = mainArray[0];
            for (int i = 1; i < mainArray.Length; i++)
            {
                sum += mainArray[i];
                sum = mainArray[i] > sum ? mainArray[i] : sum;
                maximumSum = sum > maximumSum ? sum : maximumSum;
            }
            return maximumSum;
        }
    }
}
