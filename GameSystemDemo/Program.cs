using GameSystemDemo.Adapters;
using GameSystemDemo.Concrete;
using GameSystemDemo.Entities;
using System;

namespace GameSystemDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcı kaydı yapılır ve kullanıcı oluşturulur.
            PlayerManager playerManager = new PlayerManager(new MernisServiceAdapter());

            var player = new Player
            {
                Id = 1,
                FirstName = "Başak Selin",
                LastName = "Ünsal",
                DateOfBirth = new DateTime(2000, 6, 4),
                NationalityId = "88888888888",
            };

            Console.WriteLine("------Oyuncu--------");
            playerManager.Register(player);

            //Kampanya oluşturulur ve eklenir.
            CampaignManager campaignManager = new CampaignManager();

            var campaign = new Campaign
            {
                Id = 2,
                CampaignName = "%50 indirim",
                Discount = 50,
                CampaignStart = new DateTime(2024, 10, 4),
                CampaignEnd = new DateTime(2024, 10, 15)
            };

            Console.WriteLine("\n------Kampanya------");
            campaignManager.CampaignAdd(campaign);

            //Oyun oluşturulur ve eklenir.
            GameManager gameManager = new GameManager();

            var game = new Game
            {
                Id= 3,
                GameName="Stardew Valley",
                GamePrice=206,
                ReleaseDate=new DateTime(2016,2,16)
            };

            Console.WriteLine("\n------Oyun----------");
            gameManager.GameAdd(game);

            Console.WriteLine("\n------Satış---------");
            gameManager.Sale(game, player, campaign);

            Console.ReadLine();
        }
    }
}

