using System.Collections.Generic;

namespace ConsoleDrawing.Commands
{
    public interface ICommand
    {
        void Parse(List<string> cmdArgs);
        Canvas Execute();
    }
}
