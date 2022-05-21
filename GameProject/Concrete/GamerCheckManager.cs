using GameProject.Abstract;
using GameProject.Adapter;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class GamerCheckManager : IGamerCheckService
    {
        IGamerCheckService _gamerCheckService;
        public bool CheckGamerIfRealPerson(Gamer gamer)
        {
            _gamerCheckService = new MernisServicesAdapter();
            return _gamerCheckService.CheckGamerIfRealPerson(gamer);
        }
    }

    
}
