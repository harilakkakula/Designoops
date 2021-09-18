using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethod
{
    class Atatchements
    {
        public string fromMail;
        public string Subject;
        public List<string> CC;
        public List<string> to;
        public List<string> Bcc;

        public Atatchements(string fromMail,string Subject,List<string> CC,List<string> to,List<string> Bcc)
        {
            this.fromMail = fromMail;
            this.Subject = Subject;
            this.CC = CC;
            this.to = to;
            this.Bcc = Bcc;
        }

        public virtual void sendmail()
        {
            Console.WriteLine($"{fromMail}");
            Console.WriteLine($"{Subject}");
            Console.WriteLine($"Printing To Mails");
            foreach (var item in to)
            {
                Console.WriteLine($"{item}");
            }
            Console.WriteLine($"Printing BCC Mails");
            foreach (var item in Bcc)
            {
                Console.WriteLine($"{item}");
            }
            Console.WriteLine($"Printing CC Mails");
            foreach (var item in CC)
            {
                Console.WriteLine($"{item}");
            }

            
            Console.WriteLine($"Sending Mail with Out Attachment");
        }
         

    }
}
