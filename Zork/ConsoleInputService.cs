using System;
using Zork.Common;

namespace Zork
{
    internal class ConsoleInputService : IInputService
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
