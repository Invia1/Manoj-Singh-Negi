using System;
using System.Collections.Generic;
using System.Linq;
using Project3.Model;
using Project3.service;
using Project3.ServiceControll;
using System.Text;
using System.Threading.Tasks;

namespace Project3.UILayer
{
    internal class MainFunction
    {
      public static void Main(string[] args)
        {
            int regid;
            string consulting;
            Interface1 inter = new PatientDetails();
            Boolean flag = true;

            while (flag)
            {
                Console.WriteLine("press 1 for adding new patient");
                Console.WriteLine("press 2 for viewing the list of patient");
                Console.WriteLine("press 3 for update");
                Console.WriteLine("press 4 for delete");
                Console.WriteLine("press 5 for searching patient of General Medicine");
                Console.WriteLine("press 6 for searching patient of ortho");
                Console.WriteLine("press 7 for searching patient of dental");

                Console.WriteLine("enter your choice :");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Patient patient = new Patient(); 
                        Console.WriteLine("enter Patient registration id : ");
                        patient.RegistrationId = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("enter patient First Name : ");
                        patient.PatientFirstName = Console.ReadLine();

                        Console.WriteLine("enter patient Last Name ");
                        patient.PatientLastName = Console.ReadLine();

                        Console.WriteLine("enter patient Gender(M/F) ");
                        patient.PatientGender=Convert.ToChar(Console.ReadLine());

                        Console.WriteLine("enter Patient phone number : ");
                        patient.PatientPhoneNumber = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("enter Patient age : ");
                        patient.PatientAge = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("enter Patient aadhar number : ");
                        patient.PatienAAdhar = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("enter patient address : ");
                        patient.PatientAddress = Console.ReadLine();

                        Console.WriteLine("enter patient consultant : ");
                        Console.WriteLine("options are");
                        Console.WriteLine("1- General Medicine");
                        Console.WriteLine("2- Orthopaedics");
                        Console.WriteLine("3- Dental");
                        patient.PatientConsult = Console.ReadLine().ToLower();

                        inter.createPatient(patient);

                        //student.Equals(null);
                        break;
                    case 2:
                        Console.WriteLine("************************************");
                        Console.WriteLine("your data in the list are: ");
                        List<Patient> patientlist = inter.getPatients();
                       
                       
                        foreach (var items in patientlist)
                        {
                            Console.WriteLine("registration id: "+items.RegistrationId);
                            Console.WriteLine("First Name: "+items.PatientFirstName);
                            Console.WriteLine("Last Name : "+items.PatientLastName);
                            Console.WriteLine("Gender : "+items.PatientGender);
                            Console.WriteLine("phone Number : "+items.PatientPhoneNumber);
                            Console.WriteLine("Age : "+items.PatientAge);
                            Console.WriteLine("AAdhar number :"+items.PatienAAdhar);
                            Console.WriteLine("Address :"+items.PatientAddress);
                            Console.WriteLine("conulting for: "+items.PatientConsult);

                        }
                        break;

                    case 3:
                        Console.WriteLine("to update the patient enter the registration id ");
                        regid = Convert.ToInt32(Console.ReadLine());
                        inter.updatePatient(regid);
                        break;

                    case 4:
                        Console.WriteLine("to delete the player enter the jersey number");
                        regid = Convert.ToInt32(Console.ReadLine());
                        inter.DeletePatient(regid);
                        break;

                    case 5:
                        consulting = "general medicine";
                        inter.searchGMPatient(consulting);
                        break;

                    case 6:
                        consulting = "orthopaedics";
                        inter.searchOrthoPatient(consulting);
                        break;

                        case 7:

                        consulting = "dental";
                        inter.searchDentalPatient(consulting);
                        break;

                    default:
                        Console.WriteLine("please enter a valid");
                        break;

                }
                Console.WriteLine("do you want to continue , if yes the press y");
                char ch = Convert.ToChar(Console.ReadLine());
                if (!(ch == 'y' || ch == 'Y'))
                {
                    flag = false;
                }

            }


        }

    }
}
