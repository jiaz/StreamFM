using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Server
{
    struct Request
    {
        private string _action;
        public string Action
        {
            get { return _action; }
            private set { _action = value; }
        }

        private string _actionParameter;
        public string ActionParameter
        {
            get { return _actionParameter; }
            private set { _actionParameter = value; }
        }

        private string _version;
        public string Version
        {
            get { return _version; }
            private set { _version = value; }
        }

        private string _client;
        public string Client
        {
            get { return _client; }
            private set { _client = value; }
        }

        public Request(
            string action,
            string actionParam,
            string version,
            string client
            )
        {
            _action = action;
            _actionParameter = actionParam;
            _version = version;
            _client = client;
        }
    }
}
