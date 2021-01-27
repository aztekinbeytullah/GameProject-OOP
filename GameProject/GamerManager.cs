using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    //MicroService
    class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;
        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer))
            {
                Console.WriteLine("Kayıt Eklendi");
            }
            else
                Console.WriteLine("Kayıt Başarısız");

        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Silindi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Güncellendi");
        }
    }
}
