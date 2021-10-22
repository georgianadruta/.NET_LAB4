namespace INET.Lab4
{
    public class CoinAccepterNri : Model
    {
        public override string FindDevice(Model model)
        {
            port.BaudRate = 19200;
            port.Parity = Parity.Odd;
            port.Handshake = Handshake.XOnXOff;
            return Find(port);         
        }
    }
}