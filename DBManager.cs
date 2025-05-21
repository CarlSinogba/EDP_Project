using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace EDP_WinProject1
{
    internal class DBManager
    {
        private readonly string connectionString = "server=localhost; database=activity2original; uid=root; pwd=carl;";

        public bool AuthenticateUser(string username, string password)
        {
            using (var conn = new MySqlConnection(connectionString))

            {
                conn.Open();
                var query = $"SELECT COUNT(1) FROM accounts WHERE Username=@Username AND Pass=@Password";
                using (var cmd = new MySqlCommand(query, conn))

                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);
                    var count = Convert.ToInt32(cmd.ExecuteScalar());
                    conn.Close();
                    return count == 1;

                }

            }

        }
        public void InsertUser(string username, string password, string email)
        {
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                var query = "INSERT INTO Accounts (Username, Pass, Email) VALUES (@Username, @Pass, @Email)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Pass", password);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
        public void UpdateUser(string username, string password, string email)
        {
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                var query = "UPDATE Accounts SET pass = @Password, email = @Email WHERE username = @Username";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        public void DeleteUser(string username)
        {
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                var query = "DELETE FROM accounts WHERE username = @username";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        public DataTable GetAllUsers()
        {
            DataTable dt = new DataTable();
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                var query = "SELECT UserID, Username, pass as Password, Email FROM accounts";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);
                conn.Close();
            }
            return dt;
        }
        public User SearchUserByUsername(string username)
        {
            User user = null;
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                var query = "SELECT Username, Pass, Email FROM Accounts WHERE Username = @Username";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            user = new User()
                            {
                                //UserId = reader.GetInt32("UserId"),
                                Username = reader["Username"].ToString(),
                                password = reader["Pass"].ToString(),
                                Email = reader["Email"].ToString()
                            };
                        }
                    }
                    conn.Close();
                }
            }
            return user;
        }
        public DataTable GetReceiptInfo()
        {
            DataTable dt = new DataTable();
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                var query = "SELECT * FROM receipt_info;";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            return dt;
        }
        public DataTable GetCustomerInfo()
        {
            DataTable dt = new DataTable();
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                var query = "SELECT * FROM customer_info;";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            return dt;
        }

        public DataTable GetComakerInfo()
        {
            DataTable dt = new DataTable();
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                var query = "SELECT * FROM comaker;";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            return dt;
        }
        public DataTable GetEmployeeInfo()
        {
            DataTable dt = new DataTable();
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                var query = "SELECT * FROM employee;";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            return dt;
        }
        public DataTable GetAmountInfo()
        {
            DataTable dt = new DataTable();
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                var query = "SELECT * FROM amount;";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            return dt;
        }
        public DataTable GetAmountTotalInfo()
        {
            DataTable dt = new DataTable();
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                var query = "SELECT get_total_amount();";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            return dt;
        }
        public DataTable GetBranchesInfo()
        {
            DataTable dt = new DataTable();
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                var query = "SELECT * FROM department_branch;";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            return dt;
        }
        public DataTable GetCustomerLogsInfo()
        {
            DataTable dt = new DataTable();
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                var query = "SELECT * FROM customer_log;";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            return dt;
        }
        public void InsertEmployee(string firstName, string lastName, string branchid)
        {
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                using (var cmd = new MySqlCommand("insert_employee", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@firstName", firstName);
                    cmd.Parameters.AddWithValue("@lastName", lastName);
                    cmd.Parameters.AddWithValue("@department_branch_id", Convert.ToInt32(branchid));

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteEmployee(string employee)
        {
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                var query = "DELETE FROM employee WHERE first_name = @employee";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@employee", employee);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
        public string GenerateResetToken(string email)
        {
            // create token + expiry
            string token = Guid.NewGuid().ToString();
            DateTime expiry = DateTime.Now.AddHours(1);

            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                var sql = @"UPDATE accounts 
                            SET reset_token = @token, reset_token_expiry = @expiry 
                            WHERE Email = @email";
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@token", token);
                    cmd.Parameters.AddWithValue("@expiry", expiry);
                    cmd.Parameters.AddWithValue("@email", email);
                    int updated = cmd.ExecuteNonQuery();
                    if (updated == 0)
                        return null;
                }
            }
            return token;
        }

        public int? ValidateResetToken(string token)
        {
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                var sql = @"SELECT UserID 
                            FROM accounts 
                            WHERE reset_token = @token 
                              AND reset_token_expiry > NOW()";
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@token", token);
                    var result = cmd.ExecuteScalar();
                    return result == null
                        ? (int?)null
                        : Convert.ToInt32(result);
                }
            }
        }

        public bool ResetPassword(int userId, string newPassword)
        {
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                var sql = @"UPDATE accounts 
                            SET Pass = @hash, 
                                reset_token = NULL, 
                                reset_token_expiry = NULL 
                            WHERE UserID = @id";
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@hash", newPassword);
                    cmd.Parameters.AddWithValue("@id", userId);
                    return cmd.ExecuteNonQuery() == 1;
                }
            }
        }

        public void SendResetEmail(string toEmail, string token)
        {
            string body = $"Use this token to reset your password in the app:\n\n{token}\n\n" +
                          "It will expire in 1 hour.";

            var mail = new MailMessage("youremail@example.com", toEmail)
            {
                Subject = "EDP App Password Reset",
                Body = body
            };
            using (var smtp = new SmtpClient("smtp.gmail.com", 587))
            {
                smtp.Credentials = new NetworkCredential(
                    "sinogbacarlernest@gmail.com", "golm jetb srxu dhgf");
                smtp.EnableSsl = true;
                smtp.Send(mail);
            }
        }
        public class User
        {
            public int UserId { get; set; }
            public string Username { get; set; }
            public string password { get; set; }
            public string Email { get; set; }
        }
    }
}
