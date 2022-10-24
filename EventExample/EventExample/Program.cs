using System;
using System.Timers;

namespace EventExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //事件拥有者 
            Timer timer = new Timer();
            timer.Interval = 1000;
            //事件响应者
            Boy boy = new Boy();
            Girl girl = new Girl();
            //事件订阅 timer.Elapsed是事件，boy.Action是事件处理器
            timer.Elapsed += boy.Action;
            timer.Elapsed += girl.Action;
            timer.Start();
            Console.ReadLine();
        }
    }

    class Boy
    {
        internal void Action(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine("Jump!");
        }
    }

    class Girl
    {
        internal void Action(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine("Sing!");
        }
    }
}
