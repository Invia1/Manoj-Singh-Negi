using System;
using Project2.Model;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project2.ServiceFunction;
using Project2.Service;

namespace Project2.UI
{
    internal class MainMethod
    {
        public static void Main(string[] args)
        {
            
            int jersey;
            Interface1 inter = new PlayerDetails();
            Boolean flag = true;

            while (flag)
            {
                Console.WriteLine("press 1 for adding new player");
                Console.WriteLine("press 2 for viewing the list player  ");
                Console.WriteLine("press 3 for update");
                Console.WriteLine("press 4 for delete");
                Console.WriteLine("press 5 for search");

                Console.WriteLine("enter your choice :");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Player player = new Player();
                        Console.WriteLine("enter player jersey number : ");
                        player.JerseyNo= Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("enter player Name : ");
                        player.Name = Console.ReadLine();

                        Console.WriteLine("enter player position ");
                        player.Position = Console.ReadLine();

                        Console.WriteLine("enter player country ");
                        player.country = Console.ReadLine();

                        inter.CreateStudent(player);
                        //student.Equals(null);
                        break;
                    case 2:
                        Console.WriteLine("************************************");
                        Console.WriteLine("your data in the list are: ");
                        List<Player> playerlist = inter.GetList();
                        Console.WriteLine("Jersey Number\tName\tPosition\tcountry");
                        Console.WriteLine("-------------------------------");
                        foreach (var items in playerlist)
                        {
                            Console.WriteLine(items.JerseyNo+ "\t\t" + items.Name + "\t " + items.Position+"\t "+items.country);
                        }
                        break;

                    case 3:
                        Console.WriteLine("to update the player enter the jersey number ");
                        jersey = Convert.ToInt32(Console.ReadLine());
                        inter.Update(jersey);
                        break;

                    case 4:
                        Console.WriteLine("to delete the player enter the jersey number");
                        jersey = Convert.ToInt32(Console.ReadLine());
                        inter.Delete(jersey);
                        break;

                    case 5:
                        Console.WriteLine("to search a player. enter the jersey number");
                        jersey = Convert.ToInt32(Console.ReadLine());
                        inter.search(jersey);
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
