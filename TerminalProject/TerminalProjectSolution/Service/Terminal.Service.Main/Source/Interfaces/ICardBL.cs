using Terminal.Service.Main.Source.BO;

namespace Terminal.Service.Main.Source.Interfaces
{
    internal interface ICardBL
    {
        Card GetCard(long id);

        Card GetTerminal(string cardNo, bool isDec = false);
    }
}
