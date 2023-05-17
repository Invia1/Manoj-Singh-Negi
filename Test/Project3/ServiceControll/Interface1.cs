using Project3.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3.ServiceControll
{
    internal interface Interface1
    {
        int  createPatient(Patient patient);
        List<Patient> getPatients();
        void updatePatient(int id);
        void DeletePatient(int id);
        void searchGMPatient(string type);
        void searchOrthoPatient(string type);

        void searchDentalPatient(string type);


    }
}
