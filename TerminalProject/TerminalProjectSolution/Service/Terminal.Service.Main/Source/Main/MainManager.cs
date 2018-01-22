using System;
using Terminal.Service.Main.Source.BL;
using Terminal.Service.Main.Source.Interfaces;

namespace Terminal.Service.Main.Source.Main
{
    public class MainManager
    {
        #region [ Instance ]

        private static Lazy<MainManager> lazyMan =
            new Lazy<MainManager>(() => new MainManager());

        public static MainManager Instance { get { return lazyMan.Value; } }

        #endregion

        #region [ Private Ctor ]

        private MainManager()
        {
        }

        #endregion

        #region [ Lazy Properties ]

        private Lazy<ITerminalBL> lazyTerminal = new Lazy<ITerminalBL>(() => new TerminalBL());

        internal ITerminalBL TerminalBL { get { return lazyTerminal.Value; } }

        private Lazy<ICardBL> lazyCard = new Lazy<ICardBL>(() => new CardBL());

        internal ICardBL CardBL { get { return lazyCard.Value; } }

        private Lazy<ITerminalPassBL> lazyTermPass = new Lazy<ITerminalPassBL>(() => new TerminalPassBL());

        internal ITerminalPassBL TerminalPassBL { get { return lazyTermPass.Value; } }

        private Lazy<ITerminalCardPassBL> lazyTermCardPass = new Lazy<ITerminalCardPassBL>(() => new TerminalCardPassBL());

        internal ITerminalCardPassBL TerminalCardPassBL { get { return lazyTermCardPass.Value; } }

        #endregion


        #region [ Methods ]

        public int AddPass(string cardNo, string terminalNo)
        {
            DateTime dt = DateTime.Now;
            int res = 0;
            try
            {
                res = this.TerminalCardPassBL.Add(
                    new BO.TerminalCardPass { CardNo = cardNo, TerminalNo = terminalNo, RequestTime = dt }
                );
            }
            catch (Exception ex)
            {
                res = -1;
                // Log Exception
                throw;
            }

            return res;
        }

        #endregion
    }
}
