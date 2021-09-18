using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethod
{
    class Plainmail:Atatchements
    {
        public Plainmail(string fromMail,string subject,List<string> cc,List<string> to,List<string> Bcc):base(fromMail,subject,cc,to,Bcc)
        {

        }
        public override void sendmail()
        {
            base.sendmail();
        }
    }
}
