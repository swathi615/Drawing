﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDrawing
{
    static class Menu
    {
        const string MenuText = @"
Command 		Description
C w h           Create a new canvas of width w and height h.
L x1 y1 x2 y2   Create a new line from (x1,y1) to (x2,y2). Currently only
                horizontal or vertical lines are supported. Horizontal and vertical lines
                will be drawn using the 'x' character.
R x1 y1 x2 y2   Create a new rectangle, whose upper left corner is (x1,y1) and
                lower right corner is (x2,y2). Horizontal and vertical lines will be drawn
                using the 'x' character.
B x y c         Fill the entire area connected to (x,y) with ""colour"" c. The
                behaviour of this is the same as that of the ""bucket fill"" tool in paint
                programs.
Q               Quit the program.";

        public static void Display()
        {
            Console.WriteLine(MenuText);
        }

        public static List<string> ReadUserInput()
        {
            Console.WriteLine("Please enter the command:");
            var input = Console.ReadLine();
            return input.Split(' ')
                .Where(x => !string.IsNullOrEmpty(x))
                .ToList();
        }
    }
}
