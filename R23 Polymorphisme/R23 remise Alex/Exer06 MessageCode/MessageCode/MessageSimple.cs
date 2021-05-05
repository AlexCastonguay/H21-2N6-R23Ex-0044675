using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageCode
{
    public class MessageSimple : Message
    {
        public override string MessageEncodé 
        {
            get {
                    return base.MessageNonEncodé;
                }
        }

        public MessageSimple(string pMessageNonEncodé)
            :base(pMessageNonEncodé)
        {

        }
    }
}
