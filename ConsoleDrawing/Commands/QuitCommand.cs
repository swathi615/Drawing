using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleDrawing.Commands
{
    public class QuitCommand : ICommand
    {
        public void Parse(List<string> cmd)
        {
            if (cmd == null)
                throw new ArgumentNullException("Missing command arguments");

            if (cmd.Any())
                throw new ArgumentException("Should have no arguments");
        }

        public Canvas Execute()
        {
            Environment.Exit(Environment.ExitCode);
            return null;
        }
    }
}
