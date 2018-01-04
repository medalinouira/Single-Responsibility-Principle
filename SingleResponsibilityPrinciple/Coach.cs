///
/// Copyright © Mohamed Ali NOUIRA. All rights reserved.

namespace SingleResponsibilityPrinciple
{
    #region class Coach
    public class Coach : ICoach
    {
        #region Fields
        private IPlayer iPlayer;
        IConsoleWriter iConsoleWriter;
        #endregion

        #region constructor
        public Coach(IPlayer iPlayer, IConsoleWriter iConsoleWriter)
        {
            this.iPlayer = iPlayer;
            this.iConsoleWriter = iConsoleWriter;
        }
        #endregion

        #region Methods
        public void CoachPlayer()
        {
            iPlayer.Coach();

            #region Not single responsability : coach and show the text on the console
            /*
            //Customize the message to show
            String messageToShow = "we coach a player.";
            messageToShow.ToUpper();

            //Show the message to show
            Console.WriteLine(messageToShow);
             * */
            #endregion

            #region Single responsability : coach and call the ConsoleWriter to show the text on the console
            iConsoleWriter.NotifyAction("we coach a player.");
            #endregion
        }

        public void ChangePlayer()
        {
            iPlayer.Change();

            #region Not single responsability : coach and show the text on the console
            /*
            //Customize the message to show
            String messageToShow = "WE CHANGE A PLAYER";
            messageToShow.ToLower();

            //Customize the message to show
            Console.WriteLine("We change a player.");
             * */
            #endregion

            #region Single responsability : coach and call the ConsoleWriter to show the text on the console
            iConsoleWriter.NotifyAction("We change a player.");
            #endregion
        }
        #endregion
    }
    #endregion
}
