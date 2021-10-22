namespace SOLID.OCP
{
    public class BrpTerminal : BankTerminal
    {
        public override BankTerminal CreateBankTerminal(BankTerminal model)
        {
            return new BrpTerminal();
        }
    }
}