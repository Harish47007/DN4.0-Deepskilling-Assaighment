using System;

public class Logger
{
    private static Logger instance;
    private static readonly object lockObj = new object();
    private Logger()
    {
        Console.WriteLine("Logger initialized.");
    }
    public static Logger GetInstance()
    {
        if (instance == null)
        {
            lock (lockObj)
            {
                if (instance == null)
                {
                    instance = new Logger();
                }
            }
        }
        return instance;
    }

    public void Log(string message)
    {
        Console.WriteLine($"[LOG] {message}");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Logger logger1 = Logger.GetInstance();
        logger1.Log("This is the first log message.");

        Logger logger2 = Logger.GetInstance();
        logger2.Log("This is the second log message.");

        if (logger1 == logger2)
        {
            Console.WriteLine("Both logger instances are the same. Singleton works!");
        }
        else
        {
            Console.WriteLine("Different instances. Singleton failed.");
        }
    }
}
