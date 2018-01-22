using System;
using Terminal.Service.Main.Source.BO;
using Terminal.Service.Main.Source.DL;
using Terminal.Service.Main.Source.Interfaces;

namespace Terminal.Service.Main.Source.BL
{
    internal class TerminalCardPassBL : ITerminalCardPassBL
    {

        public int Add(TerminalCardPass bo)
        {
            int rs = -1;

            try
            {
                using (TerminalCardPassDL dl = new TerminalCardPassDL())
                { rs = dl.Insert(bo); }
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
