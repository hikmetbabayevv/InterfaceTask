using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTask
{
    public class Fighter : IFighter, IKiller
    {
        public void canAttack()
    {
        Console.WriteLine("Fighter attack");
    }
    public void canShot()
    {
        Console.WriteLine("Fighter shot");
    }
    public void canFire()
    {
        Console.WriteLine("Fighter fire");
    }
    public void canKill()
    {
        Console.WriteLine("Fighter kill");
    }
}
public class Commander : IFighter, IKiller , IManage
    {
        public void canAttack()
        {
            Console.WriteLine("Commander attack");
        }
        public void canShot()
        {
            Console.WriteLine("Commander shot");
        }
        public void canFire()
        {
            Console.WriteLine("Commander fire");
        }
        public void canKill()
        {
            Console.WriteLine("Commander kill");
        }
        public void control()
        {
            Console.WriteLine("Commander kill");
        }
        public void completeMission()
        {
            Console.WriteLine("Commander kill");
        }
        public void gatherPeople()
        {
            Console.WriteLine("Commander kill");
        }
    }
}
