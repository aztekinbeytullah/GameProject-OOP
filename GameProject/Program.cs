﻿using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer
            {
                Adi="Beytullah",
                DogumYili=1985
            });
            
        }
    }
}
