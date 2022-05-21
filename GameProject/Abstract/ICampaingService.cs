using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    public interface ICampaingService
    {
        void Add(Campaing campaing);
        void Update(Campaing campaing);
        void Delete(Campaing campaing);
    }
}
