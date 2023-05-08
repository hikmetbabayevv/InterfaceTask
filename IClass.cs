using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTask
{
    public interface IFighter
    {
        void canAttack();
        void canShot();
        void canFire();
    }
    public interface IKiller
    {
        void canKill();
    }
    public interface IManage
    {
        void control();
        void completeMission();
        void gatherPeople();
    }
}
