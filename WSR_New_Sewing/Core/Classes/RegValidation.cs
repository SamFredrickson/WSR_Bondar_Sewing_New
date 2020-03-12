using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSR_New_Sewing.Core.Classes
{
    class RegValidation
    {
        public static bool Validate(string firstname, string secondname, string login, string password)
        {
            bool flag = false;
            bool mask_bool = false;
            bool iscapital = false;
            bool isnumber = false;
            bool isempty = false;
            bool islength = false;
            string mask = "!@#$%^";

            if(!string.IsNullOrWhiteSpace(firstname) && !string.IsNullOrWhiteSpace(secondname)
                && !string.IsNullOrWhiteSpace(login) && !string.IsNullOrWhiteSpace(password))
            {
                isempty = true;
            }

            if(password.Length > 6) { 

                islength = true;
            }

            foreach(var item in mask)
            {
                if (password.Contains(item))
                {
                    mask_bool = true;
                    break;
                }
            }

            foreach(var item in password)
            {
                if(char.IsLetter(item) && char.IsUpper(item))
                {
                    iscapital = true;
                    break;
                }
            }

            foreach (var item in password)
            {
                if (char.IsDigit(item))
                {
                    isnumber = true;
                    break;
                }
            }

            if (!mask_bool)
                DialogService.ShowError("Пароль должен содержать хотя бы один символ из набора ! @ # $ % ^", "Ошибка!");

            if (!iscapital)
                DialogService.ShowError("Пароль должен содержать хотя бы одну заглавную букву", "Ошибка!");

            if (!isnumber)
                DialogService.ShowError("Пароль должен содержать хотя бы одну цифру", "Ошибка!");

            if (!isempty)
                DialogService.ShowError("Заполните все поля", "Ошибка!");

            if (!islength)
                DialogService.ShowError("Длина пароля не меньше 6 символов", "Ошибка!");

            if (mask_bool && iscapital && isnumber && isempty && islength)
                flag = true;

            return flag;
        }
    }
}
