using System;
using Npgsql;

namespace kursach
{
    public static class PgSql
    {
        static NpgsqlConnection connection;
        static NpgsqlCommand cmd;
        static NpgsqlDataReader dataReader;
        

        static private void CheckConnection()
        {
            if (connection!=null && connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        static private void CheckDataReader()
        {
            if (dataReader != null && !dataReader.IsClosed)
            {
                dataReader.Close();
            }
        }

        static private void ConnectToDB(String Login, String Pass, String DbName)
        {
            CheckConnection();
            string connstring = String.Format("Server=localhost; Port=5432; User Id={0}; Password={1}; Database={2};", Login, Pass, DbName);
            connection = new NpgsqlConnection(connstring);
            connection.Open();
        }

        static public void ConnectToDatingClubDB(String Login, String Pass)
        {
            ConnectToDB(Login, Pass, "dating_club3");
        }

        static public void ConnectToUsersDB(String Login, String Pass)
        {
            ConnectToDB(Login, Pass, "dc_users");
        }

        static public NpgsqlDataReader SelectRoleFromUsers(String Login, String Pass)
        {
            return Execute(String.Format("SELECT role FROM users WHERE login = '{0}' and password = '{1}'", Login, StringHelper.DublicateQuotes(Crypter.Encrypt(Pass))));
        }
        
        static public NpgsqlDataReader HasTablePrivileges(String table_name, String priv_type)
        {
            return Execute(String.Format("SELECT has_table_privilege('{0}', '{1}');", table_name, priv_type));
        }

        static public NpgsqlDataReader HasFunctionGetParePrivileges()
        {
            return Execute("SELECT has_function_privilege('get_pare(int)', 'EXECUTE')");
        }

        static public NpgsqlDataReader GetContactReport()
        {
            return Execute("SELECT * FROM get_contract_report();");
        }

        static public NpgsqlDataReader GetPare(int id)
        {
            return Execute(String.Format("SELECT * FROM get_pare({0});",id));
        }

        static public NpgsqlDataReader SelectFrom(String what_to_select, String table_name)
        {
            return Execute(String.Format("SELECT {0} FROM {1}", what_to_select, table_name));
        }

        static public NpgsqlDataReader SelectAllFromWhere(String table_name, String filter)
        {
            return Execute(String.Format("SELECT * FROM {0} {1}", table_name, filter));
        }

        static public NpgsqlDataReader SelectTable(CurrentTable curT, String tableName, String filter)
        {
            switch(curT)
            {
                case CurrentTable.Clients:
                    return Execute(String.Format("SELECT * FROM get_client() {0}", filter));
                    break;
                case CurrentTable.Employees:
                    return Execute(String.Format("SELECT * FROM get_employee() {0}", filter));
                    break;
                case CurrentTable.MeetingPlace:
                    return Execute(String.Format("SELECT * FROM get_meeting_place() {0}", filter));
                    break;
                case CurrentTable.ClientList:
                    return Execute(String.Format("SELECT * FROM get_client_list() {0}", filter));
            }
            return Execute(String.Format("SELECT * FROM {0} {1}", tableName, filter));
        }

        static public NpgsqlDataReader SelectFromWhere(String what_to_select, String table_name, String filter, String filter_Eq)
        {
            return Execute(String.Format("SELECT {2} FROM {0} WHERE {1} = '{3}'", table_name, filter, what_to_select, filter_Eq));
        }

        static public NpgsqlDataReader SelectFromWhere2(String what_to_select, String table_name, String filter, String filter_Eq, String filter2, String filter_Eq2)
        {
            return Execute(String.Format("SELECT {2} FROM {0} WHERE {1} = '{3}' AND {4} = '{5}'", table_name, filter, what_to_select, filter_Eq, filter2, filter_Eq2));
        }

        static public void DeleteFromTableById(String table_name, int id)
        {
            Execute(String.Format("DELETE FROM {0} WHERE {0}.id = {1}", table_name, id));
        }

        static public void DeleteFromTable(String table_name, String filter, String filter_Eq)
        {
            Execute(String.Format("DELETE FROM {0} WHERE {1} = '{2}'", table_name, filter, filter_Eq));
        }

        static public void InsertIntoValues(String table_name, String values)
        {
            Execute(String.Format("INSERT INTO {0} VALUES ({1})", table_name, values));
        }

        static public void UpdateSet(String table_name, String values, String upd_values)
        {
            Execute(String.Format("UPDATE {0} SET ({1}) = {2}", table_name, values, upd_values));
        }

        static public NpgsqlDataReader Execute(String command)
        {
            CheckDataReader();
            cmd = new NpgsqlCommand(command, connection);
            cmd.AllResultTypesAreUnknown = true;
            return dataReader = cmd.ExecuteReader();
        }
    }
}
