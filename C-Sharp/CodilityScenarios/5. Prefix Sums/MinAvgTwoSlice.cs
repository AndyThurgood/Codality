namespace CodilityScenarios
{
    /// <summary>
    /// Write a function that, given a non-empty zero-indexed array A 
    /// consisting of N integers, returns the starting position of the slice 
    /// with the minimal average. If there is more than one slice with a 
    /// minimal average, you should return the smallest starting position of 
    /// such a slice.
    /// </summary>
    public class MinAvgTwoSlice
    {
        public int solution(int[] numericArray)
        {
            //Guard against empty parameter
            if(numericArray.Length == 0){
                return -1;
            }

            // Comparison and strorage values
            double minimumSliceAverage = int.MaxValue;
            int returnValue = 0;

            // Step through the array
            for (int i = 0; i < numericArray.Length -1; i ++)
            {
                // Get the first mininal slice value of 2
                int twoSliceValue = (numericArray[i] + numericArray[i + 1]);
                int threeSliceValue = int.MaxValue;

                // Get the next slice (3) value, we don't need 4+ as that would contain
                // a 2 slice which would be smaller
                if(i + 2 < numericArray.Length){
                    threeSliceValue = twoSliceValue + numericArray[i + 2];
                }

                // Generate averages
                double sliceAverage = (twoSliceValue / 2.0) < (threeSliceValue / 3.0) ? 
                                      (twoSliceValue / 2.0) : (threeSliceValue / 3.0);

                // Store results
                if(sliceAverage < minimumSliceAverage){
                    minimumSliceAverage = sliceAverage;
                    returnValue = i;
                }
            }

            return returnValue;
        }
    }
}
