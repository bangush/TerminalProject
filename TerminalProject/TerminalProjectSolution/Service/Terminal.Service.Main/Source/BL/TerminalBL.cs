using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Terminal.Service.Main.Source.BO;
using Terminal.Service.Main.Source.DL;
using Terminal.Service.Main.Source.Interfaces;
using FreeLibrary.Extensions;

namespace Terminal.Service.Main.Source.BL
{
    internal class TerminalBL : ITerminalBL
    {
        public TerminalBO GetTerminal(string terminalNo)
        {
            TerminalBO bo = null;

            try
            {
                DataTable dt = null;
                using (TerminalDL dl = new TerminalDL())
                {
                    dt =
                        dl.GetWhereChangeColumnList(new TerminalBO { TerminalNo = terminalNo });
                }

                if (dt == null || dt.Rows.Count == 0)
                    return bo;

                List<TerminalBO> boLst = dt.ToList<TerminalBO>(false);
                if (boLst == null || boLst.Count == 0)
                    return bo;

                bo = boLst[0];
            }
            catch (Exception ex)
            {
                throw;
            }

            return bo;
        }

        public TerminalBO GetTerminal(long id)
        {
            TerminalBO bo = null;

            try
            {
                DataTable dt = null;
                using (TerminalDL dl = new TerminalDL())
                {
                    dt =
                        dl.GetWhereChangeColumnList(new TerminalBO { Id = id });
                }

                if (dt == null || dt.Rows.Count == 0)
                    return bo;

                List<TerminalBO> boLst = dt.ToList<TerminalBO>(false);
                if (boLst == null || boLst.Count == 0)
                    return bo;

                bo = boLst[0];
            }
            catch (Exception ex)
            {
                throw;
            }

            return bo;
        }
    }
}
