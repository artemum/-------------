using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Анкетирование
{
    public static class port_server
    {
        const int ERROR = -1;
        const int OK = 1;
        public static int sign_in(string login, string pass)
        {
            //есть ли чел в базе
            if(port_db_helper.is_valid_pers(login, pass))
            {// да - получить ID
                int id = port_db_helper.get_ID_pers(login, pass);
                return id;
            }
            return ERROR;
        }
        public static int sign_up(string login, string pass)
        {
            if (port_db_helper.registrazia(login, pass))
            {
                return OK;//(->ID)
            }
            return ERROR;
        }
    }
}
