using System;
using System.Collections.Generic;
using System.Text;

namespace Day9
{
    class DeleteName
    {
        public static void deleteName()
        {
            string FirstName = "Ram";
            string LastName = "Pandey";
            string Address = "main road, street no. 7, Gurgaon";
            string City = "Gurgaon";
            string State = "Rajasthan";
            int Zip = 444506;
            long MobileNumber = 8208629118;
            string MailID = "abhishekrawane1195@gmail.com";

          Console.WriteLine(FirstName + " " + LastName + " " + Address + " " + City + " " + State + " " + Zip.ToString() + " " + MobileNumber.ToString() + " " + MailID);
            Console.Clear();
        }
    }
}
