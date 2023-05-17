using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3.Model
{
    internal class Patient
    {
        public int RegistrationId { get; set; }
        public string PatientFirstName { get; set;}
        public string PatientLastName { get; set;}

        public double PatientPhoneNumber { get; set;}
        
        public char PatientGender { get; set;}
        public int PatientAge { get; set;}

        public string PatientAddress { get; set;}
        public double PatienAAdhar { get; set;}

        public string PatientConsult { get; set;}
    }
}
