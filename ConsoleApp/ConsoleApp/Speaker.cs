using System;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("ConsoleApp.Tests")]

namespace ConsoleApp
{
    public class Speaker
    {
        public void PublicMethod()
        {
            Console.WriteLine("public");
        }
        internal void InternalMethod()
        {
            Console.WriteLine("internal");
        }

        protected void ProtectedMethod()
        {
            Console.WriteLine("protected");
        }

        private void PrivateMethod()
        {
            Console.WriteLine("private");
        }
    }
}