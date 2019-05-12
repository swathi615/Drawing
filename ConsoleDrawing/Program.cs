using System;
using System.Linq;
using ConsoleDrawing.Commands;

namespace ConsoleDrawing
{
    class Program
    {
        static Canvas canvas = null;
        static void Main(string[] args)
        {
            while(true)
            {
                try
                {
                    Menu.Display();
                    var input = Menu.ReadUserInput();
                    var action = input[0];
                    var paramList = input.Skip(1).ToList();
                    var command = CommandFactory.CreateCommandInstance(action, canvas);
                    command.Parse(paramList);
                    canvas = command.Execute();
                    Console.WriteLine(canvas.ToString());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
        }
    }
}
