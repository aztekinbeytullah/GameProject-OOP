using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.DogumYili ==1985 && gamer.Adi=="Beytullah")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
