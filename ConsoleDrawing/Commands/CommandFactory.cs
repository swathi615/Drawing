using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDrawing.Commands
{
    public static class CommandFactory
    {
        public static ICommand CreateCommandInstance(string cmd, Canvas canvas)
        {
            if (cmd == null || String.IsNullOrWhiteSpace(cmd))
                throw new ArgumentException("Invalid command");

            switch (cmd)
            {
                case "C":
                    return new CreateCanvasCommand();
                case "L":
                    return new CreateLineCommand(canvas);
                case "R":
                    return new CreateRectangleCommand(canvas);
                case "B":
                    return new FillAreaCommand(canvas);
                case "Q":
                    return new QuitCommand();
                default:
                    throw new ArgumentException($"Unsupported command: {cmd}");
            }
        }
    }
}
