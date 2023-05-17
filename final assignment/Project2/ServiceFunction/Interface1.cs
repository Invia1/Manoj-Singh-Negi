using Project2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2.ServiceFunction
{
    internal interface Interface1
    {
        int CreateStudent(Player player);
        List<Player> GetList();
        void Update(int id);
        void Delete(int id);
        void search(int id);
    }
}
