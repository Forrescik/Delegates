using System;

namespace DelegateCallApp
{
    internal delegate void PrivateMethodWithParameter(string a);

    internal delegate void PrivateMethodWithoutParameter();

    internal delegate bool ReturnValueMethod(bool val);

    internal delegate void PrivateMetodForAll();

    internal delegate void InsertDataDelegate(string userName);

    public class DelegateClass
    {
        private void InsertData(string userName)
        {
            Console.WriteLine(userName);
        }

        private void RunPrivateMethodWithoutParameter()
        {
            Console.WriteLine("Private Method Call Withot Parameter");
        }

        private void ReturnMethodWithParameter(string s)
        {
            Console.WriteLine(s);
        }

        private bool SwapValue(bool b)
        {
            return !b;
        }

        private void ReturnPrivateMethodForAll()
        {
            Console.WriteLine("I'm");
        }

        internal InsertDataDelegate GetInsertDataDelegate()
        {
            return InsertData;
        }

        internal PrivateMethodWithParameter GetPrivateMethodWithParameter()
        {
            return ReturnMethodWithParameter;
        }

        internal PrivateMethodWithoutParameter GetPrivateMethodWithoutParameter()
        {
            return RunPrivateMethodWithoutParameter;
        }

        internal ReturnValueMethod GetReturnValueMethod()
        {
            return SwapValue;
        }

        internal PrivateMetodForAll GetPrivateMethodForAll()
        {
            return ReturnPrivateMethodForAll;
        }
    }



}
