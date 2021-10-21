using System;
using System.IO.Ports;

namespace SOLID.OCP.Violation
{
    public class DeviceFinder
    {
        public string FindDevice(DeviceModel model)
        {
            SerialPort port = new SerialPort();
            switch (model)
            {
                case DeviceModel.BillAccepterCashCode:
                {
                        SetValuesForPort(port, 9600, Parity.Even, Handshake.RequestToSend);
                        return Find(port);
                    }
                case DeviceModel.BillDispenserEcdm:
                    {  
                        SetValuesForPort(port, 4800, Parity.Mark, Handshake.RequestToSendXOnXOff);
                        return Find(port);                        
                    }              
                case DeviceModel.CoinAccepterNri:
                    {
                        SetValuesForPort(port, 19200, Parity.Odd, Handshake.XOnXOff);
                        return Find(port);                        
                    }
                case DeviceModel.CoinDispenserCube4:
                    {  
                        SetValuesForPort(port, 9600, Parity.Space, Handshake.None);
                        return Find(port);                        
                    }
                case DeviceModel.CoinDispsenerSch2:
                    {
                        SetValuesForPort(port, 4800, Parity.Even, Handshake.None);
                        return Find(port);                        
                    }
                default:
                    throw new ArgumentException($"Unknown model: {model}.");
            }            
        }

        private string Find(SerialPort port)
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

        private void SetValuesForPort(SerialPort port, int number, Parity parity, Handshake handshake)
        {
            port.BaudRate = number;
            port.Parity = parity;
            port.Handshake = handshake;
        }
    }
}
