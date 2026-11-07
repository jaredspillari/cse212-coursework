public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // Create an array using the length parameter.
        // Use a for loop to go through each position.
        // Multiply the number by the current position plus one.
        // Store each multiple in the array.
        // Return the completed array.
        double[] result = new double[length];

        for (int i = 0; i < length; i++ )
        {
            result[i] = number *(i + 1);
        }


        return result; // replace this return statement with your own
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        //Create and empty tempory list
        //copy the last 'amount' to the temporary list created 
        //move the remaining elements after the last amount move
        //remove all elements from the original list
        //copy the last amount back to the list and then the rest ito the original list

        List<int> rotated = new List<int>();

        for (int i = data.Count - amount; i < data.Count; i++)
        {
            rotated.Add(data[i]);
        }

        for (int i = 0 ; i < data.Count - amount; i++)
        {
            rotated.Add(data[i]);
        }

        data.Clear();

        foreach (int number in rotated)
        {
            data.Add(number);
        }

    }
}
 