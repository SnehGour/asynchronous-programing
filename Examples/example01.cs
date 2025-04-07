/*

A. CASE1: Call this static methid in main normally
- To understand the thread blocking
- There is noting async about it 


B. CASE:2 Call it using Task.Run
- var dataTask = Task.Run(Example1.example1);   
- Important thing to notice is Example 1 Ends... will not execute as Main Thread will not wait, and Example 1 is being handled by worker thread.
- This is pure asynchronous program. Both the threads are independent of each other.
- Again, Here imp point is Main Thread will not wait for Example 1 to finish.
- In order to finish the Task of worker thread we have to block the Main Thread and make code sync at some point of time. Because program will not be in sync
- For that we can use dataTask.Wait(); which is a blocking operation.
- To get the data from the calling method use
- var result = dataTask.Result;

*/

public static class Example1
{
    public static void example1()
    {
        Console.WriteLine("Example 1 starts..");
        Thread.Sleep(1000);
        Console.WriteLine("Example 1 Ends..");
    }
}