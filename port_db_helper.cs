using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
namespace Анкетирование
{
    public static class port_db_helper
    {
        static string dbName = "Data Source=TestDB.db";
        public static bool is_valid_pers(string login, string pass)
        {
            SQLiteConnection con = new SQLiteConnection(dbName);
            con.Open();

            SQLiteCommand cmd = new SQLiteCommand(con);
            cmd.CommandText = "SELECT count(*) FROM authorization WHERE login='"+login+"'";

            int count = Convert.ToInt32(cmd.ExecuteScalar());
            if(count > 0) return true;
            return false;
        }
        public static int get_ID_pers(string login, string pass)
        {
            //SQL
            return 0;
        }
        public static bool registrazia(string login, string pass)
        {
            //SQL
            return false;
        }
    }
}
