namespace SOLID.OCP
{
    public class DcpTerminal : BankTerminal
    {
        public override BankTerminal CreateBankTerminal(BankTerminal model)
        {
            return new DcpTerminal();
        }
    }
}