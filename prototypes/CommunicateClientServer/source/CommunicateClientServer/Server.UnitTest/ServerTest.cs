using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;
using System.Net.Sockets;

namespace Server.UnitTest
{
    [TestClass]
    public class ServerTest
    {
        [TestMethod]
        public void TestServerListening()
        {
            Thread thServer = new Thread(
                () =>
                {
                    StreamServer.Instance.Run();
                }
                );
            Thread client = new Thread(
                () =>
                {
                    TcpClient c = new TcpClient("localhost", 826);
                    NetworkStream stream = c.GetStream();
                    stream.WriteByte(10);
                    stream.Dispose();
                }
            );
            thServer.Start();
            client.Start();
            client.Join();
            thServer.Abort();
        }
    }
}
