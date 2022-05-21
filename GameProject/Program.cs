using GameProject.Concrete;
using GameProject.Entities;
using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer();
            gamer1.Id = 1;
            gamer1.FirstName = "Mahmut Can";
            gamer1.LastName = "Alp";
            gamer1.DateOfBirth = new DateTime(1998, 12, 12);
            gamer1.NationalityId = "39763298928";

            Gamer gamer2 = new Gamer();
            gamer2.Id = 2;
            gamer2.FirstName = "Enes";
            gamer2.LastName = "Alp";
            gamer2.DateOfBirth = new DateTime(2004, 7, 6);
            gamer2.NationalityId = "28394723498";

            GamerManager gamerManager = new GamerManager(new GamerCheckManager());
            gamerManager.Add(gamer1);

            Game game1 = new Game();
            game1.Id = 1;
            game1.GameName = "Red Dead Redamption 2";
            game1.UnitPrice = 299;
            game1.DiscountPrice = 149.50;

            Game game2 = new Game();
            game2.Id = 2;
            game2.GameName = "Cyberpunk 2077";
            game2.UnitPrice = 249;
            game2.DiscountPrice = 124.50;

            Campaing campaing1 = new Campaing();
            campaing1.Id = 1;
            campaing1.CampaingName = "Sepette %50 indirim";

            CampaingManager campaingManager = new CampaingManager();
            campaingManager.Add(campaing1);

            OrderManager orderManager = new OrderManager();
            orderManager.Sales(game1, gamer1, campaing1);

        }
    }
}
