using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    class UserValidationManager: IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (true)
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
