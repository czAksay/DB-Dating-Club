using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace kursach
{
    public static class StringHelper
    {
        //Очищает строки в массиве слева и справа от кавычек
        public static void Scorlupa(String[] str, char symb)
        {
            for (int i = 0; i < str.Length; i++)
            {
                Scorlupa(ref str[i], symb);
            }
        }


        public static void Scorlupa(ref String str, char symb)
        {
            while (str.Length > 0 && str[0] == symb)
            {
                str = str.Remove(0, 1);
            }
            while (str.Length > 0 && str[str.Length - 1] == symb)
            {
                str = str.Remove(str.Length - 1, 1);
            }
        }

        public static String[,] ReadData(NpgsqlDataReader dat)
        {
            List<List<String>> data = new List<List<String>>();
            while(dat.Read())
            {
                List<String> tmp = new List<string>();
                for (int j = 0; j < dat.FieldCount; j++)
                {
                    tmp.Add(dat[j].ToString());
                }
                data.Add(tmp);
            }
            String[,] tmp2 = new String [data.Count, dat.FieldCount];
            for (int i = 0; i < data.Count; i++)
            {
                for (int j = 0; j < dat.FieldCount; j++)
                {
                    tmp2[i, j] = data[i][j].ToString();
                }
            }
            return tmp2;
        }


        public static String DublicateQuotes(String text)
        {
            String ret = "";
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] != '\'')
                {
                    ret += text[i];
                }
                else
                {
                    ret += ('\'' + '\'');
                }
            }
            return ret;
        }

        public static String TextToRole(String Text)
        {
            if (Text == "Админ")
            {
                return "admin";
            }
            else if (Text == "Финансист")
            {
                return "financer";
            }
            else if (Text == "Менеджер")
            {
                return "manager";
            }
            else if (Text == "Работник анкет")
            {
                return "formworker";
            }
            else if (Text == "Суперпользователь")
            {
                return "su";
            }
            else return Text;
        }

        public static String RoleToText(String Role)
        {
            if (Role == "admin")
            {
                return "Админ";
            }
            else if (Role == "financer")
            {
                return "Финансист";
            }
            else if (Role == "manager")
            {
                return "Менеджер";
            }
            else if (Role == "formworker")
            {
                return "Работник анкет";
            }
            else if (Role == "su")
            {
                return "Суперпользователь";
            }
            else return Role;
        }

        public static String Localize(String _str, CurrentTable contextTable)
        {
            String retStr = "";
            if (_str == "id")
            {
                retStr = "ID";
            }
            else if (_str == "name" && contextTable == CurrentTable.Departments)
            {
                retStr = "Название";
            }
            else if (_str == "name")
            {
                retStr = "Имя";
            }
            else if (_str == "address")
            {
                retStr = "Адрес";
            }
            else if (_str == "rent_cost")
            {
                retStr = "Стоимость аренды";
            }
            else if (_str == "club_department_id")
            {
                retStr = "ID отделения";
            }
            else if (_str == "surname")
            {
                retStr = "Фамилия";
            }
            else if (_str == "patronymic")
            {
                retStr = "Отчество";
            }
            else if (_str == "work_position")
            {
                retStr = "Должность";
            }
            else if (_str == "term_of_work")
            {
                retStr = "Срок работы";
            }
            else if (_str == "surcharge")
            {
                retStr = "Надбавка";
            }
            else if (_str == "num_of_organized_visits")
            {
                retStr = "Кол-во организованных свиданий";
            }
            else if (_str == "num_of_contracts")
            {
                retStr = "Кол-во оформленных контрактов";
            }
            else if (_str == "gender")
            {
                retStr = "Пол";
            }
            else if (_str == "nationality")
            {
                retStr = "Национальность";
            }
            else if (_str == "date_of_birth")
            {
                retStr = "Дата рождения";
            }
            else if (_str == "email")
            {
                retStr = "E-mail";
            }
            else if (_str == "phone_number")
            {
                retStr = "Номер телефона";
            }
            else if (_str == "passport_id")
            {
                retStr = "Номер паспорта";
            }
            else if (_str == "height")
            {
                retStr = "Рост";
            }
            else if (_str == "weight")
            {
                retStr = "Вес";
            }
            else if (_str == "eye_color")
            {
                retStr = "Цвет глаз";
            }
            else if (_str == "hair_color")
            {
                retStr = "Цвет волос";
            }
            else if (_str == "interests")
            {
                retStr = "Интересы";
            }
            else if (_str == "temperament")
            {
                retStr = "Темперамент";
            }
            else if (_str == "positive_features")
            {
                retStr = "Положит. качества";
            }
            else if (_str == "negative_features")
            {
                retStr = "Отриц. качества";
            }
            else if (_str == "marital_status")
            {
                retStr = "Семейное положение";
            }
            else if (_str == "amount_of_children")
            {
                retStr = "Кол-во детей";
            }
            else if (_str == "prosperity")
            {
                retStr = "Достаток";
            }
            else if (_str == "purpose_of_dating")
            {
                retStr = "Цель знакомства";
            }
            else if (_str == "client_id")
            {
                retStr = "ID клиента";
            }
            else if (_str == "pare_points")
            {
                retStr = "Баллы сходимости";
            }
            else if (_str == "has_contract")
            {
                retStr = "Действительные контракты";
            }
            else if (_str == "final_partner_id")
            {
                retStr = "ID конечного партнера";
            }
            else if (_str == "orginized_employee_id")
            {
                retStr = "ID оформившего работника";
            }
            else if (_str == "contract_term")
            {
                retStr = "Срок контракта";
            }
            else if (_str == "state")
            {
                retStr = "Состояние";
            }
            else if (_str == "date_of_registration")
            {
                retStr = "Дата оформления";
            }
            else if (_str == "price")
            {
                retStr = "стоимость";
            }
            else if (_str == "client1_id")
            {
                retStr = "ID клиента 1";
            }
            else if (_str == "place_id")
            {
                retStr = "ID места";
            }
            else if (_str == "client2_id")
            {
                retStr = "ID клиента 2";
            }
            else if (_str == "place_type")
            {
                retStr = "Тип места";
            }
            else if (_str == "meeting_date")
            {
                retStr = "Дата встречи";
            }
            else if (_str == "wage")
            {
                retStr = "Зар. плата";
            }
            else if (_str == "meeting_time")
            {
                retStr = "Время встречи";
            }
            else if (_str == "meeting_duration")
            {
                retStr = "Длительность";
            }
            else if (_str == "m_result")
            {
                retStr = "Результат";
            }
            else if (_str == "place_theme")
            {
                retStr = "Тематика места";
            }
            else if (_str == "price_policy")
            {
                retStr = "Ценовая политика";
            }
            else
            {
                retStr = _str;
            }
            return retStr;
        }
    }
}
