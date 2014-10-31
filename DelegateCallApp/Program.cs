using System;

namespace DelegateCallApp
{
    public class Program
    {
        static void Main()
        {
            var dc = new DelegateClass();
            dc.GetPrivateMethodWithParameter()("seba1");
            dc.GetPrivateMethodWithoutParameter()();
            Console.WriteLine(dc.GetReturnValueMethod()(false));
            Console.ReadLine();
        }
    }
}
