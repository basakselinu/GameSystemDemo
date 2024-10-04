using GameSystemDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSystemDemo.Abstract
{
    public interface IPlayerCheckService
    {
        bool CheckIRealPerson(Player player);
    }
}
