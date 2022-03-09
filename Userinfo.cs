using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class Userinfo
    {
        public static string UserName()
        {
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            return name;
        }
        public static int UserAge()
        {
            Console.WriteLine("Enter your age");
            string StringAge = Console.ReadLine();
            int IntAge = int.Parse(StringAge);
            return IntAge;
        }
        public static string UserLocation()
        {
            Console.WriteLine("Enter your location");
            string location = Console.ReadLine();
            return location;
        }
        public static string UserProfession()
        {
            Console.WriteLine("Enter your profession");
            string profession = Console.ReadLine();
            return profession;
        }
        public static int UserMobno()
        {
            Console.WriteLine("Enter your mobno");
            string StringMobno = Console.ReadLine();
            int IntMobno = int.Parse(StringMobno);
            return IntMobno;
        }
    }
}
