using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageCode
{
    public class MessageMoyen : Message
    {
        public override string MessageEncodé
        {
            get
            {
                return base.MessageNonEncodé;
            }
        }
        public MessageMoyen(string pMessageNonEncodé)
            : base(pMessageNonEncodé)
        {

        }
    }
}
