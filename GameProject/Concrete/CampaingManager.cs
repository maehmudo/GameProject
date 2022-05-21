using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class CampaingManager : ICampaingService
    {
        public void Add(Campaing campaing)
        {
            Console.WriteLine("New campaing is added");
        }

        public void Delete(Campaing campaing)
        {
            Console.WriteLine("Campaing is deleted");
        }

        public void Update(Campaing campaing)
        {
            Console.WriteLine("Campaing is updated");
        }
    }

}

