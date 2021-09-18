using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace VirtualMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //double distance, hour, fuel = 0;
            //Console.WriteLine("Enter the Distance");
            //distance = Double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the Hours");
            //hour = double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the fuel");
            //fuel = double.Parse(Console.ReadLine());

            //Car objcar = new Car(distance, hour, fuel);
            //Vehicae vehobj = objcar;
            //Bike bikeobj = new Bike(distance, hour, fuel);
            //Console.WriteLine("Car ====================>>");
            //objcar.Avegrage();
            //objcar.speed();
            //Console.WriteLine("Vehicle ====================>>");
            //vehobj.Avegrage();
            //vehobj.speed();
            //Console.WriteLine("Im Bike===========================>>>");
            //bikeobj.Avegrage();
            //bikeobj.speed();


            Console.WriteLine("Mail Virtual methdos");

            string from = "virtual@methods.com";
            string subject = "virtual methods";
            List<string> to = new List<string>() { "dwe@gamil.com","kyc.gmail.com"};
            List<string> cc = new List<string>() { "ccdwe@gamil.com", "cckyc.gmail.com" };
            List<string> bcc = new List<string>() { "bccdwe@gamil.com", "bcckyc.gmail.com" };
            Atatchements painobje = new Plainmail(from,subject,cc,to,bcc);
            painobje.sendmail();
            painobje = new MailAttachment(from, subject, cc, to, bcc,"d:/hj/jk.pdf");
            painobje.sendmail();


            Console.Read();


        }
    }
}
