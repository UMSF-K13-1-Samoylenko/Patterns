﻿using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Component component = new ConcreteComponents();
            component = new DecoratorA(component);
            component = new DecoratorB(component);
            Console.WriteLine($"Description:{component.Description()}{Environment.NewLine}Price:{component.Price()}");
            Console.ReadKey();
        }
    }
}
