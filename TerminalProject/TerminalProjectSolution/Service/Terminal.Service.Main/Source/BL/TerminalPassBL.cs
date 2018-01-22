using System;
using Terminal.Service.Main.Source.BO;
using Terminal.Service.Main.Source.DL;
using Terminal.Service.Main.Source.Interfaces;

namespace Terminal.Service.Main.Source.BL
{
    internal class TerminalPassBL : ITerminalPassBL
    {
        public int Add(TerminalPass bo)
        {
            int rs = -1;

            try
            {
                using (TerminalPassDL dl = new TerminalPassDL())
                {
                    rs = dl.Insert(bo);
                }
            }
            catch (Exception ex)
            {
                rs = -2;
                throw;
            }

            return rs;
        }
    }
}
