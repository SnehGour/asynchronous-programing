/*
Challenge: Create and Continue a Task
1. Write a function to calculate all the factors of a given positive number.
2. Execute the function with a task on a background thread.
3. When task is complete use continuation to log the results of the task to the console.
*/

public class TaskClass
{
    public static List<int> task01(int num)
    {
        List<int> positiveNumberFactorList = new();

        for (int i = 1; i <= num; i++)
        {
            if (num % i == 0)
            {
                positiveNumberFactorList.Add(i);
            }

        }

        return positiveNumberFactorList;
    }
}