using GameSystemDemo.Abstract;
using GameSystemDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSystemDemo.Concrete
{
    public class GameManager : IGameService
    {
        public void GameAdd(Game game)
        {
            Console.WriteLine(game.GameName + " eklendi.");

        }

        public void GameDelete(Game game)
        {
            Console.WriteLine(game.GameName + " silindi.");

        }

        public void GameUpdate(Game game)
        {
            Console.WriteLine(game.GameName + " güncellendi.");
        }

        public void Sale(Game game, Player player, Campaign campaign)
        {
            Console.WriteLine(
                game.GameName+" isimli oyun "+player.FirstName+" tarafından %"+
                campaign.Discount+" indirimle satın alındı ve "+
                (game.GamePrice-(game.GamePrice*(campaign.Discount/100)))+" TL ödendi.");
        }
    }
}
