///
/// Copyright © Mohamed Ali NOUIRA. All rights reserved.

using System;

namespace SingleResponsibilityPrinciple
{
    #region class ConsoleWriter
    class ConsoleWriter : IConsoleWriter
    {
        public void NotifyAction(string message)
        {
            Console.WriteLine(message);
        }
    }
    #endregion
}
