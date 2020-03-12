using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WSR_New_Sewing.Core.Entity;
using WSR_New_Sewing.Core.Enum;
using WSR_New_Sewing.View.Customer;
using WSR_New_Sewing.View.Director;
using WSR_New_Sewing.View.Manager;
using WSR_New_Sewing.View.Stockman;

namespace WSR_New_Sewing.Model
{
    class UserModel
    {
        public int Id { get; set; }

        public Core.Enum.Role Role { get; set; }

        public string FirstName { get; set; }

        public string SecondName { get; set; }

        public string LastName { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public UserModel GetModel(User user)
        {
            Id = user.Id;
            FirstName = user.FirstName;
            SecondName = user.SecondName;
            LastName = user.LastName;
            Login = user.Login;
            Password = user.Password;

            switch (user.RoleId)
            {
                case 1: Role = Core.Enum.Role.Customer; break;
                case 2: Role = Core.Enum.Role.Manager; break;
                case 3: Role = Core.Enum.Role.Stockman; break;
                case 4: Role = Core.Enum.Role.Director; break;
            }

            return this;
        }

        public void OpenWindow()
        {
            switch (Role)
            {
                case Core.Enum.Role.Customer: new CustomerMiddleForm().Show(); break;
                case Core.Enum.Role.Manager: new ManagerMiddleForm().Show(); break;
                case Core.Enum.Role.Stockman: new StockManMiddleForm().Show(); break;
                case Core.Enum.Role.Director: new DirectorMiddleForm().Show(); break;

            }
        }
    }
}
