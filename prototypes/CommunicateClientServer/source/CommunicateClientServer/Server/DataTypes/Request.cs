using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Server
{
    struct Request
    {
        public string Action
        {
            get;
            private set;
        }

        public string ActionParameter
        {
            get;
            private set;
        }

        public string Version
        {
            get;
            private set;
        }

        public string Client
        {
            get;
            private set;
        }

        public Request(
            string action,
            string actionParam,
            string version,
            string client
            )
        {
            this.Action = action;
            this.ActionParameter = actionParam;
            this.Version = version;
            this.Client = client;
        }
    }
}
