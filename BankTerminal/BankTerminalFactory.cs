using System;

namespace SOLID.OCP
{
    public class BankTerminalFactory
    {
        public static IBankTerminal CreateBankTerminal(BankTerminalModel model)
        {
            switch (model)
            {
                case BankTerminalModel.Brp:
                    return new BrpTerminal();
                case BankTerminalModel.Dcp:
                    return new DcpTerminal();
                default:
                    throw new ArgumentException("Unknown model");
            }
        }
    }
}