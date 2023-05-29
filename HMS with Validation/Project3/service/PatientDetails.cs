using System;
using Project3.Model;
using Project3.ServiceControll;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3.service
{
    internal class PatientDetails:Interface1
    {
        List<Patient> list = new List<Patient>();
        public int createPatient(Patient patient)
        {
            int countR = 0;
            int countAC = 0;
            List<Patient> plist = getPatients();
            foreach(Patient pat in plist)
            {
               if(pat.RegistrationId==patient.RegistrationId)
                {
                    countR++;
                }
                else if(pat.PatienAAdhar==patient.PatienAAdhar)
                {
                    countAC++;
                }
            }
            if(countR>0)
            {
                Console.WriteLine("Sorryyyyyy...................");
                Console.WriteLine("this Registration id is already registered....");
            }
            else if(countAC>0)
            {
                Console.WriteLine("Sorryyyyyy...................");
                Console.WriteLine("this Aadhar number is already registered....");
            }
            else 
            {
                list.Add(patient);
            }
            return 1;
        }
        public List<Patient> getPatients()
        {
            return list;
        }
        public void updatePatient(int id)
        {
            List<Patient>patients = getPatients();
            try
            {
                int count = 0;
                foreach (Patient pat in patients)
                {
                    if(pat.RegistrationId.Equals(id))
                    {
                        Console.WriteLine("First Name");
                        pat.PatientFirstName=Console.ReadLine();
                        Console.WriteLine("Last Name ");
                        pat.PatientLastName=Console.ReadLine();
                        Console.WriteLine("Phone number");
                        pat.PatientPhoneNumber=Console.ReadLine();
                        Console.WriteLine("age");
                        pat.PatientAge=Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("gender");
                        pat.PatientGender=Console.ReadLine();
                        Console.WriteLine("Aadhar card Number");
                        pat.PatienAAdhar=Console.ReadLine();
                        Console.WriteLine("Address");
                        pat.PatientAddress=Console.ReadLine();

                        Console.WriteLine("enter patient consultant choice:");
                        Console.WriteLine("options are");
                        Console.WriteLine("1- General Medicine");
                        Console.WriteLine("2- Orthopaedics");
                        Console.WriteLine("3- Dental");
                        Console.WriteLine("enter your choice");
                        int choice1 = Convert.ToInt32(Console.ReadLine());
                        switch (choice1)
                        {
                            case 1:
                                pat.PatientConsult = "General Medicine";
                                break;

                            case 2:
                                pat.PatientConsult = "Orthopaedics";
                                break;

                            case 3:
                                pat.PatientConsult = "Dental";
                                break;

                            default:
                                Console.WriteLine("please enter a valid choice");
                                break;
                        }

                        count++;
                        
                    }
                }
                if(count== 0) {
                    Console.WriteLine("patient data is not available");
                }

            }
            catch(Exception e) { 
                Console.WriteLine(e.Message);
            
            }
        }
        public void DeletePatient(int id)
        {
            List<Patient> patients = getPatients();
            
               foreach(Patient pat in patients)
                {
                    if(pat.RegistrationId.Equals(id))
                    {
                        patients.Remove(pat);
                    }
                }

        }
        public void searchGMPatient(string type)
        {
            List<Patient> patients = getPatients();
            if (patients.Count == 0)
            {
                Console.WriteLine("list is empty");
            }
            try
            {
                foreach (Patient pat in patients)
                {
                    if (pat.PatientConsult.Equals(type))
                    {
                        Console.WriteLine("registration Id :"+pat.RegistrationId);
                        Console.WriteLine("First Name      :"+pat.PatientFirstName);
                        Console.WriteLine("Last Name       :"+pat.PatientLastName);
                        Console.WriteLine("Gender          :"+pat.PatientGender);
                        Console.WriteLine("Age             :"+pat.PatientAge);
                        Console.WriteLine("Address         :"+pat.PatientAddress);
                        Console.WriteLine("Aadhar          :"+pat.PatienAAdhar);
                        Console.WriteLine("Phone Number    :"+pat.PatientPhoneNumber);
                        Console.WriteLine("consult with    :"+pat.PatientConsult);
                        Console.WriteLine("***********************");

                    }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
       public  void searchOrthoPatient(string type)
        {
            List<Patient> patients = getPatients();
            if (patients.Count == 0)
            {
                Console.WriteLine("list is empty");
            }
            try
            {
                foreach (Patient pat in patients)
                {
                    if (pat.PatientConsult.Equals(type))
                    {
                        Console.WriteLine("registration Id :" + pat.RegistrationId);
                        Console.WriteLine("First Name      :" + pat.PatientFirstName);
                        Console.WriteLine("Last Name       :" + pat.PatientLastName);
                        Console.WriteLine("Gender          :" + pat.PatientGender);
                        Console.WriteLine("Age             :" + pat.PatientAge);
                        Console.WriteLine("Address         :" + pat.PatientAddress);
                        Console.WriteLine("Aadhar          :" + pat.PatienAAdhar);
                        Console.WriteLine("Phone Number    :" + pat.PatientPhoneNumber);
                        Console.WriteLine("consult with    :" + pat.PatientConsult);
                        Console.WriteLine("***********************");

                    }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
       public  void searchDentalPatient(string type)
        {
            List<Patient> patients = getPatients();
            if(patients.Count == 0) {
                Console.WriteLine("list is empty");
            }
            try
            {
                foreach (Patient pat in patients)
                {
                    if (pat.PatientConsult.Equals(type))
                    {
                        Console.WriteLine("registration Id :" + pat.RegistrationId);
                        Console.WriteLine("First Name      :" + pat.PatientFirstName);
                        Console.WriteLine("Last Name       :" + pat.PatientLastName);
                        Console.WriteLine("Gender          :" + pat.PatientGender);
                        Console.WriteLine("Age             :" + pat.PatientAge);
                        Console.WriteLine("Address         :" + pat.PatientAddress);
                        Console.WriteLine("Aadhar          :" + pat.PatienAAdhar);
                        Console.WriteLine("Phone Number    :" + pat.PatientPhoneNumber);
                        Console.WriteLine("consult with    :" + pat.PatientConsult);
                        Console.WriteLine("***********************");

                    }    
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

    }
}
