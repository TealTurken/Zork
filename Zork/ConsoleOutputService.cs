﻿using System;
using Zork.Common;

namespace Zork
{
    internal class ConsoleOutputService : IOutputService
    {

        public void Write(string value)
        {
            Console.Write(value);
        }

        public void WriteLine(string value)
        {
            Console.WriteLine(value);
        }
        public void Clear()
        {
            Console.Clear();
        }
    }
}
