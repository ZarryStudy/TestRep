using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SlavaWorkz
{
    public class Class
    {
        public static string Verification(string firstname, string secondname, string phone)
        {
            Regex nameRegex = new Regex(@"^[a-zA-Z]{3,15}$");
            Regex lastNameRegex = new Regex(@"^[a-zA-Z]{2,25}$");
            Regex phoneRegex = new Regex(@"^\+\d-\d{3}-\d{3}-\d{2}-\d{2}$");
            // Проверяем введенные данные на соответствие регулярным выражениям
            if (nameRegex.IsMatch(firstname) && lastNameRegex.IsMatch(secondname) && phoneRegex.IsMatch(phone))
            {
                // Если все в порядке, выводим сообщение об успешном вводе
                return "Ввод прошел успешно!";
            }
            else
            {
                // Иначе сообщаем пользователю о неверном вводе
                return "Неверный формат ввода! Проверьте ввод и повторите попытку.";
            }
        }
    }
}
