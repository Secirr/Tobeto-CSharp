using System;
using Core.Persistence.Repositories;

namespace Domain.Entities
{
    public class Brand : Entity<Guid>
    {
        //CQRS'te her komut bir class

        public string Name { get; set; }
    }
}

