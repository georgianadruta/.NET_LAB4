namespace INET.Lab4
{
    public class BillDispenserEcdm : Model
    {
        public override string FindDevice(Model model)
        {
            port.BaudRate = 4800;
            port.Parity = Parity.Mark;
            port.Handshake = Handshake.RequestToSendXOnXOff;
            return Find(port);
        }
    }
}