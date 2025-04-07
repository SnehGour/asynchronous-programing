/*

Cosider using async code when you have to deail with
1. I/O bound operations
2. API calls
3. CPU intensive code



------------------------------------------
1. Types of Async Pattern used by Microsoft

A. Event-Based Asynchronosus Patterns(EAP)
ex: Event handler delegates, EventArg-derived types, ReadASync,ReadCompleted

- Microsoft no longer recommend this pattern


B.Asynchronous Programming Model (APM)
ex: Begin/End, BeginInvoke/EndInvoke

- Micosoft also dont recommend this pattern.

C. Task-Based Asnchronous Patterns(TAP)  <=======
ex: Task.Run, Task.WaitAny, Task.WhenAny

- Recommened by Microsoft

--------------------------------------------



*/

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Main Thread Starts....");
        var resultTask = Task.Run(() => TaskClass.task01(1000));
        Console.WriteLine("I am sleeping for 3 seconds");
        Thread.Sleep(1000);
        Console.WriteLine("Yewah, I'm up");
        resultTask.ContinueWith(completedTask =>
        {

            var result = resultTask.Result;
            foreach (var item in result)
            {
                Console.Write($"{item} ");
            }
        });
        Console.WriteLine("Main Thread Ends....");
        Console.ReadLine();
    }
}