using Terminal.Service.Main.Source.BO;

namespace Terminal.Service.Main.Source.Interfaces
{
    public interface ITerminalBL
    {
        TerminalBO GetTerminal(long id);

        TerminalBO GetTerminal(string terminalNo);
    }
}
