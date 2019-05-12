using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleDrawing.Commands
{
    public class CreateCanvasCommand : ICommand
    {
        private int _width;
        private int _height;

        public Canvas Execute()
        {
            return new Canvas(_width, _height);
        }

        public void Parse(List<string> args)
        {
            if (args == null || !args.Any())
                throw new ArgumentNullException("Missing command arguments");

            if (args.Count != 2)
                throw new ArgumentException("Invalid number of arguments: 2 - width & height");

            if(!int.TryParse(args[0], out _width) || _width <= 0)
                throw new ArgumentException("width should be a positive number");

            if (!int.TryParse(args[1], out _height) || _height <= 0)
                throw new ArgumentException("height should be a positive number");
        }
    }
}
