using System;
using System.Collections.Generic;
using System.Linq;

namespace Zork.Common
{
    public class Command
    {
        public string Name { get; set; } // full command names

        public string[] Verbs { get; } // alt names for commands

        public Action<Game> Action { get; } 

        public Command (string name, IEnumerable<string> verbs, Action<Game> action)
        {
            Name = name;
            Verbs = verbs.ToArray();
            Action = action;
        }

        public override string ToString() => Name;
    }
}
