using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace StaniBogat_Marten
{
    public partial class FormGame : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=StaniBogat;Integrated Security=True;");
        private string correctAnswer;
        private int currentPoints;
        private int totalPoints = 0;
        private int questionIndex = 1;
        private int totalQuestions;
        public FormGame()
        {
            InitializeComponent();
            LoadQuestions();
            LoadTotalQuestions();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void LoadQuestions()
        {
            string command = "SELECT * FROM dbo.Questions WHERE Id = @Id";
            SqlCommand cmd = new SqlCommand(command, connection);
            cmd.Parameters.AddWithValue("@Id", questionIndex);

            connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                lblQuestion.Text = reader["Question"].ToString();
                lblAnsA.Text = reader["AnsA"].ToString();
                lblAnsB.Text = reader["AnsB"].ToString();
                lblAnsC.Text = reader["AnsC"].ToString();
                lblAnsD.Text = reader["AnsD"].ToString();
                correctAnswer = reader["CorrectAns"].ToString();
                currentPoints = Convert.ToInt32(reader["Points"]);
                lblQuestionNumber.Text = $"Въпрос {questionIndex}";
            }
            connection.Close();
        }
        private void LoadTotalQuestions()
        {
            string command = "SELECT COUNT(*) FROM dbo.Questions";
            SqlCommand cmd = new SqlCommand(command, connection);
            connection.Open();
            totalQuestions = Convert.ToInt32(cmd.ExecuteScalar());
            connection.Close();

            lblAllQuestions.Text = $"Общо въпроси: {totalQuestions}";
        }

        private bool IsLastQuestion()
        {
            string command = "SELECT MAX(Id) FROM dbo.Questions";
            SqlCommand cmd = new SqlCommand(command, connection);
            connection.Open();
            int lastQuestionIndex = Convert.ToInt32(cmd.ExecuteScalar());
            connection.Close();

            if (questionIndex == lastQuestionIndex)
            {
                return true;
            }
            return false;
        }
        private void ShowResults()
        {
            MessageBox.Show($"Поздравления! Вие спечелихте {totalPoints} точки!", "Край на играта", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private async void lblAnsA_Click(object sender, EventArgs e)
        {
            if (correctAnswer == "A")
            {
                totalPoints += currentPoints;
                for (int i = 0; i < 5; i++)
                {
                    lblAnsA.BackColor = Color.FromArgb(128, Color.Green); ;
                    await Task.Delay(200);
                    lblAnsA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
                    await Task.Delay(200);
                }
                MessageBox.Show($"Правилен отговор! Получаваш {currentPoints} точки. Общо: {totalPoints}");

                if (IsLastQuestion())
                {
                    ShowResults();
                }
                else
                {
                    questionIndex++;
                    LoadQuestions();
                }
            }
            else
            {
                for (int i = 0; i < 5; i++)
                {
                    lblAnsA.BackColor = Color.FromArgb(128, Color.Red); ;
                    await Task.Delay(200);
                    lblAnsA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
                    await Task.Delay(200);
                }
                MessageBox.Show($"Грешен отговор! Играта приключи. Общ резултат: {totalPoints}", "Играта приключи!");
                this.Close();
            }
        }

        private async void lblAnsB_Click(object sender, EventArgs e)
        {
            if (correctAnswer == "B")
            {
                totalPoints += currentPoints;
                for (int i = 0; i < 5; i++)
                {
                    lblAnsB.BackColor = Color.FromArgb(128, Color.Green); ;
                    await Task.Delay(200);
                    lblAnsB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
                    await Task.Delay(200);
                }
                MessageBox.Show($"Правилен отговор! Получаваш {currentPoints} точки. Общо: {totalPoints}");

                if (IsLastQuestion())
                {
                    ShowResults();
                }
                else
                {
                    questionIndex++;
                    LoadQuestions();
                }
            }
            else
            {
                for (int i = 0; i < 5; i++)
                {
                    lblAnsB.BackColor = Color.FromArgb(128, Color.Red); ;
                    await Task.Delay(200);
                    lblAnsB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
                    await Task.Delay(200);
                }
                MessageBox.Show($"Грешен отговор! Играта приключи. Общ резултат: {totalPoints}");
                this.Close();
            }
        }

        private async void lblAnsC_Click(object sender, EventArgs e)
        {
            if (correctAnswer == "C")
            {
                totalPoints += currentPoints;
                for (int i = 0; i < 5; i++)
                {
                    lblAnsC.BackColor = Color.FromArgb(128, Color.Green); ;
                    await Task.Delay(200);
                    lblAnsC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
                    await Task.Delay(200);
                }
                MessageBox.Show($"Правилен отговор! Получаваш {currentPoints} точки. Общо: {totalPoints}");

                if (IsLastQuestion())
                {
                    ShowResults();
                }
                else
                {
                    questionIndex++;
                    LoadQuestions();
                }
            }
            else
            {
                for (int i = 0; i < 5; i++)
                {
                    lblAnsC.BackColor = Color.FromArgb(128, Color.Red); ;
                    await Task.Delay(200);
                    lblAnsC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
                    await Task.Delay(200);
                }
                MessageBox.Show($"Грешен отговор! Играта приключи. Общ резултат: {totalPoints}");
                this.Close();
            }
        }

        private async void lblAnsD_Click(object sender, EventArgs e)
        {
            if (correctAnswer == "D")
            {
                totalPoints += currentPoints;
                for (int i = 0; i < 5; i++)
                {
                    lblAnsD.BackColor = Color.FromArgb(128, Color.Green); ;
                    await Task.Delay(200);
                    lblAnsD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
                    await Task.Delay(200);
                }
                MessageBox.Show($"Правилен отговор! Получаваш {currentPoints} точки. Общо: {totalPoints}");

                if (IsLastQuestion())
                {
                    ShowResults();
                }
                else
                {
                    questionIndex++;
                    LoadQuestions();
                }
            }
            else
            {
                for (int i = 0; i < 5; i++)
                {
                    lblAnsD.BackColor = Color.FromArgb(128, Color.Red); ;
                    await Task.Delay(200);
                    lblAnsD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
                    await Task.Delay(200);
                }
                MessageBox.Show($"Грешен отговор! Играта приключи. Общ резултат: {totalPoints}");
                this.Close();
            }
        }
    }
}
