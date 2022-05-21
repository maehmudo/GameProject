using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class GamerManager : IGamerService
    {
        private IGamerCheckService _gamerCheckService;

        public GamerManager(IGamerCheckService gamerCheckService)
        {
            _gamerCheckService = gamerCheckService;
        }


        public void Add(Gamer gamer)
        {
            if (_gamerCheckService.CheckGamerIfRealPerson(gamer) == true)
            {
                Console.WriteLine("Congrats ! New Gamer add to db : " + gamer.FirstName + " " + gamer.LastName);
            }
            else
            {
                Console.WriteLine("Doesn't match with Mernis System. Addition failed");
            }


        }

        public void Delete(Gamer gamer)
        {

            Console.WriteLine("Congrats ! " + gamer.FirstName + " " + gamer.LastName + " " + "deleted");

        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Congrats ! Gamer information updated : " + gamer.FirstName + " " + gamer.LastName);
        }
    }
}