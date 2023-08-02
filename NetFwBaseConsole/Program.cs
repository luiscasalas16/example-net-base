﻿using System;
using System.Diagnostics;

namespace NetFwBaseConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Hello World");
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex.ToString());

                Console.WriteLine(ex.ToString());
            }

            Console.Write("Press enter to close this window . . .");
            Console.ReadLine();
        }
    }
}