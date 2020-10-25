using System;
using System.Threading;



class Program
{
    static void Main(string[] args)
    {
        Mutex oneMutex = null;
        const String MutexName = "RUNMEONLYONCE";
        try
        {
            oneMutex = Mutex.OpenExisting(MutexName);
        }
        catch (WaitHandleCannotBeOpenedException)
        {

        }
        if (oneMutex == null)
        {
            oneMutex = new Mutex(true, MutexName);
        }
        else
        {

            oneMutex.Close();
            return;
        }
        Console.WriteLine("Our Application");

    }
}