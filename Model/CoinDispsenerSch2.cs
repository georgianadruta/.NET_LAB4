namespace INET.Lab4
{
    public class CoinDispsenerSch2 : Model
    {
        public override string FindDevice(Model model)
        {
            port.BaudRate = 4800;
            port.Parity = Parity.Even;
            port.Handshake = Handshake.None;
            return Find(port);           
        }
    }
}