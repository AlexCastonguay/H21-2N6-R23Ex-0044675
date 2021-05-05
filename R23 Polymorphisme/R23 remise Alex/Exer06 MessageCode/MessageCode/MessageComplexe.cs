using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageCode
{
    public class MessageComplexe : Message
    {
        public override string MessageEncodé
        {
            get
            {
                return base.ToString();
            }
        }

        public MessageComplexe(string pMessageNonEncodé)
            : base(pMessageNonEncodé)
        {

        }
    }
}
