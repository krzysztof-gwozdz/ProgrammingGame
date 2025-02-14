﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace ProgrammingGame.Data.Entities
{
    public class User : IdentityUser<long>,  IEntity
    {
        public long? CharacterId { get; set; }
        public Character Character { get; set; }
    }
}