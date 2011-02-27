using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using Barcelona.Tracer;

/* *
 * Server
 * 1. Accept a client request
 * 2. Parse the request to some resource
 * 3. Return the resource to client
 * 4. Manage the start and end of the resource transfer
 * 
 * The client send request
 * =============================================
 * GET:fbc92dee-b499-4d98-ba66-38490979d564
 * CLIENT:PC
 * VERSION:1.0.0.0
 * <CR>
 * =============================================
 * 
 * The server should respond
 * =============================================
 * STATUS:OK
 * RESOURCETYPE:FILE
 * VERSION:1.0.0.0
 * <CR>
 * =============================================
 * 
 * Then the server begin to send data to client
 * =============================================
 * LENGTH:1000
 * <CR>
 * [DATA]
 * <CR>
 * =============================================
 * 
 * After transfer is complete
 * =============================================
 * LENGTH:0
 * <CR>
 * =============================================
 * 
 * */

namespace Server
{
    /// <summary>
    /// This server starts a thread listening on the port
    /// which queues incoming request and startup new handling
    /// thread to deal with the 
    /// </summary>
    class StreamServer
    {
        // Singleton Impl because of only one object may listening 
        // to the same port at one time
        StreamServer()
        {

        }

        public static StreamServer Instance
        {
            get
            {
                return Nested._instance;
            }
        }

        private class Nested
        {
            internal readonly static StreamServer _instance = new StreamServer();
            static Nested()
            {

            }
        }

        // Infinite loop for queuing incomming requests
        public void Run()
        {
            // Listen to the port: 826
            IPEndPoint ep = new IPEndPoint(IPAddress.Any, 826);
            TcpListener listner = new TcpListener(ep);
            while (true)
            {
                TcpClient client = listner.AcceptTcpClient();
                ThreadPool.QueueUserWorkItem(
                        (c) =>
                        {
                            Request req = ParseRequest(client);
                        },
                        client
                    );
            }
        }

        private Request ParseRequest(TcpClient client)
        {
            Tracer.Trace("CommunicateServer", "In ParseRequest");
            return new Request();
        }
    }
}
