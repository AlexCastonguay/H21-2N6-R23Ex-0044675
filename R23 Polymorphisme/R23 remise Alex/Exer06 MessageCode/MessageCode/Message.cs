using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageCode
{
    public abstract class Message
    {
        public string MessageNonEncodé { get; protected set; }

        public abstract string MessageEncodé { get; }

        public Message(string pMessageNonEncodé)
        {
            MessageNonEncodé = pMessageNonEncodé;
        }

        public override string ToString()
        {
            return MessageEncodé;
        }
    }
}
