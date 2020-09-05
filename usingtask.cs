﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace ConsoleApp47
{
    class Program
    {
        static void Main(string[] args)
        {
            string srcFile = args[0];
            Action<object> FileCopyAction = (object state) => 
            {
                String[] paths = (String[])state;
                File.Copy(paths[0], paths[1]);
                Console.WriteLine("TaskID:{0} ThreadID:{1} {2} was copied to {3}",
                    Task.CurrentId, Thread.CurrentThread.ManagedThreadId, paths[0], paths[1]);
            };
            Task t1 = new Task(FileCopyAction, new string[] { srcFile, srcFile + ".copy1" });
            Task t2 = Task.Run(() => {
                FileCopyAction(new string[] { srcFile, srcFile + ".copy2" });
            });

            t1.Start(); //비동기실행
            Task t3 = new Task(FileCopyAction, new string[] { srcFile, srcFile + ".copy3" });
            t3.RunSynchronously(); //동기실행

            t1.Wait();
            t2.Wait();
            t3.Wait();
        }
    }
}
