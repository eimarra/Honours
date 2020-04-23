using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Security.Cryptography;
using System.IO;
using System.Data.SqlClient;

namespace HonorsMCQ
{
    public partial class Form1 : Form
    {




        public Form1()
        {
            InitializeComponent();


        }

        private void btNewUser_Click(object sender, EventArgs e)
        {
            string con = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

            SqlConnection conn = new SqlConnection(con);

            SqlCommand cmd = new SqlCommand();


            string username = txtUsername.Text;
            string salt = "aa07iubewfp9a8bp9web";
            string Password = txtPassword.Text;
            string NewPass = Password + salt;

            SHA1CryptoServiceProvider sHA1CryptoServiceProvider = new SHA1CryptoServiceProvider();
            var sha1 = sHA1CryptoServiceProvider;

            var EncPass = sha1.ComputeHash(Encoding.UTF8.GetBytes(NewPass));






            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "INSERT INTO users VALUES (@username, @Pass, 5);";

            SqlParameter param = new SqlParameter();
            param.ParameterName = "@username";
            param.Value = username;

            SqlParameter param2 = new SqlParameter();
            param2.ParameterName = "@Pass";
            param2.Value = EncPass;

            cmd.Parameters.Add(param);
            cmd.Parameters.Add(param2);

            cmd.Connection = conn;

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string con = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

            SqlConnection conn = new SqlConnection(con);

            SqlCommand cmd = new SqlCommand();
            SqlCommand cmd2 = new SqlCommand();
            int count;
            string username = txtUsername.Text;
            string salt = "aa07iubewfp9a8bp9web";
            string Password = txtPassword.Text;
            string NewPass = Password + salt;
            var dataSet = new DataSet();

            SHA1CryptoServiceProvider sHA1CryptoServiceProvider = new SHA1CryptoServiceProvider();
            var sha1 = sHA1CryptoServiceProvider;

            var EncPass = sha1.ComputeHash(Encoding.UTF8.GetBytes(NewPass));

            var query = "SELECT COUNT (username) FROM users WHERE username = @username AND Pass = @Pass;";

            cmd = new SqlCommand(query, conn);

            cmd2 = new SqlCommand(query, conn);

            SqlParameter param = new SqlParameter();
            param.ParameterName = "@username";
            param.Value = username;

            SqlParameter param2 = new SqlParameter();
            param2.ParameterName = "@Pass";
            param2.Value = EncPass;

            cmd.Parameters.Add(param);
            cmd.Parameters.Add(param2);

            conn.Open();

            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                count = Convert.ToInt32(reader[0]);

                

                if (count > 0)
                {
                    
                    this.Hide();
                    var QuizBody = new QuizBody();
                    username = QuizBody.username;
                    QuizBody.Closed += (s, args) => this.Close();
                    QuizBody.Show();

                }
                
            }
            conn.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
