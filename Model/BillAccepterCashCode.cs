namespace INET.Lab4
{
    public class BillAccepterCashCode : Model
    {
        public override string FindDevice(Model model)
        {
            port.BaudRate = 9600;
            port.Parity = Parity.Even;
            port.Handshake = Handshake.RequestToSend;
            return Find(port);
        }
    }
}