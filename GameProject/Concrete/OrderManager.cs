using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class OrderManager : IOrderService
    {
        public void Sales(Game game, Gamer gamer, Campaing campaing)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " - " + campaing.CampaingName + " with campaing " + game.GameName + "named a game " + " " + "instead of  "+ game.UnitPrice +"TL" +" "+ " Bought it for " + game.DiscountPrice +"TL" ); 
        }
    }
}
