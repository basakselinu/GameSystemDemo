using GameSystemDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSystemDemo.Abstract
{
    public interface IGameService
    {
        void Sale(Game game,Player player,Campaign campaign);
        void GameAdd(Game game);
        void GameDelete(Game game);
        void GameUpdate(Game game);
    }
}
