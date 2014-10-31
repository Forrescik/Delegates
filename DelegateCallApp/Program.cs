﻿using System;

namespace DelegateCallApp
{
    public class Program
    {
        static void Main()
        {
            var dc = new DelegateClass();
            dc.GetInsertDataDelegate()("sebastian");
            dc.GetPrivateMethodWithParameter()("It's work");
            dc.GetPrivateMethodWithoutParameter()();
            Console.WriteLine(dc.GetReturnValueMethod()(false));
            Console.ReadLine();
        }
    }
}
