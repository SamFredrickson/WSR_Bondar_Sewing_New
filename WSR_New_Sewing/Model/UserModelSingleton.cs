using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSR_New_Sewing.Model
{
    static class UserModelSingleton
    {
        private static UserModel instance;
        public static UserModel Instance()
        {
            if (instance == null)
                instance = new UserModel();
            return instance;
        }
    }
}
