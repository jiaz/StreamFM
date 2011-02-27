using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Barcelona.Tracer;
using System.Reflection;

namespace Server
{
    class RequestCoodinator
    {
        RequestCoodinator()
        {
            _handlerMap = new Dictionary<string, IRequestHandler>();
        }

        public static RequestCoodinator Instance
        {
            get { return Nested._instance; }
        }

        private class Nested
        {
            internal static readonly RequestCoodinator _instance = new RequestCoodinator();
            static Nested() { }
        }

        public IRequestHandler GetRequestHandler(Request req)
        {
            IRequestHandler result = null;
            if (_handlerMap.TryGetValue(req.Action, out result))
            {
                // Log error
                Tracer.Trace(Assembly.GetExecutingAssembly().FullName, "Cannot find proper handler");
            }
            return result;
        }

        private Dictionary<string, IRequestHandler> _handlerMap;
    }
}
