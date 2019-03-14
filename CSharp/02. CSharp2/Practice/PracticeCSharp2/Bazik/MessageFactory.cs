using System;
using System.Collections.Generic;
using System.Text;

namespace Bazik
{
    public class MessageFactory : IMessageFactory
    {
        public string Message(string message)
        {
            return message;
        }
    }
}
