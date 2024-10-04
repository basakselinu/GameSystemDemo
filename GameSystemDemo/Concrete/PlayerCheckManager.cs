using GameSystemDemo.Abstract;
using GameSystemDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSystemDemo.Concrete
{
    public class PlayerCheckManager : IPlayerCheckService
    {
        public bool CheckIRealPerson(Player player)
        {
            return true;
        }
    }
}
