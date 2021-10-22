namespace INET.Lab4
{
    public class CoinDispenserCube4 : Model
    {
        public override string FindDevice(Model model)
        {
            port.BaudRate = 9600;
            port.Parity = Parity.Space;
            port.Handshake = Handshake.None;
            return Find(port);             
        }
    }
}