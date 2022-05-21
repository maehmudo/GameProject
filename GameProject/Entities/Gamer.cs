using GameProject.Abstract;
using System;

namespace GameProject.Entities
{
    public class Gamer : IEntity
    {
        public int Id { get; set; }
        public string NationalityId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }

        internal static void Add(Gamer gamer2)
        {
            throw new NotImplementedException();
        }
    }
}
