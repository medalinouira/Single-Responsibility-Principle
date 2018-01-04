///
/// Copyright © Mohamed Ali NOUIRA. All rights reserved.

using System;

namespace SingleResponsibilityPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            ConsoleWriter consoleWriter = new ConsoleWriter();

            Coach coach = new Coach(player, consoleWriter);

            coach.CoachPlayer();
            coach.ChangePlayer();

            Console.Read();
        }
    }
}
