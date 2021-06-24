using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace englishkids_APP
{
    class loginrepository : Imyloginrepository
    {
        string connectionstring = "Data Source=.;Initial Catalog=englishkids-app;Integrated Security=true";

        public DataTable selectall()
        {
            SqlConnection connection = new SqlConnection(connectionstring);
            string query = "select * from login_tb";
            SqlDataAdapter adpter = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            adpter.Fill(dt);
            return dt;
        }

        public bool insert(string username, string password)
        {
            SqlConnection con = new SqlConnection(connectionstring);
            try
            {
                string query = "insert into login_tb (username,password) values (@username,@password)";
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
                con.Open();
                command.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                con.Close();
            }



        }

        public DataTable user(string user, string pass)
        {
            SqlConnection con = new SqlConnection(connectionstring);
            string query = "select count(*) from login_tb where username=@user and password=@pass";
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            adapter.SelectCommand.Parameters.AddWithValue("@user", user);
            adapter.SelectCommand.Parameters.AddWithValue("@pass", pass);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;


        }

        public DataTable serch(string parameters)
        {
            SqlConnection connection = new SqlConnection(connectionstring);
            string query = "select * from login_tb where username like @parameters";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            adapter.SelectCommand.Parameters.AddWithValue("@parameters", "%" + parameters + "%");
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;

        }

        public bool delete(int id)
        {
            SqlConnection connection = new SqlConnection(connectionstring);
            try
            {
                string query = "delete from login_tb where id="+id;
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                command.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        public bool membersall()
        {
            SqlConnection con = new SqlConnection(connectionstring);
            try
            {
                string query = "SELECT SUM (id) FROM login_tb";
                SqlCommand command = new SqlCommand(query, con);
                con.Open();
                command.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }
    }
}
