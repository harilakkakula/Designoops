using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethod
{
    class MailAttachment:Atatchements
    {
        string filepath;
        public MailAttachment(string fromMail, string subject, List<string> cc, List<string> to, List<string> Bcc,string filepath) : base(fromMail, subject, cc, to, Bcc)
        {
            this.filepath = filepath;
        }
        public override void sendmail()
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

            Console.WriteLine($"File Path {filepath}");
            Console.WriteLine($"Sending Mail with Attachment");
        }
    }
}
