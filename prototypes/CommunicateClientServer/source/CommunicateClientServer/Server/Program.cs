using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
 * =============================================
 * 
 * The server should respond
 * =============================================
 * STATUS:OK
 * RESOURCETYPE:FILE
 * VERSION:1.0.0.0
 * =============================================
 * 
 * Then the server begin to send data to client
 * =============================================
 * LENGTH:1000
 * <EMPTY LINE>
 * [DATA]
 * =============================================
 * 
 * After transfer is complete
 * =============================================
 * LENGTH:0
 * <EMPTY LINE>
 * =============================================
 * 
 * */

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
