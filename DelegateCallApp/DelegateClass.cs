using System;

namespace DelegateCallApp
{
    internal delegate void PrivateMethodWithParameter(string a);

    internal delegate void PrivateMethodWithoutParameter();

    internal delegate bool ReturnValueMethod(bool val);
    public class DelegateClass
    {       
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
    }



}
