using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    public interface IOrderService
    {
        void Sales(Game game, Gamer gamer, Campaing campaing);
    }
}
