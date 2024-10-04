using GameSystemDemo.Abstract;
using GameSystemDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSystemDemo.Concrete
{
    public class PlayerManager : IPlayerService
    {
        IPlayerCheckService _playerCheckService;
        public PlayerManager(IPlayerCheckService playerCheckService)
        {
            _playerCheckService = playerCheckService;
        }
        public void Register(Player player)
        {
            if (_playerCheckService.CheckIRealPerson(player))
            {
                Console.WriteLine(player.FirstName + " sistemde kayıtlı.");
            }
            else
            {
                throw new Exception("Kayıt yok veya girilen bilgiler hatalı.");
            }
        }

        public void PlayerUpdate(Player player)
        {
            Console.WriteLine(player.FirstName + " güncellendi.");
        }

        public void PlayerDelete(Player player)
        {
            Console.WriteLine(player.FirstName + " silindi.");
        }
    }
}
