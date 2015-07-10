/*
        ShutUp! v .0.2 - Shuts down the PC using shutdown.exe provided with Windows.
        Developed becasue I was too lazy to get up in the middle of the night to shut down
        my computer when I'm finished watching movies.
 
        Copyright (C) 2014 Christopher Ilkow

        This program is free software: you can redistribute it and/or modify
        it under the terms of the GNU General Public License as published by
        the Free Software Foundation, either version 3 of the License, or
        (at your option) any later version.

        This program is distributed in the hope that it will be useful,
        but WITHOUT ANY WARRANTY; without even the implied warranty of
        MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
        GNU General Public License for more details.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;
namespace ShutUp_
{
    class ShutUp
    {
        public void StartShutdown(int ms)
        {
            Thread.Sleep(ms);
            Console.WriteLine("ohai");
            Process.Start("shutdown.exe", "-s -t " + ms * 1000);
        }
        public void StopShutdown()
        {
            Process.Start("shutdown.exe ", "-a");
            Console.WriteLine("bye");
        }
    }
}
