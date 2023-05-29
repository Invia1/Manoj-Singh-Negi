using System;

using System.Collections.Generic;
using System.Xml.Schema;
using Project3.service;
using Project3.ServiceControll;

namespace Project3.Model
{
    public  class Patient
    {
        private string firstname;
        private string lastname;
        private string phoneno;
        private string gender;
        private string aadhar;
       
        Interface1 inte=new PatientDetails();
       
        //getter and setter for registration id........
        public int RegistrationId 
        {
            get; set;
        }
       //getter and setter for first Name................
        public string PatientFirstName {
          get
            {
                return firstname;
            }
            set
            {
                Boolean flag = true;
                int count = 0;
                while (flag)
                {
                    if (value.Length == 0)
                    {
                        count++;
                    }

                    foreach (char c in value)
                    {
                        if (char.IsDigit(c))
                        {
                            count++;
                        }
                        if (!char.IsLetter(c))
                        {
                            count++;
                        }
                    }
                    if (count == 0)
                    {
                        firstname = value;
                        flag = false;
                    }
                    else
                    {
                        Console.WriteLine("please enter valid a first name");
                        value = Console.ReadLine();
                        count = 0;
                    }
                }

            }

        }

        //getter and setter for last name...........................
        public string PatientLastName {
            get
            {
                return lastname;
            }
            set
            {
                Boolean flag = true;
                int count = 0;
                while (flag)
                {
                         if (value.Length== 0)
                         {
                           count++;
                          }
                        foreach (char c in value)
                        {
                            if (char.IsDigit(c))
                            {
                                count++;
                            }
                            if (!char.IsLetter(c))
                            {
                                count++;
                            }
                            {

                            }
                        }
                    if(count==0)
                    {
                        lastname = value;
                        flag = false;
                    }
                    else
                    {
                        Console.WriteLine("please enter valid a last name");
                        value=Console.ReadLine();
                        count = 0;
                    }
                }
            }
        }
        //getter and setter for  phone number.............................
        public string PatientPhoneNumber {
            get
            {
                return phoneno;
            }
            set
            {
                Boolean flag = true;
                int count = 0;
                while (flag)
                {
                    //here first we are checking that input is of length 10 or not.
                    //then we are traversing the whole input and counting number of digit.
                    if (value.Length == 10)
                    {
                        foreach (char c in value)
                        {
                        
                            if (char.IsDigit(c))
                            {
                                count++;
                            }
                        }
                           
                     }

                    //now checking the condition
                        if(count==10)
                        { 
                               phoneno= value;
                               flag = false;     
                        }
                        else 
                         {
                             Console.WriteLine("please enter the input in correct format");
                              value = Console.ReadLine();
                              count= 0;
                         }  
                }
            }
        }
        //getter and setter for gender...........................
        public string PatientGender {
            get
            {
                return gender;
            }
            set
            {
                while (true)
                {
                    if (!(value=="M"||value=="m"||value=="f"||value=="F"))
                    {
                        Console.WriteLine("please re-enter the gender in the format(M/F)");
                        value = Console.ReadLine ();
                        continue;
                    }
                    foreach (char c in value)
                    {
                        if (char.IsDigit(c))
                        {
                            Console.WriteLine("digit not allowed");
                            Console.WriteLine("please enter the correct name");
                            value = Console.ReadLine();
                            break;
                        }

                    }
                    break;
                }
                gender = value;
            }
        }
        //getter and setter for patient age................
        public int PatientAge { get; set;}

        // getter and setter for patient address.........
        public string PatientAddress { get; set;}
        //getter and setter for  patient address....................
        public string PatienAAdhar {
            get
            {
                return aadhar;
            }
            set
            {
                Boolean flag = true;
                int count = 0;
                while (flag)
                {
                    //here first we are checking that input is of length 12 or not.
                    //then we are traversing the whole input and counting number of digit.
                    if (value.Length == 12)
                    {
                        foreach (char c in value)
                        {
                            if (char.IsDigit(c))
                            {
                                count++;
                            }
                        }
                    }
                    //now checking the condition.
                    if (count == 12)
                    {
                        aadhar = value;
                        flag = false;
                    }
                    else
                    {
                        Console.WriteLine("please enter a valid aadhar number");
                        value = Console.ReadLine();
                        count = 0;

                    }
                }
            }
        }
        //getter and setter for patient consult..........................
        public string PatientConsult { get; set;}
    }
}
