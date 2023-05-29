using System;
using System.Collections.Generic;
using System.Linq;
using Project3.Model;
using Project3.service;
using Project3.ServiceControll;

namespace Project3.UILayer
{
    internal class MainFunction
    {  
        public static void Main(string[] args)
        {
            string username = "admin";
            string password = "admin";
           
            Interface1 inter = new PatientDetails();
            MainFunction fun = new MainFunction();
            int regid;
            string consulting;
            Patient patient1 = new Patient();
            Boolean flag = true;
            Boolean flag2 = true;

            while (flag2)
            {
                Console.WriteLine("enter username");
                string uname = Console.ReadLine();

                Console.WriteLine("enter password");
                string upass = Console.ReadLine();

                if (uname.Equals(username) && upass.Equals(password))
                {
                    flag2 = false;

                    while (flag)
                    {
                        Console.WriteLine("press 1 for adding new patient");
                        Console.WriteLine("press 2 for viewing the list of patient");
                        Console.WriteLine("press 3 for update");
                        Console.WriteLine("press 4 for delete");
                        Console.WriteLine("press 5 for searching patient of General Medicine");
                        Console.WriteLine("press 6 for searching patient of ortho");
                        Console.WriteLine("press 7 for searching patient of dental");
                        Console.WriteLine("press 8 for exit");

                        Console.WriteLine("enter your choice :");
                        int choice = Convert.ToInt32(Console.ReadLine());
                        Boolean flag3 = true;
                       
                        switch (choice)
                        {
                            case 1:
                                while (flag3)
                                {
                                    try
                                    {
                                        Console.WriteLine("<<<<----------Enter Patient Details------------>>>>");
                                        Patient patient = new Patient();
                                        Console.WriteLine("enter Patient registration id : ");
                                        patient.RegistrationId = Convert.ToInt32(Console.ReadLine());
                                       
                                        Console.WriteLine("enter patient First Name : ");
                                        patient.PatientFirstName = Console.ReadLine();
                                        
                                      
                                        Console.WriteLine("enter patient Last Name ");
                                        patient.PatientLastName = Console.ReadLine();
                                       

                                        Console.WriteLine("enter patient Gender(M/F) ");
                                        patient.PatientGender = Console.ReadLine();

                                        Console.WriteLine("enter Patient phone number : ");
                                        patient.PatientPhoneNumber = Console.ReadLine();

                                        Console.WriteLine("enter Patient age : ");
                                        patient.PatientAge = Convert.ToInt32(Console.ReadLine());

                                        Console.WriteLine("enter Patient aadhar number : ");
                                        patient.PatienAAdhar = Console.ReadLine();

                                        Console.WriteLine("enter patient address : ");
                                        patient.PatientAddress = Console.ReadLine();

                                        Console.WriteLine("enter patient consultant choice:");
                                        Console.WriteLine("options are");
                                        Console.WriteLine("1- General Medicine");
                                        Console.WriteLine("2- Orthopaedics");
                                        Console.WriteLine("3- Dental");
                                        Console.WriteLine("4 exit");
                                        Console.WriteLine("enter your choice");
                                        int choice1 = Convert.ToInt32(Console.ReadLine());
                                        switch (choice1)
                                        {
                                            case 1:
                                                patient.PatientConsult = "General Medicine";
                                                break;

                                            case 2:
                                                patient.PatientConsult = "Orthopaedics";
                                                break;

                                            case 3:
                                                patient.PatientConsult = "Dental";
                                                break;

                                            case 4:
                                                flag2 = false;
                                                break;

                                            default:
                                                Console.WriteLine("please enter a valid choice");
                                                break;
                                        }
                                        inter.createPatient(patient);
                                        Console.WriteLine("press 'Enter' for exit");
                                        string str = Console.ReadLine();
                                        if (str == "")
                                        {
                                            flag3 = false;
                                        }
                                    }
                                    
                                    catch(Exception e)
                                    {
                                        Console.WriteLine(e.Message); 
                                    }
                                }
                                break;
                            case 2:
                                Console.WriteLine("************************************");
                                Console.WriteLine("your data in the list are: ");
                                List<Patient> patientlist = inter.getPatients();
                                foreach (var items in patientlist)
                                { 
                                    Console.WriteLine(items.RegistrationId +" |"+items.PatientFirstName+"\t|"+items.PatientLastName+"\t|"+items.PatientGender+"|"+items.PatientPhoneNumber+"|"+items.PatientAge+" |"+items.PatienAAdhar+"|"+items.PatientAddress+"\t|"+items.PatientConsult);
                     
                                }
                                Console.WriteLine("*******************************************************************************");
                                break;

                            case 3:
                                Console.WriteLine("to update the patient enter the registration id ");
                                regid = Convert.ToInt32(Console.ReadLine());
                                inter.updatePatient(regid);
                                Console.WriteLine("******************************");
                                break;

                            case 4:
                                Console.WriteLine("to delete a patient enter the registration id");
                                regid = Convert.ToInt32(Console.ReadLine());
                                inter.DeletePatient(regid);
                                Console.WriteLine("***************************************");
                                break;

                            case 5:
                                consulting = "General Medicine";
                                inter.searchGMPatient(consulting);
                                Console.WriteLine("***************************************");
                                break;

                            case 6:
                                consulting = "Orthopaedics";
                                inter.searchOrthoPatient(consulting);
                                Console.WriteLine("***************************************");
                                break;

                            case 7:

                                consulting = "Dental";
                                inter.searchDentalPatient(consulting);
                                Console.WriteLine("**************************************");
                                break;

                            case 8:
                                flag = false;
                                break;


                            default:
                                Console.WriteLine("please enter a valid");
                                break;
                        }

                    }
                }
                else if(!uname.Equals(username))
                {
                    Console.WriteLine("please enter valid username");
                    Console.WriteLine();
                }
                else 
                {
                    Console.WriteLine("please enter valid password");
                    Console.WriteLine();
                }
            }
        }     

    }
}
