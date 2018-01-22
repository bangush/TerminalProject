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
    internal class CardBL : ICardBL
    {
        public Card GetCard(long id)
        {
            Card bo = null;

            try
            {
                DataTable dt = null;
                using (CardDL dl = new CardDL())
                {
                    dt =
                        dl.GetWhereChangeColumnList(new Card { Id = id });
                }

                if (dt == null || dt.Rows.Count == 0)
                    return bo;

                List<Card> boLst = dt.ToList<Card>(false);
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

        public Card GetTerminal(string cardNo, bool isDec = false)
        {
            Card bo = null;

            try
            {
                DataTable dt = null;
                using (CardDL dl = new CardDL())
                {
                    Card c = new Card();

                    if (isDec)
                        c.CardNoDec = cardNo;
                    else
                        c.CardNo = cardNo;

                    dt =
                        dl.GetWhereChangeColumnList(c);
                }

                if (dt == null || dt.Rows.Count == 0)
                    return bo;

                List<Card> boLst = dt.ToList<Card>(false);
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
