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
    public partial class QuizBody : Form
    {
        public string username;
        int diff_score;
        int count = 0;
        string[] id = new string[10];
        string[] question = new string[10];
        string[] corr_answer = new string[10];
        string[] dist_answer = new string[10];
        string[] wrong1 = new string[10];
        string[] wrong2 = new string[10];
        int i = 0;
        int correct_answers = 0;

        bool[] answers = new bool[10];

        


        public QuizBody()
        {
            InitializeComponent();
        }

        private void QuizBody_Load(object sender, EventArgs e)
        {


            string con = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

            SqlConnection conn = new SqlConnection(con);

            var sql = "SELECT diff_score FROM users WHERE username = " + username + ";";

            var cmd = new SqlCommand(sql, conn);
            conn.Open();
            diff_score = (int)cmd.ExecuteScalar();
            conn.Close();

            string query = "SELECT id, question, corr_answer, dist_answer, wrong1, wrong2 " +
                "FROM questions " +
                "WHERE diff_level IN ('" + (diff_score - 1) + "','" + diff_score + "','" + (diff_score + 1) + "');";

            DataTable dt = new DataTable();

            using (conn)
            {
                using (cmd = new SqlCommand(query))
                {
                    conn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        dt.Load(dr);
                    }
                }
            }

            foreach (DataRow row in dt.Rows)
            {
                question[i] = row.Field<string>(0);
                corr_answer[i] = row.Field<string>(1);
                dist_answer[i] = row.Field<string>(2);
                wrong1[i] = row.Field<string>(3);
                wrong2[i] = row.Field<string>(4);
            }

            labQuestion.Text = id[i];

            List<string> answers = new List<string>();

            answers.Add(corr_answer[i]);
            answers.Add(dist_answer[i]);
            answers.Add(wrong1[i]);
            answers.Add(wrong2[i]);

            Random rnd = new Random();
            string[] RandomArray = answers.OrderBy(x => rnd.Next()).ToArray();
            for(int y = 0; y < RandomArray.Length; y++)
            {
                Controls.Find("radAnsw" + (y + 1), true).FirstOrDefault().Text = RandomArray[y];
            }

            i++;                  


        }

        private void butSubmit_Click(object sender, EventArgs e)
        {
            if (radAnsw1.Text == corr_answer[i] && radAnsw1.Checked)
            {
                correct_answers++;

                answers[i] = true;

                this.Hide();
                var QuizBody = new QuizBody();
                username = QuizBody.username;
                QuizBody.Closed += (s, args) => this.Close();
                QuizBody.Show();

            }
            else if (radAnsw2.Text == corr_answer[i] && radAnsw2.Checked)
            {
                correct_answers++;

                answers[i] = true;
                
                this.Hide();
                var QuizBody = new QuizBody();
                username = QuizBody.username;
                QuizBody.Closed += (s, args) => this.Close();
                QuizBody.Show();
            }
            else if (radAnsw3.Text == corr_answer[i] && radAnsw3.Checked)
            {
                correct_answers++;

                answers[i] = true;

                this.Hide();
                var QuizBody = new QuizBody();
                username = QuizBody.username;
                QuizBody.Closed += (s, args) => this.Close();
                QuizBody.Show();
            }
            else if (radAnsw4.Text == corr_answer[i] && radAnsw4.Checked)
            {
                correct_answers++;

                answers[i] = true;

                this.Hide();
                var QuizBody = new QuizBody();
                username = QuizBody.username;
                QuizBody.Closed += (s, args) => this.Close();
                QuizBody.Show();
            }
            else
            {
                if (i == 9)
                {
                    this.Hide();
                    var FinalScreen = new FinalScreen();
                    correct_answers = FinalScreen.correct_answers;
                    FinalScreen.answer_array = answers;
                    FinalScreen.Closed += (s, args) => this.Close();
                    FinalScreen.Show();
                }
                else
                {
                    this.Hide();
                    var QuizBody = new QuizBody();
                    username = QuizBody.username;
                    QuizBody.Closed += (s, args) => this.Close();
                    QuizBody.Show();
                }
            }
        }
    }
}
