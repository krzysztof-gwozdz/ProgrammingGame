﻿namespace ProgrammingGame.Data.Infrastructure.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ProgrammingGameContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}