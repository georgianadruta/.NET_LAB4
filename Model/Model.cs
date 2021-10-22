namespace INET.Lab4
{
    public abstract class Model
    { 
        public SerialPort port = new SerialPort();
        public abstract string FindDevice(Model model);
        public string Find(SerialPort port)
        {
            string[] names = SerialPort.GetPortNames();
            foreach(string name in names)
            {
                port.Write("special code");
                if (port.ReadByte() == 0 )
                    return name;
            }
            return null;
        }
    }
}