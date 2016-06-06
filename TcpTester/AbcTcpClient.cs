using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace TcpTester
{
    class AbcTcpClient
    {
        private readonly string _ip;
        private readonly int _port;
        private readonly bool _addHeader;
        private readonly int _headerLength;
        private readonly string _encoding;

        public AbcTcpClient(string ip,int port,string encoding, bool addHeader,int headerLength)
        {
            _ip = ip;
            _port = port;
            _addHeader = addHeader;
            _headerLength = headerLength;
            _encoding = encoding;
        }

        public string Send(string request)
        {
            byte[] result = new byte[0];
            string receiveMessage = string.Empty;
            Encoding encoding = _encoding == "" ? Encoding.Default : Encoding.GetEncoding(_encoding);

            TcpClient tcpClient;
            try
            {
                tcpClient = new TcpClient();
                tcpClient.Connect(_ip, _port);
            }
            catch (Exception ex)
            {
                throw ;
            }
            NetworkStream netStream = tcpClient.GetStream();
            try
            {
                //添加报文长度头
                if (_addHeader && _headerLength > 0)
                {
                    string messageHeader = encoding.GetBytes(request).Length.ToString().PadLeft(_headerLength, '0');
                    request = messageHeader + request;
                }

                if (!netStream.CanWrite)
                    throw new Exception("NetStream不可写！");
                Byte[] sendBytes = encoding.GetBytes(request);
                netStream.Write(sendBytes, 0, sendBytes.Length);
            }
            catch (Exception ex)
            {
                netStream.Close();
                tcpClient.Close();
                throw ;
            }
            try
            {

                if (!netStream.CanRead)
                    throw new Exception("NetStream不可读！");
                else
                {
                    byte[] bytes = new byte[tcpClient.ReceiveBufferSize];
                    byte[] toalBytes = new byte[0];
                    int readSize = netStream.Read(bytes, 0, (int)tcpClient.ReceiveBufferSize);
                    if (readSize > 0)
                    {
                        byte[] tempByte1 = new byte[readSize];
                        Array.Copy(bytes, 0, tempByte1, 0, readSize);
                        toalBytes = toalBytes.Concat(tempByte1).ToArray();

                        byte[] lenBytes = new byte[_headerLength];
                        Array.Copy(toalBytes, 0, lenBytes, 0, _headerLength);
                        int packSize = _headerLength > 0 ? Int32.Parse(encoding.GetString(lenBytes)) : 0;
                        int currentSize = readSize - lenBytes.Length;
                        while (netStream.DataAvailable || currentSize < packSize)
                        {
                            readSize = netStream.Read(bytes, 0, (int)tcpClient.ReceiveBufferSize);
                            if (readSize > 0)
                            {
                                currentSize += readSize;
                                byte[] tempByte2 = new byte[readSize];
                                Array.Copy(bytes, 0, tempByte2, 0, readSize);
                                toalBytes = toalBytes.Concat(tempByte2).ToArray();
                            }
                        }
                    }
                    string resultStr = encoding.GetString(toalBytes);
                    if (!string.IsNullOrEmpty(resultStr))
                        receiveMessage = resultStr.Trim('\0');
                    else
                        receiveMessage = resultStr;

                }
                //删除报文长度头
                string temp = receiveMessage;
                if (_addHeader && _headerLength > 0)
                {
                    if (receiveMessage.Length > _headerLength - 1)
                        temp = receiveMessage.Substring(_headerLength, receiveMessage.Length - _headerLength);
                }

                return temp;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                netStream.Close();
                tcpClient.Close();
            }
        }
    }
}
