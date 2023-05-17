using Project2.Model;
using Project2.ServiceFunction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2.Service
{
    internal class PlayerDetails:Interface1
    {
        List<Player> list = new List<Player>();
        public int CreateStudent(Player player)
        {
            list.Add(player);
            return 1;
        }
        public List<Player> GetList()
        {
            return list;
        }

        //for update 
        public void Update(int jersey)
        {
            List<Player> students = GetList();
            try
            {
                foreach (Player play in students)
                {
                    if (play.JerseyNo == jersey)
                    {
                        play.JerseyNo = jersey;
                        Console.WriteLine("enter the new name");
                        play.Name = Console.ReadLine();

                        Console.WriteLine("enter the position");
                        play.Position = Console.ReadLine();

                        Console.WriteLine("enter the country");
                        play.country = Console.ReadLine();
                    }
                }
            }
            catch (Exception ex) { ex.ToString(); }
        }
        //delete the object
        public void Delete(int jersey)
        {
            List<Player> Players = GetList();
            try
            {
                foreach (Player play in Players)
                {
                    if (play.JerseyNo == jersey)
                    {

                        Players.Remove(play);
                    }
                }
            }
            catch (Exception ex) { ex.ToString(); }
        }
        //for searching a perticular object
        public void search(int jersey)
        {
           
            List<Player> Players = GetList();
            try
            {
                foreach (Player play in Players)
                {
                    if ( play.JerseyNo== jersey)
                    {
                        Console.WriteLine("name : " + play.Name);
                        Console.WriteLine("position: " + play.Position);
                        Console.WriteLine("country: " + play.country);
                        break;
                    }

                }
            }
            catch (Exception ex) { ex.ToString(); }
        }

    }
}
