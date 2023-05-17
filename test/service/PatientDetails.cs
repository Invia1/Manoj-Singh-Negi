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
          
            List<Patient> patients = getPatients();
            try
            {
                int count = 0;
                foreach (Patient pat in patients)
                {
                    if(pat.RegistrationId == patient.RegistrationId)
                    {
                        count++;
                        Console.WriteLine("Id number "+patient.RegistrationId+" is already registered");
                        break;
                    }
                }
               if(count == 0) {
                    list.Add(patient);
                }
                
                  
                
            }catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
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
                foreach (Patient pat in list)
                {
                    if(pat.RegistrationId == id)
                    {
                        Console.WriteLine("First Name");
                        pat.PatientFirstName=Console.ReadLine();
                        Console.WriteLine("Last Name ");
                        pat.PatientLastName=Console.ReadLine();
                        Console.WriteLine("Phone number");
                        pat.PatientPhoneNumber=Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("age");
                        pat.PatientAge=Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("gender");
                        pat.PatientGender=Convert.ToChar(Console.ReadLine());
                        Console.WriteLine("Aadhar card Number");
                        pat.PatienAAdhar=Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Address");
                        pat.PatientAddress=Console.ReadLine();
                        Console.WriteLine("consult with");
                         pat.PatientConsult = Console.ReadLine();
                        
                    }
                }

            }
            catch(Exception e) { 
                Console.WriteLine(e.Message);
            
            }
        }
        public void DeletePatient(int id)
        {
            List<Patient> patients = getPatients();
            try
            {
               foreach(Patient pat in patients)
                {
                    if(pat.RegistrationId == id)
                    {
                        patients.Remove(pat);
                    }
                }

            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
        public void searchGMPatient(string type)
        {
            List<Patient> patients = getPatients();
            try
            {
                foreach (Patient pat in patients)
                {
                    if (pat.PatientConsult.Equals(type))
                    {
                        Console.WriteLine(pat.RegistrationId);
                        Console.WriteLine(pat.PatientFirstName);
                        Console.WriteLine(pat.PatientLastName);
                        Console.WriteLine(pat.PatientGender);
                        Console.WriteLine(pat.PatientAge);
                        Console.WriteLine(pat.PatientAddress);
                        Console.WriteLine(pat.PatienAAdhar);
                        Console.WriteLine(pat.PatientPhoneNumber);
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
            try
            {
                foreach (Patient pat in patients)
                {
                    if (pat.PatientConsult.Equals(type))
                    {
                        Console.WriteLine(pat.RegistrationId);
                        Console.WriteLine(pat.PatientFirstName);
                        Console.WriteLine(pat.PatientLastName);
                        Console.WriteLine(pat.PatientGender);
                        Console.WriteLine(pat.PatientAge);
                        Console.WriteLine(pat.PatientAddress);
                        Console.WriteLine(pat.PatienAAdhar);
                        Console.WriteLine(pat.PatientPhoneNumber);

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
            try
            {
                foreach (Patient pat in patients)
                {
                    if (pat.PatientConsult.Equals(type))
                    {
                        Console.WriteLine(pat.RegistrationId);
                        Console.WriteLine(pat.PatientFirstName);
                        Console.WriteLine(pat.PatientLastName);
                        Console.WriteLine(pat.PatientGender);
                        Console.WriteLine(pat.PatientAge);
                        Console.WriteLine(pat.PatientAddress);
                        Console.WriteLine(pat.PatienAAdhar);
                        Console.WriteLine(pat.PatientPhoneNumber);

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
