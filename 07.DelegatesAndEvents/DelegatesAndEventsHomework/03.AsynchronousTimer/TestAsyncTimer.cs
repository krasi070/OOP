namespace _03.AsynchronousTimer
{
    using System;

    class TestAsyncTimer
    {
        static void Main()
        {
            AsyncTimer asyncTimer = new AsyncTimer(a => Console.WriteLine(a), 10, 1000);

            asyncTimer.Run();
        }
    }
}
